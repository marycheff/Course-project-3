namespace Library
{
    partial class AdminMainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.btnGiveBook = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAddBooks = new System.Windows.Forms.Button();
            this.btnAllBooks = new System.Windows.Forms.Button();
            this.btnAddUsers = new System.Windows.Forms.Button();
            this.btnAllUsers = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(82)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGiveBook);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnAddBooks);
            this.panel1.Controls.Add(this.btnAllBooks);
            this.panel1.Controls.Add(this.btnAddUsers);
            this.panel1.Controls.Add(this.btnAllUsers);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 684);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(-3, 621);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 1);
            this.label1.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(195, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1070, 684);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // btnGiveBook
            // 
            this.btnGiveBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGiveBook.FlatAppearance.BorderSize = 0;
            this.btnGiveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiveBook.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnGiveBook.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGiveBook.Image = ((System.Drawing.Image)(resources.GetObject("btnGiveBook.Image")));
            this.btnGiveBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiveBook.Location = new System.Drawing.Point(0, 253);
            this.btnGiveBook.Name = "btnGiveBook";
            this.btnGiveBook.Size = new System.Drawing.Size(200, 63);
            this.btnGiveBook.TabIndex = 5;
            this.btnGiveBook.Text = "   Выдать книгу";
            this.btnGiveBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGiveBook.UseVisualStyleBackColor = true;
            this.btnGiveBook.Click += new System.EventHandler(this.btnGiveBook_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 621);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 63);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "          Выход";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAddBooks
            // 
            this.btnAddBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddBooks.FlatAppearance.BorderSize = 0;
            this.btnAddBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBooks.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddBooks.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddBooks.Image = global::Library.Properties.Resources.add_book;
            this.btnAddBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBooks.Location = new System.Drawing.Point(0, 190);
            this.btnAddBooks.Name = "btnAddBooks";
            this.btnAddBooks.Size = new System.Drawing.Size(200, 63);
            this.btnAddBooks.TabIndex = 3;
            this.btnAddBooks.Text = "   Добавить книгу";
            this.btnAddBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddBooks.UseVisualStyleBackColor = true;
            this.btnAddBooks.Click += new System.EventHandler(this.btnAddBooks_Click);
            // 
            // btnAllBooks
            // 
            this.btnAllBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllBooks.FlatAppearance.BorderSize = 0;
            this.btnAllBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllBooks.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAllBooks.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAllBooks.Image = global::Library.Properties.Resources.book;
            this.btnAllBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllBooks.Location = new System.Drawing.Point(0, 127);
            this.btnAllBooks.Name = "btnAllBooks";
            this.btnAllBooks.Size = new System.Drawing.Size(200, 63);
            this.btnAllBooks.TabIndex = 2;
            this.btnAllBooks.Text = "   Все книги";
            this.btnAllBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllBooks.UseVisualStyleBackColor = true;
            this.btnAllBooks.Click += new System.EventHandler(this.btnAllBooks_Click);
            // 
            // btnAddUsers
            // 
            this.btnAddUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddUsers.FlatAppearance.BorderSize = 0;
            this.btnAddUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUsers.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUsers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddUsers.Image = global::Library.Properties.Resources.add_user32;
            this.btnAddUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUsers.Location = new System.Drawing.Point(0, 63);
            this.btnAddUsers.Name = "btnAddUsers";
            this.btnAddUsers.Size = new System.Drawing.Size(200, 64);
            this.btnAddUsers.TabIndex = 1;
            this.btnAddUsers.Text = "   Добавить польз..";
            this.btnAddUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddUsers.UseVisualStyleBackColor = true;
            this.btnAddUsers.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnAllUsers
            // 
            this.btnAllUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllUsers.FlatAppearance.BorderSize = 0;
            this.btnAllUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllUsers.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAllUsers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAllUsers.Image = global::Library.Properties.Resources.user32;
            this.btnAllUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllUsers.Location = new System.Drawing.Point(0, 0);
            this.btnAllUsers.Name = "btnAllUsers";
            this.btnAllUsers.Size = new System.Drawing.Size(200, 63);
            this.btnAllUsers.TabIndex = 0;
            this.btnAllUsers.Text = "  Все пользователи";
            this.btnAllUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllUsers.UseVisualStyleBackColor = true;
            this.btnAllUsers.Click += new System.EventHandler(this.btnAllUsers_Click);
            // 
            // AdminMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "AdminMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека - Панель администратора";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAllUsers;
        private System.Windows.Forms.Button btnAddUsers;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAllBooks;
        private System.Windows.Forms.Button btnAddBooks;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnGiveBook;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label label1;
    }
}