using System.Drawing;

namespace Library
{
    partial class Registration
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.tabReg = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabRegTextPatronymic = new System.Windows.Forms.TextBox();
            this.tabRegTextName = new System.Windows.Forms.TextBox();
            this.tabRegLabelEmail = new System.Windows.Forms.Label();
            this.tabRegTextEmail = new System.Windows.Forms.TextBox();
            this.tabRegTextSurname = new System.Windows.Forms.TextBox();
            this.tabRegTextPasswordRepeat = new System.Windows.Forms.TextBox();
            this.tabRegTextPassword = new System.Windows.Forms.TextBox();
            this.tabRegTextLogin = new System.Windows.Forms.TextBox();
            this.tabRegLabelName = new System.Windows.Forms.Label();
            this.tabRegButton = new System.Windows.Forms.Button();
            this.tabRegLabelPasswordRepeat = new System.Windows.Forms.Label();
            this.tabRegLabelPassword = new System.Windows.Forms.Label();
            this.tabRegLabelLogin = new System.Windows.Forms.Label();
            this.tabAuth = new System.Windows.Forms.TabPage();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.tabAuthButton = new System.Windows.Forms.Button();
            this.tabAuthLabelPassword = new System.Windows.Forms.Label();
            this.tabAuthTextPassword = new System.Windows.Forms.TextBox();
            this.tabAuthTextLogin = new System.Windows.Forms.TextBox();
            this.tabAuthLabelLogin = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabReg.SuspendLayout();
            this.tabAuth.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabReg
            // 
            this.tabReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.tabReg.Controls.Add(this.label2);
            this.tabReg.Controls.Add(this.label1);
            this.tabReg.Controls.Add(this.tabRegTextPatronymic);
            this.tabReg.Controls.Add(this.tabRegTextName);
            this.tabReg.Controls.Add(this.tabRegLabelEmail);
            this.tabReg.Controls.Add(this.tabRegTextEmail);
            this.tabReg.Controls.Add(this.tabRegTextSurname);
            this.tabReg.Controls.Add(this.tabRegTextPasswordRepeat);
            this.tabReg.Controls.Add(this.tabRegTextPassword);
            this.tabReg.Controls.Add(this.tabRegTextLogin);
            this.tabReg.Controls.Add(this.tabRegLabelName);
            this.tabReg.Controls.Add(this.tabRegButton);
            this.tabReg.Controls.Add(this.tabRegLabelPasswordRepeat);
            this.tabReg.Controls.Add(this.tabRegLabelPassword);
            this.tabReg.Controls.Add(this.tabRegLabelLogin);
            this.tabReg.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabReg.ForeColor = System.Drawing.Color.Gainsboro;
            this.tabReg.Location = new System.Drawing.Point(4, 30);
            this.tabReg.Margin = new System.Windows.Forms.Padding(0);
            this.tabReg.Name = "tabReg";
            this.tabReg.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabReg.Size = new System.Drawing.Size(537, 454);
            this.tabReg.TabIndex = 1;
            this.tabReg.Text = "Регистрация";
            this.tabReg.Click += new System.EventHandler(this.tabReg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(354, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Отчество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(188, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Имя";
            // 
            // tabRegTextPatronymic
            // 
            this.tabRegTextPatronymic.Location = new System.Drawing.Point(354, 48);
            this.tabRegTextPatronymic.Name = "tabRegTextPatronymic";
            this.tabRegTextPatronymic.Size = new System.Drawing.Size(157, 30);
            this.tabRegTextPatronymic.TabIndex = 3;
            // 
            // tabRegTextName
            // 
            this.tabRegTextName.Location = new System.Drawing.Point(192, 48);
            this.tabRegTextName.Name = "tabRegTextName";
            this.tabRegTextName.Size = new System.Drawing.Size(156, 30);
            this.tabRegTextName.TabIndex = 2;
            // 
            // tabRegLabelEmail
            // 
            this.tabRegLabelEmail.AutoSize = true;
            this.tabRegLabelEmail.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabRegLabelEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.tabRegLabelEmail.Location = new System.Drawing.Point(25, 174);
            this.tabRegLabelEmail.Name = "tabRegLabelEmail";
            this.tabRegLabelEmail.Size = new System.Drawing.Size(55, 23);
            this.tabRegLabelEmail.TabIndex = 14;
            this.tabRegLabelEmail.Text = "Email";
            // 
            // tabRegTextEmail
            // 
            this.tabRegTextEmail.Location = new System.Drawing.Point(29, 200);
            this.tabRegTextEmail.Name = "tabRegTextEmail";
            this.tabRegTextEmail.Size = new System.Drawing.Size(482, 30);
            this.tabRegTextEmail.TabIndex = 5;
            // 
            // tabRegTextSurname
            // 
            this.tabRegTextSurname.Location = new System.Drawing.Point(29, 48);
            this.tabRegTextSurname.Name = "tabRegTextSurname";
            this.tabRegTextSurname.Size = new System.Drawing.Size(157, 30);
            this.tabRegTextSurname.TabIndex = 1;
            // 
            // tabRegTextPasswordRepeat
            // 
            this.tabRegTextPasswordRepeat.Location = new System.Drawing.Point(29, 352);
            this.tabRegTextPasswordRepeat.Name = "tabRegTextPasswordRepeat";
            this.tabRegTextPasswordRepeat.PasswordChar = '•';
            this.tabRegTextPasswordRepeat.Size = new System.Drawing.Size(482, 30);
            this.tabRegTextPasswordRepeat.TabIndex = 7;
            // 
            // tabRegTextPassword
            // 
            this.tabRegTextPassword.Location = new System.Drawing.Point(29, 276);
            this.tabRegTextPassword.Name = "tabRegTextPassword";
            this.tabRegTextPassword.PasswordChar = '•';
            this.tabRegTextPassword.Size = new System.Drawing.Size(482, 30);
            this.tabRegTextPassword.TabIndex = 6;
            // 
            // tabRegTextLogin
            // 
            this.tabRegTextLogin.Location = new System.Drawing.Point(29, 124);
            this.tabRegTextLogin.Name = "tabRegTextLogin";
            this.tabRegTextLogin.Size = new System.Drawing.Size(482, 30);
            this.tabRegTextLogin.TabIndex = 4;
            // 
            // tabRegLabelName
            // 
            this.tabRegLabelName.AutoSize = true;
            this.tabRegLabelName.ForeColor = System.Drawing.Color.Gainsboro;
            this.tabRegLabelName.Location = new System.Drawing.Point(25, 22);
            this.tabRegLabelName.Name = "tabRegLabelName";
            this.tabRegLabelName.Size = new System.Drawing.Size(89, 23);
            this.tabRegLabelName.TabIndex = 12;
            this.tabRegLabelName.Text = "Фамилия";
            // 
            // tabRegButton
            // 
            this.tabRegButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.tabRegButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(115)))), ((int)(((byte)(128)))));
            this.tabRegButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.tabRegButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.tabRegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabRegButton.Location = new System.Drawing.Point(170, 408);
            this.tabRegButton.Name = "tabRegButton";
            this.tabRegButton.Size = new System.Drawing.Size(207, 38);
            this.tabRegButton.TabIndex = 8;
            this.tabRegButton.Text = "Зарегистрироваться";
            this.tabRegButton.UseVisualStyleBackColor = false;
            this.tabRegButton.Click += new System.EventHandler(this.tabRegButton_Click_1);
            // 
            // tabRegLabelPasswordRepeat
            // 
            this.tabRegLabelPasswordRepeat.AutoSize = true;
            this.tabRegLabelPasswordRepeat.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabRegLabelPasswordRepeat.ForeColor = System.Drawing.Color.Gainsboro;
            this.tabRegLabelPasswordRepeat.Location = new System.Drawing.Point(25, 326);
            this.tabRegLabelPasswordRepeat.Name = "tabRegLabelPasswordRepeat";
            this.tabRegLabelPasswordRepeat.Size = new System.Drawing.Size(152, 23);
            this.tabRegLabelPasswordRepeat.TabIndex = 9;
            this.tabRegLabelPasswordRepeat.Text = "Пароль еще раз";
            this.tabRegLabelPasswordRepeat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabRegLabelPassword
            // 
            this.tabRegLabelPassword.AutoSize = true;
            this.tabRegLabelPassword.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabRegLabelPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.tabRegLabelPassword.Location = new System.Drawing.Point(25, 250);
            this.tabRegLabelPassword.Name = "tabRegLabelPassword";
            this.tabRegLabelPassword.Size = new System.Drawing.Size(75, 23);
            this.tabRegLabelPassword.TabIndex = 7;
            this.tabRegLabelPassword.Text = "Пароль";
            // 
            // tabRegLabelLogin
            // 
            this.tabRegLabelLogin.AutoSize = true;
            this.tabRegLabelLogin.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabRegLabelLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.tabRegLabelLogin.Location = new System.Drawing.Point(25, 98);
            this.tabRegLabelLogin.Name = "tabRegLabelLogin";
            this.tabRegLabelLogin.Size = new System.Drawing.Size(63, 23);
            this.tabRegLabelLogin.TabIndex = 5;
            this.tabRegLabelLogin.Text = "Логин";
            // 
            // tabAuth
            // 
            this.tabAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.tabAuth.Controls.Add(this.btnResetPass);
            this.tabAuth.Controls.Add(this.tabAuthButton);
            this.tabAuth.Controls.Add(this.tabAuthLabelPassword);
            this.tabAuth.Controls.Add(this.tabAuthTextPassword);
            this.tabAuth.Controls.Add(this.tabAuthTextLogin);
            this.tabAuth.Controls.Add(this.tabAuthLabelLogin);
            this.tabAuth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabAuth.Location = new System.Drawing.Point(4, 30);
            this.tabAuth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAuth.Name = "tabAuth";
            this.tabAuth.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAuth.Size = new System.Drawing.Size(537, 454);
            this.tabAuth.TabIndex = 0;
            this.tabAuth.Text = "Вход";
            this.tabAuth.Click += new System.EventHandler(this.tabAuth_Click);
            // 
            // btnResetPass
            // 
            this.btnResetPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.btnResetPass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(115)))), ((int)(((byte)(128)))));
            this.btnResetPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.btnResetPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.btnResetPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPass.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResetPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.btnResetPass.Location = new System.Drawing.Point(396, 235);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(110, 24);
            this.btnResetPass.TabIndex = 12;
            this.btnResetPass.Text = "Забыли пароль?";
            this.btnResetPass.UseVisualStyleBackColor = false;
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // tabAuthButton
            // 
            this.tabAuthButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.tabAuthButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(115)))), ((int)(((byte)(128)))));
            this.tabAuthButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.tabAuthButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.tabAuthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabAuthButton.Font = new System.Drawing.Font("Tahoma", 14F);
            this.tabAuthButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.tabAuthButton.Location = new System.Drawing.Point(191, 406);
            this.tabAuthButton.Name = "tabAuthButton";
            this.tabAuthButton.Size = new System.Drawing.Size(168, 40);
            this.tabAuthButton.TabIndex = 11;
            this.tabAuthButton.Text = "Войти";
            this.tabAuthButton.UseVisualStyleBackColor = false;
            // 
            // tabAuthLabelPassword
            // 
            this.tabAuthLabelPassword.AutoSize = true;
            this.tabAuthLabelPassword.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAuthLabelPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.tabAuthLabelPassword.Location = new System.Drawing.Point(26, 173);
            this.tabAuthLabelPassword.Name = "tabAuthLabelPassword";
            this.tabAuthLabelPassword.Size = new System.Drawing.Size(75, 23);
            this.tabAuthLabelPassword.TabIndex = 3;
            this.tabAuthLabelPassword.Text = "Пароль";
            // 
            // tabAuthTextPassword
            // 
            this.tabAuthTextPassword.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAuthTextPassword.Location = new System.Drawing.Point(30, 199);
            this.tabAuthTextPassword.Name = "tabAuthTextPassword";
            this.tabAuthTextPassword.PasswordChar = '•';
            this.tabAuthTextPassword.Size = new System.Drawing.Size(476, 28);
            this.tabAuthTextPassword.TabIndex = 2;
            // 
            // tabAuthTextLogin
            // 
            this.tabAuthTextLogin.BackColor = System.Drawing.SystemColors.Window;
            this.tabAuthTextLogin.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAuthTextLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabAuthTextLogin.Location = new System.Drawing.Point(30, 121);
            this.tabAuthTextLogin.Name = "tabAuthTextLogin";
            this.tabAuthTextLogin.Size = new System.Drawing.Size(476, 28);
            this.tabAuthTextLogin.TabIndex = 0;
            // 
            // tabAuthLabelLogin
            // 
            this.tabAuthLabelLogin.AutoSize = true;
            this.tabAuthLabelLogin.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAuthLabelLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.tabAuthLabelLogin.Location = new System.Drawing.Point(26, 95);
            this.tabAuthLabelLogin.Name = "tabAuthLabelLogin";
            this.tabAuthLabelLogin.Size = new System.Drawing.Size(63, 23);
            this.tabAuthLabelLogin.TabIndex = 1;
            this.tabAuthLabelLogin.Text = "Логин";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAuth);
            this.tabControl1.Controls.Add(this.tabReg);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(-5, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(545, 488);
            this.tabControl1.TabIndex = 0;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 481);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека - Вход в систему";
            this.tabReg.ResumeLayout(false);
            this.tabReg.PerformLayout();
            this.tabAuth.ResumeLayout(false);
            this.tabAuth.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private System.Windows.Forms.TabPage tabReg;
        private System.Windows.Forms.Label tabRegLabelEmail;
        private System.Windows.Forms.TextBox tabRegTextEmail;
        private System.Windows.Forms.TextBox tabRegTextSurname;
        private System.Windows.Forms.TextBox tabRegTextPassword;
        private System.Windows.Forms.TextBox tabRegTextLogin;
        private System.Windows.Forms.Label tabRegLabelName;
        private System.Windows.Forms.Button tabRegButton;
        private System.Windows.Forms.Label tabRegLabelPasswordRepeat;
        private System.Windows.Forms.Label tabRegLabelPassword;
        private System.Windows.Forms.Label tabRegLabelLogin;
        private System.Windows.Forms.TabPage tabAuth;
        private System.Windows.Forms.Button btnResetPass;
        private System.Windows.Forms.Button tabAuthButton;
        private System.Windows.Forms.Label tabAuthLabelPassword;
        private System.Windows.Forms.TextBox tabAuthTextPassword;
        private System.Windows.Forms.TextBox tabAuthTextLogin;
        private System.Windows.Forms.Label tabAuthLabelLogin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox tabRegTextPasswordRepeat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tabRegTextPatronymic;
        private System.Windows.Forms.TextBox tabRegTextName;
    }
}

