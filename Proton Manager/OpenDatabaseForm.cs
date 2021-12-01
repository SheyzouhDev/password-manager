using Proton_Manager.Entity;
using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace Proton_Manager
{
    public partial class OpenDatabaseForm : Form
    {
        private string dbFile;

        public OpenDatabaseForm(string dbFile)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            this.dbFile = dbFile;
            Text += $" - {Path.GetFileName(dbFile)}";
        }

        private void TogglePasswordChar(object sender, EventArgs e)
        {
            tbxPassword.UseSystemPasswordChar = !tbxPassword.UseSystemPasswordChar;
        }

        private void Accept(object sender, EventArgs e)
        {
            var hash = Security.GetHash(tbxPassword.Text);
            var file = Security.DecryptFile(hash, dbFile);

            if (!string.IsNullOrWhiteSpace(file))
            {
                var json = File.ReadAllText(file);
                File.Delete(file);

                ((ProtonMain)Owner).Database = JsonSerializer.Deserialize<Database>(json);
                ((ProtonMain)Owner).Database.Hash = hash;
            }
            else
            {
                MessageBox.Show("Password Invalid", "Proton Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxPassword.Clear();
                DialogResult = DialogResult.None;
            }
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            tbxPassword.Select();
        }
    }
}
