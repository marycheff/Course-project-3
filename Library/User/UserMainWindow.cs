using Library.Book.UserControls;
using Library.DB;
using Library.User.UserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Library
{
    public partial class UserMainWindow : Form
    {
        public UserMainWindow()
        {
            InitializeComponent();
        }
        private void UserMainWindow_Load(object sender, EventArgs e)
        {
 
            btnBooksList.PerformClick();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение выхода", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Close();
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                Control currentControl = flowLayoutPanel1.Controls[0];
                flowLayoutPanel1.Controls.Remove(currentControl);
                flowLayoutPanel1.Controls.Clear();
                currentControl.Dispose(); // Освобождаем ресурсы
            }

            UserInfo userInfo = Registration.UserInfo;
            UserProfile userProfile = new UserProfile(userInfo.Name, userInfo.Login, userInfo.Email);
            userProfile.RefreshRequest += MyUserControl_Refresh;
            flowLayoutPanel1.Controls.Add(userProfile);
            userProfile.Focus();

        }
        private void MyUserControl_Refresh(object sender, EventArgs e)
        {
            btnProfile.PerformClick();
        }

        private void btnBooksList_Click(object sender, EventArgs e)
        {
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
                BookControl bookControl = new BookControl(book);
                flowLayoutPanel1.Controls.Add(bookControl);
            }

        }
    }
}
