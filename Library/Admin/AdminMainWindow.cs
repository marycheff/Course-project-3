﻿using System;
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
                currentControl.Dispose(); // Освобождаем ресурсы
            }

            CheckUser deleteUser = new CheckUser();
            flowLayoutPanel1.Controls.Add(deleteUser);
            deleteUser.Focus();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
           ActivateButton(btnLogout);
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение выхода", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Close();
            }
        }

        private void btnAllBooks_Click(object sender, EventArgs e)
        {
            ActivateButton(btnAllBooks);
        }

        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            ActivateButton(btnAddBooks);
        }



        private void btnGiveBook_Click(object sender, EventArgs e)
        {
            ActivateButton(btnGiveBook);
        }
    }
}
