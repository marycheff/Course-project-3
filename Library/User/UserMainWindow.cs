using Library.Book.UserControls;
using Library.DB;
using Library.User.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class UserMainWindow : Form
    {
        private Button currentButton;
        public UserMainWindow()
        {
            InitializeComponent();
            this.Load += UserMainWindow_Load;
        }
        private void UserMainWindow_Load(object sender, EventArgs e)
        {
            btnBooksList.PerformClick();
        }
        private void RefreshProfile(object sender, EventArgs e)
        {
            btnProfile.PerformClick();
        }
        private void RefreshMyBooks(object sender, EventArgs e)
        {
            btnMyBooks.PerformClick();
        }
        private void ActivateButton(Button btnSender)
        {
            if (currentButton != btnSender)
            {
                DisableButton();
                currentButton = btnSender;
                currentButton.BackColor = Color.FromArgb(138, 146, 161);
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn is Button)
                {
                    previousBtn.BackColor = Color.FromArgb(99, 105, 115);
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение выхода", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Restart();
            }
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            //ActivateButton(btnProfile);
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                Control currentControl = flowLayoutPanel1.Controls[0];
                flowLayoutPanel1.Controls.Remove(currentControl);
                flowLayoutPanel1.Controls.Clear();
                currentControl.Dispose(); // Освобождаем ресурсы
            }
            UserInfo userInfo = Registration.UserInfo;
            UserProfile userProfile = new UserProfile(userInfo.Name, userInfo.Login, userInfo.Email);
            userProfile.RefreshRequest += RefreshProfile;
            flowLayoutPanel1.Controls.Add(userProfile);
            userProfile.Focus();

        }

        private void btnBooksList_Click(object sender, EventArgs e)
        {
            //ActivateButton(btnBooksList);
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                Control currentControl = flowLayoutPanel1.Controls[0];
                flowLayoutPanel1.Controls.Remove(currentControl);
                flowLayoutPanel1.Controls.Clear();
                currentControl.Dispose();   
            } 
            List<BookInfo> allBooks = DbBook.GetAllBooks();
            foreach (var book in allBooks)
            {
                BookCatalog bookControl = new BookCatalog(book, flowLayoutPanel1);
                flowLayoutPanel1.Controls.Add(bookControl);
            }

        }

        private void btnMyBooks_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                Control currentControl = flowLayoutPanel1.Controls[0];
                flowLayoutPanel1.Controls.Remove(currentControl);
                flowLayoutPanel1.Controls.Clear();
                currentControl.Dispose();
            }
            UserInfo userInfo = Registration.UserInfo;
            MyBooks myBooks = new MyBooks(userInfo.Id);
            myBooks.RefreshRequest += RefreshMyBooks;
            flowLayoutPanel1.Controls.Add(myBooks);
        }
    }
}
