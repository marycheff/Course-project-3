namespace Library.Book.UserControls
{
    partial class BookControl
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
            this.textTitle = new System.Windows.Forms.Label();
            this.textAuthor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // textTitle
            // 
            this.textTitle.AutoSize = true;
            this.textTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitle.ForeColor = System.Drawing.Color.White;
            this.textTitle.Location = new System.Drawing.Point(3, 306);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(95, 14);
            this.textTitle.TabIndex = 1;
            this.textTitle.Text = "Название книги";
            // 
            // textAuthor
            // 
            this.textAuthor.AutoSize = true;
            this.textAuthor.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAuthor.ForeColor = System.Drawing.Color.DarkGray;
            this.textAuthor.Location = new System.Drawing.Point(3, 321);
            this.textAuthor.Name = "textAuthor";
            this.textAuthor.Size = new System.Drawing.Size(42, 16);
            this.textAuthor.TabIndex = 2;
            this.textAuthor.Text = "Автор";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Library.Properties.Resources.DEFAULT;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(18, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 300);
            this.panel1.TabIndex = 0;
            // 
            // BookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.textAuthor);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(15, 0, 0, 9);
            this.Name = "BookControl";
            this.Size = new System.Drawing.Size(235, 348);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label textTitle;
        private System.Windows.Forms.Label textAuthor;
    }
}
