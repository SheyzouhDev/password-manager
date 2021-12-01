
namespace Proton_Manager
{
    partial class ProtonMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProtonMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNewDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpenDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCloseDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSaveDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLockDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExitApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAddEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCopyUsername = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCopyPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.DtgEntries = new System.Windows.Forms.DataGridView();
            this.contextMenuDtg = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuCopyUsername = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuCopyPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuAddEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuEditEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuDeleteEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuLockDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgEntries)).BeginInit();
            this.contextMenuDtg.SuspendLayout();
            this.contextMenuNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuEntry});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNewDatabase,
            this.MenuOpenDatabase,
            this.MenuCloseDatabase,
            this.MenuSaveDatabase,
            this.MenuLockDatabase,
            this.MenuExitApplication});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(37, 20);
            this.MenuFile.Text = "File";
            this.MenuFile.DropDownOpening += new System.EventHandler(this.MenuFileOpening);
            // 
            // MenuNewDatabase
            // 
            this.MenuNewDatabase.Name = "MenuNewDatabase";
            this.MenuNewDatabase.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MenuNewDatabase.Size = new System.Drawing.Size(148, 22);
            this.MenuNewDatabase.Text = "New";
            this.MenuNewDatabase.Click += new System.EventHandler(this.NewDatabase);
            // 
            // MenuOpenDatabase
            // 
            this.MenuOpenDatabase.Name = "MenuOpenDatabase";
            this.MenuOpenDatabase.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuOpenDatabase.Size = new System.Drawing.Size(148, 22);
            this.MenuOpenDatabase.Text = "Open";
            this.MenuOpenDatabase.Click += new System.EventHandler(this.OpenDatabase);
            // 
            // MenuCloseDatabase
            // 
            this.MenuCloseDatabase.Name = "MenuCloseDatabase";
            this.MenuCloseDatabase.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.MenuCloseDatabase.Size = new System.Drawing.Size(148, 22);
            this.MenuCloseDatabase.Text = "Close";
            this.MenuCloseDatabase.Click += new System.EventHandler(this.CloseDatabase);
            // 
            // MenuSaveDatabase
            // 
            this.MenuSaveDatabase.Name = "MenuSaveDatabase";
            this.MenuSaveDatabase.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuSaveDatabase.Size = new System.Drawing.Size(148, 22);
            this.MenuSaveDatabase.Text = "Save";
            this.MenuSaveDatabase.Click += new System.EventHandler(this.SaveDatabase);
            // 
            // MenuLockDatabase
            // 
            this.MenuLockDatabase.Name = "MenuLockDatabase";
            this.MenuLockDatabase.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.MenuLockDatabase.Size = new System.Drawing.Size(148, 22);
            this.MenuLockDatabase.Text = "Lock";
            this.MenuLockDatabase.Click += new System.EventHandler(this.LockDatabase);
            // 
            // MenuExitApplication
            // 
            this.MenuExitApplication.Name = "MenuExitApplication";
            this.MenuExitApplication.Size = new System.Drawing.Size(148, 22);
            this.MenuExitApplication.Text = "Exit";
            this.MenuExitApplication.Click += new System.EventHandler(this.ExitApplication);
            // 
            // MenuEntry
            // 
            this.MenuEntry.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAddEntry,
            this.MenuCopyUsername,
            this.MenuCopyPassword});
            this.MenuEntry.Name = "MenuEntry";
            this.MenuEntry.Size = new System.Drawing.Size(46, 20);
            this.MenuEntry.Text = "Entry";
            this.MenuEntry.DropDownOpening += new System.EventHandler(this.MenuEntryOpening);
            // 
            // MenuAddEntry
            // 
            this.MenuAddEntry.Name = "MenuAddEntry";
            this.MenuAddEntry.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.MenuAddEntry.Size = new System.Drawing.Size(199, 22);
            this.MenuAddEntry.Text = "Add Entry";
            this.MenuAddEntry.Click += new System.EventHandler(this.AddEntry);
            // 
            // MenuCopyUsername
            // 
            this.MenuCopyUsername.Name = "MenuCopyUsername";
            this.MenuCopyUsername.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.MenuCopyUsername.Size = new System.Drawing.Size(199, 22);
            this.MenuCopyUsername.Text = "Copy Username";
            this.MenuCopyUsername.Click += new System.EventHandler(this.CopyUsername);
            // 
            // MenuCopyPassword
            // 
            this.MenuCopyPassword.Name = "MenuCopyPassword";
            this.MenuCopyPassword.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.MenuCopyPassword.Size = new System.Drawing.Size(199, 22);
            this.MenuCopyPassword.Text = "Copy Password";
            this.MenuCopyPassword.Click += new System.EventHandler(this.CopyPassword);
            // 
            // DtgEntries
            // 
            this.DtgEntries.AllowUserToAddRows = false;
            this.DtgEntries.AllowUserToDeleteRows = false;
            this.DtgEntries.AllowUserToResizeRows = false;
            this.DtgEntries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgEntries.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.DtgEntries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtgEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgEntries.ContextMenuStrip = this.contextMenuDtg;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgEntries.DefaultCellStyle = dataGridViewCellStyle2;
            this.DtgEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgEntries.Location = new System.Drawing.Point(0, 24);
            this.DtgEntries.Name = "DtgEntries";
            this.DtgEntries.ReadOnly = true;
            this.DtgEntries.RowTemplate.Height = 25;
            this.DtgEntries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgEntries.ShowCellToolTips = false;
            this.DtgEntries.ShowEditingIcon = false;
            this.DtgEntries.Size = new System.Drawing.Size(800, 426);
            this.DtgEntries.TabIndex = 1;
            this.DtgEntries.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DtgEntriesCellFormatting);
            // 
            // contextMenuDtg
            // 
            this.contextMenuDtg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuCopyUsername,
            this.ContextMenuCopyPassword,
            this.ContextMenuAddEntry,
            this.ContextMenuEditEntry,
            this.ContextMenuDeleteEntry});
            this.contextMenuDtg.Name = "contextMenuDtg";
            this.contextMenuDtg.Size = new System.Drawing.Size(159, 114);
            // 
            // ContextMenuCopyUsername
            // 
            this.ContextMenuCopyUsername.Name = "ContextMenuCopyUsername";
            this.ContextMenuCopyUsername.Size = new System.Drawing.Size(158, 22);
            this.ContextMenuCopyUsername.Text = "Copy Username";
            this.ContextMenuCopyUsername.Click += new System.EventHandler(this.CopyUsername);
            // 
            // ContextMenuCopyPassword
            // 
            this.ContextMenuCopyPassword.Name = "ContextMenuCopyPassword";
            this.ContextMenuCopyPassword.Size = new System.Drawing.Size(158, 22);
            this.ContextMenuCopyPassword.Text = "Copy Password";
            this.ContextMenuCopyPassword.Click += new System.EventHandler(this.CopyPassword);
            // 
            // ContextMenuAddEntry
            // 
            this.ContextMenuAddEntry.Name = "ContextMenuAddEntry";
            this.ContextMenuAddEntry.Size = new System.Drawing.Size(158, 22);
            this.ContextMenuAddEntry.Text = "Add Entry";
            this.ContextMenuAddEntry.Click += new System.EventHandler(this.AddEntry);
            // 
            // ContextMenuEditEntry
            // 
            this.ContextMenuEditEntry.Name = "ContextMenuEditEntry";
            this.ContextMenuEditEntry.Size = new System.Drawing.Size(158, 22);
            this.ContextMenuEditEntry.Text = "Edit Entry";
            this.ContextMenuEditEntry.Click += new System.EventHandler(this.EditEntry);
            // 
            // ContextMenuDeleteEntry
            // 
            this.ContextMenuDeleteEntry.Name = "ContextMenuDeleteEntry";
            this.ContextMenuDeleteEntry.Size = new System.Drawing.Size(158, 22);
            this.ContextMenuDeleteEntry.Text = "Delete Entry";
            this.ContextMenuDeleteEntry.Click += new System.EventHandler(this.DeleteEntry);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipTitle = "ProtonManager";
            this.notifyIcon.ContextMenuStrip = this.contextMenuNotify;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Proton Manager";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuNotify
            // 
            this.contextMenuNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuLockDatabase,
            this.contextMenuExit});
            this.contextMenuNotify.Name = "contextMenuNorify";
            this.contextMenuNotify.Size = new System.Drawing.Size(100, 48);
            this.contextMenuNotify.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuNotifyOpening);
            // 
            // contextMenuLockDatabase
            // 
            this.contextMenuLockDatabase.Name = "contextMenuLockDatabase";
            this.contextMenuLockDatabase.Size = new System.Drawing.Size(99, 22);
            this.contextMenuLockDatabase.Text = "Lock";
            this.contextMenuLockDatabase.Click += new System.EventHandler(this.LockDatabase);
            // 
            // contextMenuExit
            // 
            this.contextMenuExit.Name = "contextMenuExit";
            this.contextMenuExit.Size = new System.Drawing.Size(99, 22);
            this.contextMenuExit.Text = "Exit";
            this.contextMenuExit.Click += new System.EventHandler(this.ExitApplication);
            // 
            // ProtonMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DtgEntries);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProtonMain";
            this.Text = "Proton | Password manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgEntries)).EndInit();
            this.contextMenuDtg.ResumeLayout(false);
            this.contextMenuNotify.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuNewDatabase;
        private System.Windows.Forms.ToolStripMenuItem MenuOpenDatabase;
        private System.Windows.Forms.ToolStripMenuItem MenuCloseDatabase;
        private System.Windows.Forms.ToolStripMenuItem MenuSaveDatabase;
        private System.Windows.Forms.ToolStripMenuItem MenuLockDatabase;
        private System.Windows.Forms.ToolStripMenuItem MenuExitApplication;
        private System.Windows.Forms.ToolStripMenuItem MenuEntry;
        private System.Windows.Forms.ToolStripMenuItem MenuAddEntry;
        private System.Windows.Forms.ToolStripMenuItem MenuCopyUsername;
        private System.Windows.Forms.ToolStripMenuItem MenuCopyPassword;
        private System.Windows.Forms.DataGridView DtgEntries;
        private System.Windows.Forms.ContextMenuStrip contextMenuDtg;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuCopyUsername;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuCopyPassword;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuAddEntry;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuEditEntry;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuDeleteEntry;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuNotify;
        private System.Windows.Forms.ToolStripMenuItem contextMenuLockDatabase;
        private System.Windows.Forms.ToolStripMenuItem contextMenuExit;
    }
}

