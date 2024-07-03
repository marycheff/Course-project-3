using Library.Admin.UserControls;
using Library.Book;
using Library.User.UserControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class AdminMainWindow : Form
    {
        private Button currentButton;
        public AdminMainWindow()
        {
            InitializeComponent();
            this.Load += AdminMainWindow_Load;
            if(Registration.UserInfo.RoleId == 2)
            {
                DisableAdminButtons();
            }

        }

        private void DisableAdminButtons() { 
            btnAllUsers.Visible = false;
            btnAddUsers.Visible = false;
            btnAddBooks.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }
        private void AdminMainWindow_Load(object sender, EventArgs e)
        {
            btnGiveBook.PerformClick();
        }
        private void RefreshGiveBook(object sender, EventArgs e)
        {
            btnGiveBook.PerformClick();
        }
        private void RefreshAddBooks(object sender, EventArgs e)
        {
            btnAddBooks.PerformClick();
        }
        private void ActivateButton(Button btnSender)
        {
            if (currentButton != btnSender)
            {
                DisableButton();
                currentButton = btnSender;
                currentButton.BackColor = Color.FromArgb(102, 108, 118);
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn is Button)
                {
                    previousBtn.BackColor = Color.FromArgb(78, 82, 87);
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

            ActivateButton(btnAddUsers);
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                Control currentControl = flowLayoutPanel1.Controls[0];
                flowLayoutPanel1.Controls.Remove(currentControl);
                flowLayoutPanel1.Controls.Clear();
                currentControl.Dispose();
            }

            AddUser addUser = new AddUser();
            flowLayoutPanel1.Controls.Add(addUser);
            addUser.Focus();
        }

        private void btnAllUsers_Click(object sender, EventArgs e)
        {
            ActivateButton(btnAllUsers);
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                Control currentControl = flowLayoutPanel1.Controls[0];
                flowLayoutPanel1.Controls.Remove(currentControl);
                flowLayoutPanel1.Controls.Clear();
                currentControl.Dispose(); 
            }

            CheckUser checkUser = new CheckUser();
            flowLayoutPanel1.Controls.Add(checkUser);
            checkUser.Focus();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
           ActivateButton(btnLogout);
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение выхода", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Restart();
            }
        }

        private void btnAllBooks_Click(object sender, EventArgs e)
        {
            ActivateButton(btnAllBooks);
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                Control currentControl = flowLayoutPanel1.Controls[0];
                flowLayoutPanel1.Controls.Remove(currentControl);
                flowLayoutPanel1.Controls.Clear();
                currentControl.Dispose(); 
            }

            CheckBook checkBook = new CheckBook();
            flowLayoutPanel1.Controls.Add(checkBook);
            checkBook.Focus();
        }

        public void btnAddBooks_Click(object sender, EventArgs e)
        {
            ActivateButton(btnAddBooks);
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                Control currentControl = flowLayoutPanel1.Controls[0];
                flowLayoutPanel1.Controls.Remove(currentControl);
                flowLayoutPanel1.Controls.Clear();
                currentControl.Dispose(); 
            }

            AddBook addBook = new AddBook();
            addBook.RefreshRequest += RefreshAddBooks;
            flowLayoutPanel1.Controls.Add(addBook);
            addBook.Focus();
        }

        private void btnGiveBook_Click(object sender, EventArgs e)
        {
            ActivateButton(btnGiveBook);

            if (flowLayoutPanel1.Controls.Count > 0)
            {
                Control currentControl = flowLayoutPanel1.Controls[0];
                flowLayoutPanel1.Controls.Remove(currentControl);
                flowLayoutPanel1.Controls.Clear();
                currentControl.Dispose(); 
            }
            GiveBook giveBook = new GiveBook();
            giveBook.RefreshRequest += RefreshGiveBook;
            flowLayoutPanel1.Controls.Add(giveBook);
            giveBook.Focus();



        }

        private void btnTakeBook_Click(object sender, EventArgs e)
        {
            ActivateButton(btnTakeBook);
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                Control currentControl = flowLayoutPanel1.Controls[0];
                flowLayoutPanel1.Controls.Remove(currentControl);
                flowLayoutPanel1.Controls.Clear();
                currentControl.Dispose();
            }
            TakeBook takeBook = new TakeBook();
            flowLayoutPanel1.Controls.Add(takeBook);
            takeBook.Focus();
        }

        private void btnAuthorsAndGenres_Click(object sender, EventArgs e)
        {
            ActivateButton(btnAuthorsAndGenres);
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                Control currentControl = flowLayoutPanel1.Controls[0];
                flowLayoutPanel1.Controls.Remove(currentControl);
                flowLayoutPanel1.Controls.Clear();
                currentControl.Dispose();
            }
            CheckAuthorsAndGenres checkAuthorsAndGenres = new CheckAuthorsAndGenres();
            checkAuthorsAndGenres.UpdateRequare += RefreshAuthorsAndGenres;
            flowLayoutPanel1.Controls.Add (checkAuthorsAndGenres);
            checkAuthorsAndGenres.Focus();
        }

        private void RefreshAuthorsAndGenres(object sender, EventArgs e)
        {
            btnAuthorsAndGenres.PerformClick();
            
        }
    }
}
