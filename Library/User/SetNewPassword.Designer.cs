namespace Library.User
{
    partial class SetNewPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetNewPassword));
            this.textPasswordRepeat = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabRegLabelPasswordRepeat = new System.Windows.Forms.Label();
            this.tabRegLabelPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textPasswordRepeat
            // 
            this.textPasswordRepeat.Location = new System.Drawing.Point(12, 145);
            this.textPasswordRepeat.Name = "textPasswordRepeat";
            this.textPasswordRepeat.PasswordChar = '•';
            this.textPasswordRepeat.Size = new System.Drawing.Size(450, 27);
            this.textPasswordRepeat.TabIndex = 13;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(12, 66);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '•';
            this.textPassword.Size = new System.Drawing.Size(450, 27);
            this.textPassword.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(115)))), ((int)(((byte)(128)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.btnSave.Location = new System.Drawing.Point(124, 298);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(216, 31);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabRegLabelPasswordRepeat
            // 
            this.tabRegLabelPasswordRepeat.AutoSize = true;
            this.tabRegLabelPasswordRepeat.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRegLabelPasswordRepeat.ForeColor = System.Drawing.Color.Gainsboro;
            this.tabRegLabelPasswordRepeat.Location = new System.Drawing.Point(12, 119);
            this.tabRegLabelPasswordRepeat.Name = "tabRegLabelPasswordRepeat";
            this.tabRegLabelPasswordRepeat.Size = new System.Drawing.Size(152, 23);
            this.tabRegLabelPasswordRepeat.TabIndex = 14;
            this.tabRegLabelPasswordRepeat.Text = "Пароль еще раз";
            this.tabRegLabelPasswordRepeat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabRegLabelPassword
            // 
            this.tabRegLabelPassword.AutoSize = true;
            this.tabRegLabelPassword.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRegLabelPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.tabRegLabelPassword.Location = new System.Drawing.Point(12, 40);
            this.tabRegLabelPassword.Name = "tabRegLabelPassword";
            this.tabRegLabelPassword.Size = new System.Drawing.Size(75, 23);
            this.tabRegLabelPassword.TabIndex = 12;
            this.tabRegLabelPassword.Text = "Пароль";
            // 
            // SetNewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(474, 341);
            this.Controls.Add(this.textPasswordRepeat);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabRegLabelPasswordRepeat);
            this.Controls.Add(this.tabRegLabelPassword);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetNewPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Библиотека - Установить новый пароль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPasswordRepeat;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label tabRegLabelPasswordRepeat;
        private System.Windows.Forms.Label tabRegLabelPassword;
    }
}