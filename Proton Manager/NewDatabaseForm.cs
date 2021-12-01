using System;
using System.Windows.Forms;

namespace Proton_Manager
{
    public partial class NewDatabaseForm : Form
    {
        public NewDatabaseForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void Accept(object sender, EventArgs e)
        {
            if (tbxPassword.Text.Equals(tbxPasswordConfirm.Text))
            {
                ((ProtonMain)Owner).Database.Hash = Security.GetHash(tbxPassword.Text);
            }
            else
            {
                MessageBox.Show("Passwords do not match", "Proton Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
            }
        }

        private void TogglePassword(object sender, EventArgs e)
        {
            tbxPassword.UseSystemPasswordChar = !tbxPassword.UseSystemPasswordChar;
            tbxPasswordConfirm.UseSystemPasswordChar = !tbxPasswordConfirm.UseSystemPasswordChar;
        }
    }
}
