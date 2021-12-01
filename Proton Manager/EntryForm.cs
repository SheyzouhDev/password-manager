using Proton_Manager.Entity;
using System;
using System.Windows.Forms;

namespace Proton_Manager
{
    public partial class EntryForm : Form
    {

        public Entry Entry;
        private Entry initEntry;

        public EntryForm(Entry entry = null)
        {
            InitializeComponent();

            if (entry != null)
            {
                Entry = entry;
            }
        }

        private void Accept(object sender, EventArgs e)
        {
            if (tbxPassword.Text.Equals(tbxPasswordConfirm.Text))
            {
                Entry = new()
                {
                    UUID = Guid.NewGuid().ToString().ToUpper(),
                    Title = tbxTitle.Text,
                    Username = tbxUsername.Text,
                    Password = Security.Encrypt(tbxPassword.Text, ((ProtonMain)Owner).Database.Hash),
                    Link = tbxLink.Text,
                    CreatedAt = DateTime.Now
                };
            }
            else
            {
                MessageBox.Show("Passwords do not match", "Proton Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
            }
        }

        private void TogglePasswordChar(object sender, EventArgs e)
        {
            tbxPassword.UseSystemPasswordChar = !tbxPassword.UseSystemPasswordChar;
            tbxPasswordConfirm.UseSystemPasswordChar = !tbxPasswordConfirm.UseSystemPasswordChar;
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            tbxTitle.Select();

            if (Entry != null)
            {
                initEntry = (Entry)Entry.Clone();

                tbxTitle.DataBindings.Add("Text", Entry, "Title");
                tbxUsername.DataBindings.Add("Text", Entry, "Username");
                tbxPassword.DataBindings.Add("Text", Entry, "Password");
                tbxPasswordConfirm.Text = tbxPassword.Text;
                tbxLink.DataBindings.Add("Text", Entry, "Link");
            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (Entry is not null && DialogResult == DialogResult.Cancel)
            {
                Entry.Title = initEntry.Title;
                Entry.Username = initEntry.Username;
                Entry.Password = initEntry.Password;
                Entry.Link = initEntry.Link;
            }
        }
    }
}
