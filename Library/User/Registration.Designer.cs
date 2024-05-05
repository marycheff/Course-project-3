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
            this.tabRegTextLogin = new System.Windows.Forms.TextBox();
            this.tabRegLabelLogin = new System.Windows.Forms.Label();
            this.tabRegTextPassword = new System.Windows.Forms.TextBox();
            this.tabRegLabelPassword = new System.Windows.Forms.Label();
            this.tabRegTextPasswordRepeat = new System.Windows.Forms.TextBox();
            this.tabRegLabelPasswordRepeat = new System.Windows.Forms.Label();
            this.tabRegButton = new System.Windows.Forms.Button();
            this.tabRegTextName = new System.Windows.Forms.TextBox();
            this.tabRegLabelName = new System.Windows.Forms.Label();
            this.tabRegTextEmail = new System.Windows.Forms.TextBox();
            this.tabRegLabelEmail = new System.Windows.Forms.Label();
            this.tabAuth = new System.Windows.Forms.TabPage();
            this.tabAuthTextLogin = new System.Windows.Forms.TextBox();
            this.tabAuthLabelLogin = new System.Windows.Forms.Label();
            this.tabAuthTextPassword = new System.Windows.Forms.TextBox();
            this.tabAuthLabelPassword = new System.Windows.Forms.Label();
            this.tabAuthButton = new System.Windows.Forms.Button();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabReg.SuspendLayout();
            this.tabAuth.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabReg
            // 
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
            this.tabReg.Location = new System.Drawing.Point(4, 29);
            this.tabReg.Margin = new System.Windows.Forms.Padding(0);
            this.tabReg.Name = "tabReg";
            this.tabReg.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabReg.Size = new System.Drawing.Size(501, 380);
            this.tabReg.TabIndex = 1;
            this.tabReg.Text = "Регистрация";
            // 
            // tabRegTextLogin
            // 
            this.tabRegTextLogin.Location = new System.Drawing.Point(10, 113);
            this.tabRegTextLogin.Name = "tabRegTextLogin";
            this.tabRegTextLogin.Size = new System.Drawing.Size(482, 26);
            this.tabRegTextLogin.TabIndex = 4;
            // 
            // tabRegLabelLogin
            // 
            this.tabRegLabelLogin.AutoSize = true;
            this.tabRegLabelLogin.ForeColor = System.Drawing.Color.DimGray;
            this.tabRegLabelLogin.Location = new System.Drawing.Point(6, 90);
            this.tabRegLabelLogin.Name = "tabRegLabelLogin";
            this.tabRegLabelLogin.Size = new System.Drawing.Size(55, 20);
            this.tabRegLabelLogin.TabIndex = 5;
            this.tabRegLabelLogin.Text = "Логин";
            // 
            // tabRegTextPassword
            // 
            this.tabRegTextPassword.Location = new System.Drawing.Point(7, 241);
            this.tabRegTextPassword.Name = "tabRegTextPassword";
            this.tabRegTextPassword.PasswordChar = '•';
            this.tabRegTextPassword.Size = new System.Drawing.Size(482, 26);
            this.tabRegTextPassword.TabIndex = 6;
            // 
            // tabRegLabelPassword
            // 
            this.tabRegLabelPassword.AutoSize = true;
            this.tabRegLabelPassword.ForeColor = System.Drawing.Color.DimGray;
            this.tabRegLabelPassword.Location = new System.Drawing.Point(7, 218);
            this.tabRegLabelPassword.Name = "tabRegLabelPassword";
            this.tabRegLabelPassword.Size = new System.Drawing.Size(67, 20);
            this.tabRegLabelPassword.TabIndex = 7;
            this.tabRegLabelPassword.Text = "Пароль";
            // 
            // tabRegTextPasswordRepeat
            // 
            this.tabRegTextPasswordRepeat.Location = new System.Drawing.Point(7, 305);
            this.tabRegTextPasswordRepeat.Name = "tabRegTextPasswordRepeat";
            this.tabRegTextPasswordRepeat.PasswordChar = '•';
            this.tabRegTextPasswordRepeat.Size = new System.Drawing.Size(482, 26);
            this.tabRegTextPasswordRepeat.TabIndex = 8;
            // 
            // tabRegLabelPasswordRepeat
            // 
            this.tabRegLabelPasswordRepeat.AutoSize = true;
            this.tabRegLabelPasswordRepeat.ForeColor = System.Drawing.Color.DimGray;
            this.tabRegLabelPasswordRepeat.Location = new System.Drawing.Point(7, 282);
            this.tabRegLabelPasswordRepeat.Name = "tabRegLabelPasswordRepeat";
            this.tabRegLabelPasswordRepeat.Size = new System.Drawing.Size(132, 20);
            this.tabRegLabelPasswordRepeat.TabIndex = 9;
            this.tabRegLabelPasswordRepeat.Text = "Пароль еще раз";
            this.tabRegLabelPasswordRepeat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabRegButton
            // 
            this.tabRegButton.Location = new System.Drawing.Point(142, 346);
            this.tabRegButton.Name = "tabRegButton";
            this.tabRegButton.Size = new System.Drawing.Size(216, 31);
            this.tabRegButton.TabIndex = 10;
            this.tabRegButton.Text = "Зарегистрироваться";
            this.tabRegButton.UseVisualStyleBackColor = true;
            // 
            // tabRegTextName
            // 
            this.tabRegTextName.Location = new System.Drawing.Point(10, 49);
            this.tabRegTextName.Name = "tabRegTextName";
            this.tabRegTextName.Size = new System.Drawing.Size(482, 26);
            this.tabRegTextName.TabIndex = 11;
            // 
            // tabRegLabelName
            // 
            this.tabRegLabelName.AutoSize = true;
            this.tabRegLabelName.ForeColor = System.Drawing.Color.DimGray;
            this.tabRegLabelName.Location = new System.Drawing.Point(7, 26);
            this.tabRegLabelName.Name = "tabRegLabelName";
            this.tabRegLabelName.Size = new System.Drawing.Size(164, 20);
            this.tabRegLabelName.TabIndex = 12;
            this.tabRegLabelName.Text = "ФИО (через пробел)";
            // 
            // tabRegTextEmail
            // 
            this.tabRegTextEmail.Location = new System.Drawing.Point(10, 177);
            this.tabRegTextEmail.Name = "tabRegTextEmail";
            this.tabRegTextEmail.Size = new System.Drawing.Size(482, 26);
            this.tabRegTextEmail.TabIndex = 13;
            // 
            // tabRegLabelEmail
            // 
            this.tabRegLabelEmail.AutoSize = true;
            this.tabRegLabelEmail.ForeColor = System.Drawing.Color.DimGray;
            this.tabRegLabelEmail.Location = new System.Drawing.Point(7, 154);
            this.tabRegLabelEmail.Name = "tabRegLabelEmail";
            this.tabRegLabelEmail.Size = new System.Drawing.Size(48, 20);
            this.tabRegLabelEmail.TabIndex = 14;
            this.tabRegLabelEmail.Text = "Email";
            // 
            // tabAuth
            // 
            this.tabAuth.Controls.Add(this.btnResetPass);
            this.tabAuth.Controls.Add(this.tabAuthButton);
            this.tabAuth.Controls.Add(this.tabAuthLabelPassword);
            this.tabAuth.Controls.Add(this.tabAuthTextPassword);
            this.tabAuth.Controls.Add(this.tabAuthTextLogin);
            this.tabAuth.Controls.Add(this.tabAuthLabelLogin);
            this.tabAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabAuth.Location = new System.Drawing.Point(4, 29);
            this.tabAuth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAuth.Name = "tabAuth";
            this.tabAuth.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAuth.Size = new System.Drawing.Size(501, 380);
            this.tabAuth.TabIndex = 0;
            this.tabAuth.Text = "Вход";
            // 
            // tabAuthTextLogin
            // 
            this.tabAuthTextLogin.Location = new System.Drawing.Point(11, 66);
            this.tabAuthTextLogin.Name = "tabAuthTextLogin";
            this.tabAuthTextLogin.Size = new System.Drawing.Size(476, 26);
            this.tabAuthTextLogin.TabIndex = 0;
            // 
            // tabAuthLabelLogin
            // 
            this.tabAuthLabelLogin.AutoSize = true;
            this.tabAuthLabelLogin.ForeColor = System.Drawing.Color.DimGray;
            this.tabAuthLabelLogin.Location = new System.Drawing.Point(11, 43);
            this.tabAuthLabelLogin.Name = "tabAuthLabelLogin";
            this.tabAuthLabelLogin.Size = new System.Drawing.Size(55, 20);
            this.tabAuthLabelLogin.TabIndex = 1;
            this.tabAuthLabelLogin.Text = "Логин";
            // 
            // tabAuthTextPassword
            // 
            this.tabAuthTextPassword.Location = new System.Drawing.Point(11, 144);
            this.tabAuthTextPassword.Name = "tabAuthTextPassword";
            this.tabAuthTextPassword.PasswordChar = '•';
            this.tabAuthTextPassword.Size = new System.Drawing.Size(476, 26);
            this.tabAuthTextPassword.TabIndex = 2;
            // 
            // tabAuthLabelPassword
            // 
            this.tabAuthLabelPassword.AutoSize = true;
            this.tabAuthLabelPassword.ForeColor = System.Drawing.Color.DimGray;
            this.tabAuthLabelPassword.Location = new System.Drawing.Point(11, 121);
            this.tabAuthLabelPassword.Name = "tabAuthLabelPassword";
            this.tabAuthLabelPassword.Size = new System.Drawing.Size(67, 20);
            this.tabAuthLabelPassword.TabIndex = 3;
            this.tabAuthLabelPassword.Text = "Пароль";
            // 
            // tabAuthButton
            // 
            this.tabAuthButton.Location = new System.Drawing.Point(156, 346);
            this.tabAuthButton.Name = "tabAuthButton";
            this.tabAuthButton.Size = new System.Drawing.Size(188, 31);
            this.tabAuthButton.TabIndex = 11;
            this.tabAuthButton.Text = "Войти";
            this.tabAuthButton.UseVisualStyleBackColor = true;
            // 
            // btnResetPass
            // 
            this.btnResetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResetPass.Location = new System.Drawing.Point(377, 176);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(110, 24);
            this.btnResetPass.TabIndex = 12;
            this.btnResetPass.Text = "Забыли пароль?";
            this.btnResetPass.UseVisualStyleBackColor = true;
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAuth);
            this.tabControl1.Controls.Add(this.tabReg);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(-5, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(509, 413);
            this.tabControl1.TabIndex = 0;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 411);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
        private System.Windows.Forms.TextBox tabRegTextPasswordRepeat;
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
    }
}

