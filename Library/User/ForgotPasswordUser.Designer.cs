namespace Library
{
    partial class ForgotPasswordUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordUser));
            this.tabAuthLabelLogin = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tabAuthLabelLogin
            // 
            this.tabAuthLabelLogin.AutoSize = true;
            this.tabAuthLabelLogin.ForeColor = System.Drawing.Color.DimGray;
            this.tabAuthLabelLogin.Location = new System.Drawing.Point(19, 128);
            this.tabAuthLabelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tabAuthLabelLogin.Name = "tabAuthLabelLogin";
            this.tabAuthLabelLogin.Size = new System.Drawing.Size(335, 20);
            this.tabAuthLabelLogin.TabIndex = 5;
            this.tabAuthLabelLogin.Text = "Введите email, указанный при регистрации";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(23, 153);
            this.textEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(433, 26);
            this.textEmail.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.AutoSize = true;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSend.Location = new System.Drawing.Point(158, 295);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(158, 34);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Отправить код";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(340, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 25);
            this.button2.TabIndex = 7;
            this.button2.Text = "Нет доступа к email?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Восстановление пароля";
            // 
            // ForgotPasswordUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 341);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tabAuthLabelLogin);
            this.Controls.Add(this.textEmail);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(490, 380);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(490, 380);
            this.Name = "ForgotPasswordUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека - Восстановление пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tabAuthLabelLogin;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}