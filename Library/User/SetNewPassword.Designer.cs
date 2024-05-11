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
            this.textPasswordRepeat.Location = new System.Drawing.Point(12, 130);
            this.textPasswordRepeat.Name = "textPasswordRepeat";
            this.textPasswordRepeat.PasswordChar = '•';
            this.textPasswordRepeat.Size = new System.Drawing.Size(450, 26);
            this.textPasswordRepeat.TabIndex = 13;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(12, 66);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '•';
            this.textPassword.Size = new System.Drawing.Size(450, 26);
            this.textPassword.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(124, 298);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(216, 31);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabRegLabelPasswordRepeat
            // 
            this.tabRegLabelPasswordRepeat.AutoSize = true;
            this.tabRegLabelPasswordRepeat.ForeColor = System.Drawing.Color.DimGray;
            this.tabRegLabelPasswordRepeat.Location = new System.Drawing.Point(12, 107);
            this.tabRegLabelPasswordRepeat.Name = "tabRegLabelPasswordRepeat";
            this.tabRegLabelPasswordRepeat.Size = new System.Drawing.Size(132, 20);
            this.tabRegLabelPasswordRepeat.TabIndex = 14;
            this.tabRegLabelPasswordRepeat.Text = "Пароль еще раз";
            this.tabRegLabelPasswordRepeat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabRegLabelPassword
            // 
            this.tabRegLabelPassword.AutoSize = true;
            this.tabRegLabelPassword.ForeColor = System.Drawing.Color.DimGray;
            this.tabRegLabelPassword.Location = new System.Drawing.Point(12, 43);
            this.tabRegLabelPassword.Name = "tabRegLabelPassword";
            this.tabRegLabelPassword.Size = new System.Drawing.Size(67, 20);
            this.tabRegLabelPassword.TabIndex = 12;
            this.tabRegLabelPassword.Text = "Пароль";
            // 
            // SetNewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 341);
            this.Controls.Add(this.textPasswordRepeat);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabRegLabelPasswordRepeat);
            this.Controls.Add(this.tabRegLabelPassword);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SetNewPassword";
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