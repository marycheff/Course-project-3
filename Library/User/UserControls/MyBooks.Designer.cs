namespace Library.User.UserControls
{
    partial class MyBooks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textRentedBookLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelReservation = new System.Windows.Forms.Button();
            this.textReservationDate = new System.Windows.Forms.Label();
            this.textReservationDateLabel = new System.Windows.Forms.Label();
            this.textReservationCode = new System.Windows.Forms.Label();
            this.textReservationCodeLabel = new System.Windows.Forms.Label();
            this.textRentedBookTitle = new System.Windows.Forms.Label();
            this.textNoRentedBook = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridReservations = new System.Windows.Forms.DataGridView();
            this.book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridRentals = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservations)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(538, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Мои книги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(541, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Забронированная";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(20, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1211, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "История бронирований";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textRentedBookLabel
            // 
            this.textRentedBookLabel.AutoSize = true;
            this.textRentedBookLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRentedBookLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.textRentedBookLabel.Location = new System.Drawing.Point(24, 23);
            this.textRentedBookLabel.Name = "textRentedBookLabel";
            this.textRentedBookLabel.Size = new System.Drawing.Size(101, 23);
            this.textRentedBookLabel.TabIndex = 11;
            this.textRentedBookLabel.Text = "Название:";
            this.textRentedBookLabel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancelReservation);
            this.panel1.Controls.Add(this.textReservationDate);
            this.panel1.Controls.Add(this.textReservationDateLabel);
            this.panel1.Controls.Add(this.textReservationCode);
            this.panel1.Controls.Add(this.textReservationCodeLabel);
            this.panel1.Controls.Add(this.textRentedBookTitle);
            this.panel1.Controls.Add(this.textNoRentedBook);
            this.panel1.Controls.Add(this.textRentedBookLabel);
            this.panel1.Location = new System.Drawing.Point(19, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1214, 138);
            this.panel1.TabIndex = 12;
            // 
            // btnCancelReservation
            // 
            this.btnCancelReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.btnCancelReservation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(115)))), ((int)(((byte)(128)))));
            this.btnCancelReservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.btnCancelReservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.btnCancelReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelReservation.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.btnCancelReservation.Location = new System.Drawing.Point(1059, 3);
            this.btnCancelReservation.Name = "btnCancelReservation";
            this.btnCancelReservation.Size = new System.Drawing.Size(148, 31);
            this.btnCancelReservation.TabIndex = 18;
            this.btnCancelReservation.Text = "Отменить бронь";
            this.btnCancelReservation.UseVisualStyleBackColor = false;
            this.btnCancelReservation.Visible = false;
            this.btnCancelReservation.Click += new System.EventHandler(this.btnCancelReservation_Click);
            // 
            // textReservationDate
            // 
            this.textReservationDate.AutoSize = true;
            this.textReservationDate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textReservationDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.textReservationDate.Location = new System.Drawing.Point(221, 91);
            this.textReservationDate.Name = "textReservationDate";
            this.textReservationDate.Size = new System.Drawing.Size(82, 23);
            this.textReservationDate.TabIndex = 17;
            this.textReservationDate.Text = "313131";
            this.textReservationDate.Visible = false;
            // 
            // textReservationDateLabel
            // 
            this.textReservationDateLabel.AutoSize = true;
            this.textReservationDateLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textReservationDateLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.textReservationDateLabel.Location = new System.Drawing.Point(24, 91);
            this.textReservationDateLabel.Name = "textReservationDateLabel";
            this.textReservationDateLabel.Size = new System.Drawing.Size(191, 23);
            this.textReservationDateLabel.TabIndex = 16;
            this.textReservationDateLabel.Text = "Дата бронирования:";
            this.textReservationDateLabel.Visible = false;
            // 
            // textReservationCode
            // 
            this.textReservationCode.AutoSize = true;
            this.textReservationCode.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textReservationCode.ForeColor = System.Drawing.Color.Gainsboro;
            this.textReservationCode.Location = new System.Drawing.Point(211, 57);
            this.textReservationCode.Name = "textReservationCode";
            this.textReservationCode.Size = new System.Drawing.Size(82, 23);
            this.textReservationCode.TabIndex = 15;
            this.textReservationCode.Text = "313131";
            this.textReservationCode.Visible = false;
            // 
            // textReservationCodeLabel
            // 
            this.textReservationCodeLabel.AutoSize = true;
            this.textReservationCodeLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textReservationCodeLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.textReservationCodeLabel.Location = new System.Drawing.Point(24, 57);
            this.textReservationCodeLabel.Name = "textReservationCodeLabel";
            this.textReservationCodeLabel.Size = new System.Drawing.Size(181, 23);
            this.textReservationCodeLabel.TabIndex = 14;
            this.textReservationCodeLabel.Text = "Код бронирования:";
            this.textReservationCodeLabel.Visible = false;
            // 
            // textRentedBookTitle
            // 
            this.textRentedBookTitle.AutoSize = true;
            this.textRentedBookTitle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRentedBookTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.textRentedBookTitle.Location = new System.Drawing.Point(131, 23);
            this.textRentedBookTitle.Name = "textRentedBookTitle";
            this.textRentedBookTitle.Size = new System.Drawing.Size(135, 23);
            this.textRentedBookTitle.TabIndex = 13;
            this.textRentedBookTitle.Text = "Война и Мир";
            this.textRentedBookTitle.Visible = false;
            // 
            // textNoRentedBook
            // 
            this.textNoRentedBook.AutoSize = true;
            this.textNoRentedBook.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNoRentedBook.ForeColor = System.Drawing.Color.Gray;
            this.textNoRentedBook.Location = new System.Drawing.Point(461, 57);
            this.textNoRentedBook.Name = "textNoRentedBook";
            this.textNoRentedBook.Size = new System.Drawing.Size(311, 23);
            this.textNoRentedBook.TabIndex = 12;
            this.textNoRentedBook.Text = "У вас нет заброниированных книг";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridReservations);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(20, 301);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1212, 219);
            this.panel2.TabIndex = 0;
            // 
            // dataGridReservations
            // 
            this.dataGridReservations.AllowUserToAddRows = false;
            this.dataGridReservations.AllowUserToDeleteRows = false;
            this.dataGridReservations.AllowUserToResizeColumns = false;
            this.dataGridReservations.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.dataGridReservations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridReservations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridReservations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.dataGridReservations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridReservations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(86)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book,
            this.date});
            this.dataGridReservations.EnableHeadersVisualStyles = false;
            this.dataGridReservations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(74)))), ((int)(((byte)(79)))));
            this.dataGridReservations.Location = new System.Drawing.Point(0, 0);
            this.dataGridReservations.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridReservations.Name = "dataGridReservations";
            this.dataGridReservations.ReadOnly = true;
            this.dataGridReservations.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.dataGridReservations.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridReservations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridReservations.Size = new System.Drawing.Size(1210, 217);
            this.dataGridReservations.TabIndex = 13;
            this.dataGridReservations.Visible = false;
            // 
            // book
            // 
            this.book.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.book.FillWeight = 1F;
            this.book.HeaderText = "Книга";
            this.book.Name = "book";
            this.book.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.FillWeight = 0.5F;
            this.date.HeaderText = "Дата бронирования";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(431, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Вы еще ни разу не бронировали книги";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGridRentals);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(20, 580);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1210, 219);
            this.panel3.TabIndex = 13;
            // 
            // dataGridRentals
            // 
            this.dataGridRentals.AllowUserToAddRows = false;
            this.dataGridRentals.AllowUserToDeleteRows = false;
            this.dataGridRentals.AllowUserToResizeColumns = false;
            this.dataGridRentals.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.dataGridRentals.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridRentals.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridRentals.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.dataGridRentals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridRentals.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(86)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRentals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRentals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.rentalDate,
            this.returnDate});
            this.dataGridRentals.EnableHeadersVisualStyles = false;
            this.dataGridRentals.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(74)))), ((int)(((byte)(79)))));
            this.dataGridRentals.Location = new System.Drawing.Point(-4, -1);
            this.dataGridRentals.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridRentals.Name = "dataGridRentals";
            this.dataGridRentals.ReadOnly = true;
            this.dataGridRentals.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.dataGridRentals.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridRentals.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridRentals.Size = new System.Drawing.Size(1210, 217);
            this.dataGridRentals.TabIndex = 13;
            this.dataGridRentals.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 1F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Книга";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // rentalDate
            // 
            this.rentalDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rentalDate.FillWeight = 0.5F;
            this.rentalDate.HeaderText = "Дата начала аенды";
            this.rentalDate.Name = "rentalDate";
            this.rentalDate.ReadOnly = true;
            // 
            // returnDate
            // 
            this.returnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.returnDate.FillWeight = 0.5F;
            this.returnDate.HeaderText = "Дата конца аренды";
            this.returnDate.Name = "returnDate";
            this.returnDate.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(431, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(342, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Вы еще ни разу не арендовали книги";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(23, 557);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1210, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "История аренд";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyBooks
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MyBooks";
            this.Size = new System.Drawing.Size(1252, 851);
            this.Load += new System.EventHandler(this.MyBooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservations)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRentals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textRentedBookLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label textRentedBookTitle;
        private System.Windows.Forms.Label textNoRentedBook;
        private System.Windows.Forms.Label textReservationCode;
        private System.Windows.Forms.Label textReservationCodeLabel;
        private System.Windows.Forms.Label textReservationDate;
        private System.Windows.Forms.Label textReservationDateLabel;
        private System.Windows.Forms.Button btnCancelReservation;
        private System.Windows.Forms.DataGridView dataGridReservations;
        private System.Windows.Forms.DataGridViewTextBoxColumn book;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridRentals;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDate;
    }
}
