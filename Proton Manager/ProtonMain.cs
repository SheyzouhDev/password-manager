using Proton_Manager.Entity;
using Proton_Manager.Helper;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Proton_Manager
{
    public partial class ProtonMain : Form
    {
        private const int DTG_PASSWORD_COLUMN_INDEX = 2;
        private const int NUMBER_OF_PASSWORD_CHAR = 8;

        public Database Database;

        private Configuration configuration;
        private Entry selectedEntry;

        public ProtonMain()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            Database = new Database();
            configuration = new Configuration();

            Load += OnFormLoad;
            Shown += OnFormShown;
            FormClosing += OnFormClosing;
        }

        #region Form Events
        private void OnFormLoad(object sender, EventArgs e)
        {
            configuration = ConfigurationHelper.LoadConfiguration();

            if (File.Exists(configuration.LastUsedFile))
            {
                configuration.LastUsedFile = null;
            }
        }
        private void OnFormShown(object sender, EventArgs e)
        {
            if (configuration.LastUsedFile is not null)
            {
                OpenDatabaseForm openDatabaseForm = new(configuration.LastUsedFile);

                if (openDatabaseForm.ShowDialog(this) == DialogResult.OK)
                {
                    DtgEntries.DataSource = Database.Entries;
                    Text = $"ProtonManager - {Path.GetFileName(configuration.LastUsedFile)}";
                }
            }
        }
        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            ConfigurationHelper.SaveConfiguration(configuration);

            if (Database != null)
                DatabaseHelper.SaveDatabase(configuration.LastUsedFile, Database);
        }
        #endregion

        #region Entry Methods
        private void AddEntry(object sender, EventArgs e)
        {
            EntryForm entryForm = new();

            if (entryForm.ShowDialog(this) == DialogResult.OK)
            {
                Database.Entries.Add(entryForm.Entry);
                DatabaseHelper.SaveDatabase(configuration.LastUsedFile, Database);
            }
        }

        private void EditEntry(object sender, EventArgs e)
        {
            if (DtgEntries.SelectedRows.Count == 1)
            {
                SetSelectedEntry();

                EntryForm entryForm = new(selectedEntry);
                selectedEntry.Password = Security.Decrypt(selectedEntry.Password, Database.Hash);

                if (entryForm.ShowDialog(this) == DialogResult.OK)
                {
                    DtgEntries.RefreshEdit();
                    selectedEntry.Password = Security.Encrypt(selectedEntry.Password, Database.Hash);
                    DatabaseHelper.SaveDatabase(configuration.LastUsedFile, Database);
                }
            }
        }

        private void DeleteEntry(object sender, EventArgs e)
        {
            SetSelectedEntry();

            var dialogResult = MessageBox.Show($"Are you sure you want to permanently delete the selected entry ?\n\n- {selectedEntry.Title}", "Proton Manager", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                Database.Entries.Remove(selectedEntry);
            }
        }

        #endregion

        #region Database Methods
        private void NewDatabase(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new();
            sfd.FileName = "Database.pm";
            sfd.Filter = "Proton Manager pm file | *.pm";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var dbFile = sfd.FileName;
                NewDatabaseForm newDatabaseForm = new();

                if (newDatabaseForm.ShowDialog(this) == DialogResult.OK)
                {
                    Database.Entries = new BindingList<Entry>();
                    DtgEntries.DataSource = Database.Entries;
                    configuration.LastUsedFile = dbFile;

                    DatabaseHelper.SaveDatabase(dbFile, Database);

                    Text = $"ProtonManager - {Path.GetFileName(dbFile)}";
                }
            }
        }
        private void OpenDatabase(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new();

            if (ofd.ShowDialog() == DialogResult.OK)
                OpenDatabaseForm(ofd.FileName);
        }
        private void OpenDatabaseForm(string dbFile)
        {
            OpenDatabaseForm openDatabaseForm = new(dbFile);

            if (openDatabaseForm.ShowDialog(this) == DialogResult.OK)
            {
                DtgEntries.DataSource = Database.Entries;
                Text = $"ProtonManager - {Path.GetFileName(dbFile)}";
                configuration.LastUsedFile = dbFile;
            }
        }
        private void SaveDatabase(object sender, EventArgs e)
        {
            DatabaseHelper.SaveDatabase(configuration.LastUsedFile, Database);
        }
        private void LockDatabase(object sender, EventArgs e)
        {
            Database = new();
            DtgEntries.DataSource = null;
            Text = "Proton Manager";
            OpenDatabaseForm(configuration.LastUsedFile);
        }
        private void CloseDatabase(object sender, EventArgs e)
        {
            Database = new();
            DtgEntries.DataSource = null;
            Text = "Proton Manager";
            configuration.LastUsedFile = null;
        }
        #endregion

        #region Menu Events
        private void MenuFileOpening(object sender, EventArgs e)
        {
            if (Database.Hash is not null)
                ToggleFileMenu(isEnabled: true);
            else
                ToggleFileMenu(isEnabled: false);
        }
        private void MenuEntryOpening(object sender, EventArgs e)
        {
            if (Database.Hash is not null)
                ToggleEntryMenu(isEnabled: true);
            else
                ToggleEntryMenu(isEnabled: false);
        }
        #endregion

        #region Methods
        private void ToggleFileMenu(bool isEnabled)
        {
            MenuSaveDatabase.Enabled = isEnabled;
            MenuCloseDatabase.Enabled = isEnabled;
            MenuLockDatabase.Enabled = isEnabled;
        }
        private void ToggleEntryMenu(bool isEnabled)
        {
            MenuAddEntry.Enabled = isEnabled;
            MenuCopyUsername.Enabled = isEnabled;
            MenuCopyPassword.Enabled = isEnabled;
        }

        private void ToggleContextMenuNotify(bool isEnabled)
        {
            contextMenuLockDatabase.Enabled = isEnabled;
            contextMenuExit.Enabled = isEnabled;
        }
        #endregion

        #region Copy Methods
        private void CopyUsername(object sender, EventArgs e)
        {
            SetSelectedEntry();

            if (selectedEntry != null)
                Clipboard.SetText(selectedEntry.Username);
        }
        private void CopyPassword(object sender, EventArgs e)
        {
            SetSelectedEntry();

            if (selectedEntry != null)
                Clipboard.SetText(Security.Decrypt(selectedEntry.Password, Database.Hash));
        }
        #endregion

        private void DtgEntriesCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == DTG_PASSWORD_COLUMN_INDEX)
            {
                e.Value = new string('*', NUMBER_OF_PASSWORD_CHAR);
            }
        }

        private void SetSelectedEntry()
        {
            selectedEntry = (Entry)DtgEntries.CurrentRow.DataBoundItem;
        }

        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contextMenuNotifyOpening(object sender, CancelEventArgs e)
        {
            if (Database.Hash is not null)
            
                ToggleContextMenuNotify(isEnabled: true);
               else
                ToggleContextMenuNotify(isEnabled: false);        
        }
    }
}