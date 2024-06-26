﻿namespace Library.Book.UserControls
{
    partial class BookPage
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
            this.textDescription = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReserve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textTitle
            // 
            this.textTitle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitle.Location = new System.Drawing.Point(-4, 12);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(1269, 40);
            this.textTitle.TabIndex = 0;
            this.textTitle.Text = "Название книги";
            this.textTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textDescription
            // 
            this.textDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDescription.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescription.Location = new System.Drawing.Point(354, 96);
            this.textDescription.Name = "textDescription";
            this.textDescription.Padding = new System.Windows.Forms.Padding(10);
            this.textDescription.Size = new System.Drawing.Size(788, 337);
            this.textDescription.TabIndex = 1;
            this.textDescription.Text = "Описание книги";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Library.Properties.Resources.DEFAULT;
            this.panel1.Location = new System.Drawing.Point(133, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 300);
            this.panel1.TabIndex = 2;
            // 
            // btnReserve
            // 
            this.btnReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.btnReserve.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(115)))), ((int)(((byte)(128)))));
            this.btnReserve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(146)))), ((int)(((byte)(161)))));
            this.btnReserve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(146)))), ((int)(((byte)(161)))));
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserve.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReserve.Location = new System.Drawing.Point(133, 402);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(200, 31);
            this.btnReserve.TabIndex = 8;
            this.btnReserve.Text = "Забронировать";
            this.btnReserve.UseVisualStyleBackColor = false;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // BookPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textTitle);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BookPage";
            this.Size = new System.Drawing.Size(1269, 647);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label textTitle;
        private System.Windows.Forms.Label textDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReserve;
    }
}
