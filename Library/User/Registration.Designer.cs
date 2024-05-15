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
            this.tabRegLabelEmail = new System.Windows.Forms.Label();
            this.tabRegTextEmail = new System.Windows.Forms.TextBox();
            this.tabRegTextName = new System.Windows.Forms.TextBox();
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
            this.tabReg.Controls.Add(this.tabRegLabelEmail);
            this.tabReg.Controls.Add(this.tabRegTextEmail);
            this.tabReg.Controls.Add(this.tabRegTextName);
            this.tabReg.Controls.Add(this.tabRegTextPasswordRepeat);
            this.tabReg.Controls.Add(this.tabRegTextPassword);
            this.tabReg.Controls.Add(this.tabRegTextLogin);
            this.tabReg.Controls.Add(this.tabRegLabelName);
            this.tabReg.Controls.Add(this.tabRegButton);
            this.tabReg.Controls.Add(this.tabRegLabelPasswordRepeat);
            this.tabReg.Controls.Add(this.tabRegLabelPassword);
            this.tabReg.Controls.Add(this.tabRegLabelLogin);
            this.tabReg.ForeColor = System.Drawing.Color.Gainsboro;
            this.tabReg.Location = new System.Drawing.Point(4, 28);
            this.tabReg.Margin = new System.Windows.Forms.Padding(0);
            this.tabReg.Name = "tabReg";
            this.tabReg.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabReg.Size = new System.Drawing.Size(501, 390);
            this.tabReg.TabIndex = 1;
            this.tabReg.Text = "Регистрация";
            this.tabReg.Click += new System.EventHandler(this.tabReg_Click);
            // 
            // tabRegLabelEmail
            // 
            this.tabRegLabelEmail.AutoSize = true;
            this.tabRegLabelEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.tabRegLabelEmail.Location = new System.Drawing.Point(13, 133);
            this.tabRegLabelEmail.Name = "tabRegLabelEmail";
            this.tabRegLabelEmail.Size = new System.Drawing.Size(48, 19);
            this.tabRegLabelEmail.TabIndex = 14;
            this.tabRegLabelEmail.Text = "Email";
            // 
            // tabRegTextEmail
            // 
            this.tabRegTextEmail.Location = new System.Drawing.Point(9, 156);
            this.tabRegTextEmail.Name = "tabRegTextEmail";
            this.tabRegTextEmail.Size = new System.Drawing.Size(482, 27);
            this.tabRegTextEmail.TabIndex = 3;
            // 
            // tabRegTextName
            // 
            this.tabRegTextName.Location = new System.Drawing.Point(9, 32);
            this.tabRegTextName.Name = "tabRegTextName";
            this.tabRegTextName.Size = new System.Drawing.Size(482, 27);
            this.tabRegTextName.TabIndex = 1;
            // 
            // tabRegTextPasswordRepeat
            // 
            this.tabRegTextPasswordRepeat.Location = new System.Drawing.Point(9, 280);
            this.tabRegTextPasswordRepeat.Name = "tabRegTextPasswordRepeat";
            this.tabRegTextPasswordRepeat.PasswordChar = '•';
            this.tabRegTextPasswordRepeat.Size = new System.Drawing.Size(482, 27);
            this.tabRegTextPasswordRepeat.TabIndex = 5;
            // 
            // tabRegTextPassword
            // 
            this.tabRegTextPassword.Location = new System.Drawing.Point(9, 218);
            this.tabRegTextPassword.Name = "tabRegTextPassword";
            this.tabRegTextPassword.PasswordChar = '•';
            this.tabRegTextPassword.Size = new System.Drawing.Size(482, 27);
            this.tabRegTextPassword.TabIndex = 4;
            // 
            // tabRegTextLogin
            // 
            this.tabRegTextLogin.Location = new System.Drawing.Point(9, 94);
            this.tabRegTextLogin.Name = "tabRegTextLogin";
            this.tabRegTextLogin.Size = new System.Drawing.Size(482, 27);
            this.tabRegTextLogin.TabIndex = 2;
            // 
            // tabRegLabelName
            // 
            this.tabRegLabelName.AutoSize = true;
            this.tabRegLabelName.ForeColor = System.Drawing.Color.Gainsboro;
            this.tabRegLabelName.Location = new System.Drawing.Point(13, 9);
            this.tabRegLabelName.Name = "tabRegLabelName";
            this.tabRegLabelName.Size = new System.Drawing.Size(160, 19);
            this.tabRegLabelName.TabIndex = 12;
            this.tabRegLabelName.Text = "ФИО (через пробел)";
            // 
            // tabRegButton
            // 
            this.tabRegButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.tabRegButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(115)))), ((int)(((byte)(128)))));
            this.tabRegButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.tabRegButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.tabRegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabRegButton.Location = new System.Drawing.Point(142, 342);
            this.tabRegButton.Name = "tabRegButton";
            this.tabRegButton.Size = new System.Drawing.Size(216, 31);
            this.tabRegButton.TabIndex = 6;
            this.tabRegButton.Text = "Зарегистрироваться";
            this.tabRegButton.UseVisualStyleBackColor = false;
            // 
            // tabRegLabelPasswordRepeat
            // 
            this.tabRegLabelPasswordRepeat.AutoSize = true;
            this.tabRegLabelPasswordRepeat.ForeColor = System.Drawing.Color.Gainsboro;
            this.tabRegLabelPasswordRepeat.Location = new System.Drawing.Point(13, 257);
            this.tabRegLabelPasswordRepeat.Name = "tabRegLabelPasswordRepeat";
            this.tabRegLabelPasswordRepeat.Size = new System.Drawing.Size(126, 19);
            this.tabRegLabelPasswordRepeat.TabIndex = 9;
            this.tabRegLabelPasswordRepeat.Text = "Пароль еще раз";
            this.tabRegLabelPasswordRepeat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabRegLabelPassword
            // 
            this.tabRegLabelPassword.AutoSize = true;
            this.tabRegLabelPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.tabRegLabelPassword.Location = new System.Drawing.Point(13, 195);
            this.tabRegLabelPassword.Name = "tabRegLabelPassword";
            this.tabRegLabelPassword.Size = new System.Drawing.Size(63, 19);
            this.tabRegLabelPassword.TabIndex = 7;
            this.tabRegLabelPassword.Text = "Пароль";
            // 
            // tabRegLabelLogin
            // 
            this.tabRegLabelLogin.AutoSize = true;
            this.tabRegLabelLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.tabRegLabelLogin.Location = new System.Drawing.Point(13, 71);
            this.tabRegLabelLogin.Name = "tabRegLabelLogin";
            this.tabRegLabelLogin.Size = new System.Drawing.Size(54, 19);
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
            this.tabAuth.Location = new System.Drawing.Point(4, 28);
            this.tabAuth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAuth.Name = "tabAuth";
            this.tabAuth.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAuth.Size = new System.Drawing.Size(501, 390);
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
            this.btnResetPass.Location = new System.Drawing.Point(377, 180);
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
            this.tabAuthButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.tabAuthButton.Location = new System.Drawing.Point(161, 339);
            this.tabAuthButton.Name = "tabAuthButton";
            this.tabAuthButton.Size = new System.Drawing.Size(188, 31);
            this.tabAuthButton.TabIndex = 11;
            this.tabAuthButton.Text = "Войти";
            this.tabAuthButton.UseVisualStyleBackColor = false;
            // 
            // tabAuthLabelPassword
            // 
            this.tabAuthLabelPassword.AutoSize = true;
            this.tabAuthLabelPassword.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAuthLabelPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.tabAuthLabelPassword.Location = new System.Drawing.Point(7, 116);
            this.tabAuthLabelPassword.Name = "tabAuthLabelPassword";
            this.tabAuthLabelPassword.Size = new System.Drawing.Size(75, 23);
            this.tabAuthLabelPassword.TabIndex = 3;
            this.tabAuthLabelPassword.Text = "Пароль";
            // 
            // tabAuthTextPassword
            // 
            this.tabAuthTextPassword.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAuthTextPassword.Location = new System.Drawing.Point(11, 144);
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
            this.tabAuthTextLogin.Location = new System.Drawing.Point(11, 66);
            this.tabAuthTextLogin.Name = "tabAuthTextLogin";
            this.tabAuthTextLogin.Size = new System.Drawing.Size(476, 28);
            this.tabAuthTextLogin.TabIndex = 0;
            // 
            // tabAuthLabelLogin
            // 
            this.tabAuthLabelLogin.AutoSize = true;
            this.tabAuthLabelLogin.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAuthLabelLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.tabAuthLabelLogin.Location = new System.Drawing.Point(7, 38);
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
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(-5, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(509, 422);
            this.tabControl1.TabIndex = 0;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 411);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(515, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(515, 450);
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
        private System.Windows.Forms.TextBox tabRegTextName;
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
    }
}

