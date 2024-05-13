using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class EditUserForm : Form
    {
        public string Name { get; private set; }
        public string Login { get; private set; }
        public string Email { get; private set; }
        public int RoleId { get; private set; }
        public bool SaveClicked { get; private set; }

        public EditUserForm(string name, string login, string email, int roleId)
        {
            InitializeComponent();
            textName.Text = name;
            textLogin.Text = login;
            textEmail.Text = email;
            comboRole.SelectedIndex = roleId - 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Name = textName.Text.Trim();
            Login = textLogin.Text.Trim();
            RoleId = comboRole.SelectedIndex + 1;
            Email = textEmail.Text.Trim();

            if (Validation.ValidStrings(new string[] { Name, Email, Login }) &&
                        Validation.ValidName(Name) &&
                        Validation.ValidLogin(Login) &&
                        Validation.ValidEmail(Email))
            {
                SaveClicked = true;
                Close();
            }
        }
    }

}
