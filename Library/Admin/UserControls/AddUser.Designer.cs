namespace Library
{
    partial class AddUser
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.tabAuthLabelPassword = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextSurname = new System.Windows.Forms.TextBox();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.comboRole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.TextName = new System.Windows.Forms.TextBox();
            this.TextPatronymic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(297, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(298, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин";
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.btnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(115)))), ((int)(((byte)(128)))));
            this.btnAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.btnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.btnAddUser.Location = new System.Drawing.Point(385, 615);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(302, 34);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.Text = "Добавить пользователя";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // tabAuthLabelPassword
            // 
            this.tabAuthLabelPassword.AutoSize = true;
            this.tabAuthLabelPassword.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAuthLabelPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.tabAuthLabelPassword.Location = new System.Drawing.Point(297, 364);
            this.tabAuthLabelPassword.Name = "tabAuthLabelPassword";
            this.tabAuthLabelPassword.Size = new System.Drawing.Size(75, 23);
            this.tabAuthLabelPassword.TabIndex = 8;
            this.tabAuthLabelPassword.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(385, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "ДОБАВИТЬ ПОЛЬЗОВАТЕЛЯ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(297, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email";
            // 
            // TextSurname
            // 
            this.TextSurname.Font = new System.Drawing.Font("Tahoma", 12.75F);
            this.TextSurname.Location = new System.Drawing.Point(302, 164);
            this.TextSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextSurname.Name = "TextSurname";
            this.TextSurname.Size = new System.Drawing.Size(153, 28);
            this.TextSurname.TabIndex = 0;
            // 
            // textLogin
            // 
            this.textLogin.Font = new System.Drawing.Font("Tahoma", 12.75F);
            this.textLogin.Location = new System.Drawing.Point(302, 240);
            this.textLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(475, 28);
            this.textLogin.TabIndex = 3;
            // 
            // comboRole
            // 
            this.comboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRole.Font = new System.Drawing.Font("Tahoma", 12.75F);
            this.comboRole.FormattingEnabled = true;
            this.comboRole.Items.AddRange(new object[] {
            "Администратор",
            "Библиотекарь",
            "Читатель"});
            this.comboRole.Location = new System.Drawing.Point(302, 468);
            this.comboRole.Name = "comboRole";
            this.comboRole.Size = new System.Drawing.Size(475, 29);
            this.comboRole.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(297, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Роль в системе";
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Tahoma", 12.75F);
            this.textPassword.Location = new System.Drawing.Point(302, 392);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '•';
            this.textPassword.Size = new System.Drawing.Size(474, 28);
            this.textPassword.TabIndex = 5;
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Tahoma", 12.75F);
            this.textEmail.Location = new System.Drawing.Point(301, 316);
            this.textEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(475, 28);
            this.textEmail.TabIndex = 4;
            // 
            // TextName
            // 
            this.TextName.Font = new System.Drawing.Font("Tahoma", 12.75F);
            this.TextName.Location = new System.Drawing.Point(463, 164);
            this.TextName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(153, 28);
            this.TextName.TabIndex = 1;
            // 
            // TextPatronymic
            // 
            this.TextPatronymic.Font = new System.Drawing.Font("Tahoma", 12.75F);
            this.TextPatronymic.Location = new System.Drawing.Point(623, 164);
            this.TextPatronymic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextPatronymic.Name = "TextPatronymic";
            this.TextPatronymic.Size = new System.Drawing.Size(153, 28);
            this.TextPatronymic.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(459, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Имя";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(619, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Отчество";
            // 
            // AddUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextPatronymic);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabAuthLabelPassword);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboRole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextSurname);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddUser";
            this.Size = new System.Drawing.Size(1075, 693);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label tabAuthLabelPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextSurname;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.ComboBox comboRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.TextBox TextPatronymic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
