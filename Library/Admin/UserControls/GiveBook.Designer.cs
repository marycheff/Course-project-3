using System;

namespace Library.Admin.UserControls
{
    partial class GiveBook
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
            this.components = new System.ComponentModel.Container();
            this.textReservationCode = new System.Windows.Forms.MaskedTextBox();
            this.btnCheckReservation = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textReservationDate = new System.Windows.Forms.Label();
            this.textReservationDateLabel = new System.Windows.Forms.Label();
            this.textRentedBookTitle = new System.Windows.Forms.Label();
            this.textRentedBookLabel = new System.Windows.Forms.Label();
            this.btnGiveBook = new System.Windows.Forms.Button();
            this.textUserName = new System.Windows.Forms.Label();
            this.textUserNameLabel = new System.Windows.Forms.Label();
            this.textBookId = new System.Windows.Forms.Label();
            this.textBookIdLabel = new System.Windows.Forms.Label();
            this.textUserId = new System.Windows.Forms.Label();
            this.textUserIdLael = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textReservationCode
            // 
            this.textReservationCode.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textReservationCode.Location = new System.Drawing.Point(452, 120);
            this.textReservationCode.Mask = "00-000";
            this.textReservationCode.Name = "textReservationCode";
            this.textReservationCode.Size = new System.Drawing.Size(151, 43);
            this.textReservationCode.TabIndex = 0;
            this.textReservationCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textReservationCode.Click += new EventHandler(textReservationCode_Click);
            // 
            // btnCheckReservation
            // 
            this.btnCheckReservation.AutoSize = true;
            this.btnCheckReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.btnCheckReservation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(115)))), ((int)(((byte)(128)))));
            this.btnCheckReservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.btnCheckReservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.btnCheckReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckReservation.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.btnCheckReservation.Location = new System.Drawing.Point(452, 169);
            this.btnCheckReservation.Name = "btnCheckReservation";
            this.btnCheckReservation.Size = new System.Drawing.Size(151, 35);
            this.btnCheckReservation.TabIndex = 11;
            this.btnCheckReservation.Text = "Проверить";
            this.btnCheckReservation.UseVisualStyleBackColor = false;
            this.btnCheckReservation.Click += new System.EventHandler(this.btnCheckReservation_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textUserId);
            this.panel1.Controls.Add(this.textUserIdLael);
            this.panel1.Controls.Add(this.textBookId);
            this.panel1.Controls.Add(this.textUserName);
            this.panel1.Controls.Add(this.textBookIdLabel);
            this.panel1.Controls.Add(this.textUserNameLabel);
            this.panel1.Controls.Add(this.btnGiveBook);
            this.panel1.Controls.Add(this.textReservationDate);
            this.panel1.Controls.Add(this.textReservationDateLabel);
            this.panel1.Controls.Add(this.textRentedBookTitle);
            this.panel1.Controls.Add(this.textRentedBookLabel);
            this.panel1.Location = new System.Drawing.Point(114, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 427);
            this.panel1.TabIndex = 12;
            this.panel1.Visible = false;
            // 
            // textReservationDate
            // 
            this.textReservationDate.AutoSize = true;
            this.textReservationDate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textReservationDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.textReservationDate.Location = new System.Drawing.Point(501, 263);
            this.textReservationDate.Name = "textReservationDate";
            this.textReservationDate.Size = new System.Drawing.Size(179, 23);
            this.textReservationDate.TabIndex = 23;
            this.textReservationDate.Text = "10.10.2024 17:15";
            // 
            // textReservationDateLabel
            // 
            this.textReservationDateLabel.AutoSize = true;
            this.textReservationDateLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textReservationDateLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.textReservationDateLabel.Location = new System.Drawing.Point(194, 263);
            this.textReservationDateLabel.Name = "textReservationDateLabel";
            this.textReservationDateLabel.Size = new System.Drawing.Size(191, 23);
            this.textReservationDateLabel.TabIndex = 22;
            this.textReservationDateLabel.Text = "Дата бронирования:";
            // 
            // textRentedBookTitle
            // 
            this.textRentedBookTitle.AutoSize = true;
            this.textRentedBookTitle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRentedBookTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.textRentedBookTitle.Location = new System.Drawing.Point(501, 59);
            this.textRentedBookTitle.Name = "textRentedBookTitle";
            this.textRentedBookTitle.Size = new System.Drawing.Size(135, 23);
            this.textRentedBookTitle.TabIndex = 19;
            this.textRentedBookTitle.Text = "Война и Мир";
            // 
            // textRentedBookLabel
            // 
            this.textRentedBookLabel.AutoSize = true;
            this.textRentedBookLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRentedBookLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.textRentedBookLabel.Location = new System.Drawing.Point(194, 59);
            this.textRentedBookLabel.Name = "textRentedBookLabel";
            this.textRentedBookLabel.Size = new System.Drawing.Size(74, 23);
            this.textRentedBookLabel.TabIndex = 18;
            this.textRentedBookLabel.Text = "Книга: ";
            // 
            // btnGiveBook
            // 
            this.btnGiveBook.AutoSize = true;
            this.btnGiveBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.btnGiveBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(115)))), ((int)(((byte)(128)))));
            this.btnGiveBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.btnGiveBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.btnGiveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiveBook.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiveBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.btnGiveBook.Location = new System.Drawing.Point(343, 357);
            this.btnGiveBook.Name = "btnGiveBook";
            this.btnGiveBook.Size = new System.Drawing.Size(151, 35);
            this.btnGiveBook.TabIndex = 24;
            this.btnGiveBook.Text = "Выдать";
            this.btnGiveBook.UseVisualStyleBackColor = false;
            // 
            // textUserName
            // 
            this.textUserName.AutoSize = true;
            this.textUserName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserName.ForeColor = System.Drawing.Color.Gainsboro;
            this.textUserName.Location = new System.Drawing.Point(501, 161);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(244, 23);
            this.textUserName.TabIndex = 26;
            this.textUserName.Text = "Иванов Иван Иванович";
            // 
            // textUserNameLabel
            // 
            this.textUserNameLabel.AutoSize = true;
            this.textUserNameLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserNameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.textUserNameLabel.Location = new System.Drawing.Point(194, 161);
            this.textUserNameLabel.Name = "textUserNameLabel";
            this.textUserNameLabel.Size = new System.Drawing.Size(146, 23);
            this.textUserNameLabel.TabIndex = 25;
            this.textUserNameLabel.Text = "Пользователь: ";
            // 
            // textBookId
            // 
            this.textBookId.AutoSize = true;
            this.textBookId.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBookId.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBookId.Location = new System.Drawing.Point(501, 110);
            this.textBookId.Name = "textBookId";
            this.textBookId.Size = new System.Drawing.Size(82, 23);
            this.textBookId.TabIndex = 28;
            this.textBookId.Text = "313131";
            // 
            // textBookIdLabel
            // 
            this.textBookIdLabel.AutoSize = true;
            this.textBookIdLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBookIdLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBookIdLabel.Location = new System.Drawing.Point(194, 110);
            this.textBookIdLabel.Name = "textBookIdLabel";
            this.textBookIdLabel.Size = new System.Drawing.Size(99, 23);
            this.textBookIdLabel.TabIndex = 27;
            this.textBookIdLabel.Text = "ID книги: ";
            // 
            // textUserId
            // 
            this.textUserId.AutoSize = true;
            this.textUserId.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserId.ForeColor = System.Drawing.Color.Gainsboro;
            this.textUserId.Location = new System.Drawing.Point(501, 212);
            this.textUserId.Name = "textUserId";
            this.textUserId.Size = new System.Drawing.Size(82, 23);
            this.textUserId.TabIndex = 30;
            this.textUserId.Text = "313131";
            // 
            // textUserIdLael
            // 
            this.textUserIdLael.AutoSize = true;
            this.textUserIdLael.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserIdLael.ForeColor = System.Drawing.Color.Gainsboro;
            this.textUserIdLael.Location = new System.Drawing.Point(194, 212);
            this.textUserIdLael.Name = "textUserIdLael";
            this.textUserIdLael.Size = new System.Drawing.Size(170, 23);
            this.textUserIdLael.TabIndex = 29;
            this.textUserIdLael.Text = "ID пользователя: ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(413, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 39);
            this.label4.TabIndex = 14;
            this.label4.Text = "Выдать книгу";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(447, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Код";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // GiveBook
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCheckReservation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textReservationCode);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GiveBook";
            this.Size = new System.Drawing.Size(1070, 684);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox textReservationCode;
        private System.Windows.Forms.Button btnCheckReservation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label textBookId;
        private System.Windows.Forms.Label textBookIdLabel;
        private System.Windows.Forms.Label textUserName;
        private System.Windows.Forms.Label textUserNameLabel;
        private System.Windows.Forms.Button btnGiveBook;
        private System.Windows.Forms.Label textReservationDate;
        private System.Windows.Forms.Label textReservationDateLabel;
        private System.Windows.Forms.Label textRentedBookTitle;
        private System.Windows.Forms.Label textRentedBookLabel;
        private System.Windows.Forms.Label textUserId;
        private System.Windows.Forms.Label textUserIdLael;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}
