namespace Library.Admin.UserControls
{
    partial class CheckAuthorsAndGenres
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridAuthors = new System.Windows.Forms.DataGridView();
            this.authorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.authorDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridGenres = new System.Windows.Forms.DataGridView();
            this.genreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.genreDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGenres)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAuthors
            // 
            this.dataGridAuthors.AllowDrop = true;
            this.dataGridAuthors.AllowUserToAddRows = false;
            this.dataGridAuthors.AllowUserToDeleteRows = false;
            this.dataGridAuthors.AllowUserToResizeColumns = false;
            this.dataGridAuthors.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.dataGridAuthors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridAuthors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAuthors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridAuthors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.dataGridAuthors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAuthors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAuthors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAuthors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorId,
            this.authorName,
            this.authorEdit,
            this.authorDelete});
            this.dataGridAuthors.EnableHeadersVisualStyles = false;
            this.dataGridAuthors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.dataGridAuthors.Location = new System.Drawing.Point(0, 0);
            this.dataGridAuthors.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridAuthors.Name = "dataGridAuthors";
            this.dataGridAuthors.ReadOnly = true;
            this.dataGridAuthors.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(82)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.dataGridAuthors.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridAuthors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridAuthors.Size = new System.Drawing.Size(535, 684);
            this.dataGridAuthors.TabIndex = 0;
            this.dataGridAuthors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAuthors_CellContentClick);
            // 
            // authorId
            // 
            this.authorId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.authorId.FillWeight = 0.2F;
            this.authorId.HeaderText = "Id";
            this.authorId.Name = "authorId";
            this.authorId.ReadOnly = true;
            // 
            // authorName
            // 
            this.authorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.authorName.FillWeight = 1F;
            this.authorName.HeaderText = "Имя автора";
            this.authorName.Name = "authorName";
            this.authorName.ReadOnly = true;
            // 
            // authorEdit
            // 
            this.authorEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.authorEdit.FillWeight = 0.3F;
            this.authorEdit.HeaderText = "";
            this.authorEdit.Name = "authorEdit";
            this.authorEdit.ReadOnly = true;
            this.authorEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.authorEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.authorEdit.Text = "Правка";
            this.authorEdit.UseColumnTextForButtonValue = true;
            // 
            // authorDelete
            // 
            this.authorDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.authorDelete.FillWeight = 0.3F;
            this.authorDelete.HeaderText = "";
            this.authorDelete.Name = "authorDelete";
            this.authorDelete.ReadOnly = true;
            this.authorDelete.Text = "Удалить";
            this.authorDelete.UseColumnTextForButtonValue = true;
            // 
            // dataGridGenres
            // 
            this.dataGridGenres.AllowUserToAddRows = false;
            this.dataGridGenres.AllowUserToDeleteRows = false;
            this.dataGridGenres.AllowUserToResizeColumns = false;
            this.dataGridGenres.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.dataGridGenres.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridGenres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridGenres.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridGenres.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.dataGridGenres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridGenres.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridGenres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGenres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.genreId,
            this.genreName,
            this.genreEdit,
            this.genreDelete});
            this.dataGridGenres.EnableHeadersVisualStyles = false;
            this.dataGridGenres.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.dataGridGenres.Location = new System.Drawing.Point(535, 0);
            this.dataGridGenres.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridGenres.Name = "dataGridGenres";
            this.dataGridGenres.ReadOnly = true;
            this.dataGridGenres.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(82)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.dataGridGenres.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridGenres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridGenres.Size = new System.Drawing.Size(535, 684);
            this.dataGridGenres.TabIndex = 1;
            this.dataGridGenres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridGenres_CellContentClick);
            // 
            // genreId
            // 
            this.genreId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.genreId.FillWeight = 0.2F;
            this.genreId.HeaderText = "Id";
            this.genreId.Name = "genreId";
            this.genreId.ReadOnly = true;
            // 
            // genreName
            // 
            this.genreName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.genreName.FillWeight = 1F;
            this.genreName.HeaderText = "Название жанра";
            this.genreName.Name = "genreName";
            this.genreName.ReadOnly = true;
            // 
            // genreEdit
            // 
            this.genreEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.genreEdit.FillWeight = 0.3F;
            this.genreEdit.HeaderText = "";
            this.genreEdit.Name = "genreEdit";
            this.genreEdit.ReadOnly = true;
            this.genreEdit.Text = "Правка";
            this.genreEdit.UseColumnTextForButtonValue = true;
            // 
            // genreDelete
            // 
            this.genreDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.genreDelete.FillWeight = 0.3F;
            this.genreDelete.HeaderText = "";
            this.genreDelete.Name = "genreDelete";
            this.genreDelete.ReadOnly = true;
            this.genreDelete.Text = "Удалить";
            this.genreDelete.UseColumnTextForButtonValue = true;
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.btnAddGenre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(115)))), ((int)(((byte)(128)))));
            this.btnAddGenre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.btnAddGenre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.btnAddGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGenre.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGenre.Location = new System.Drawing.Point(882, 0);
            this.btnAddGenre.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(170, 20);
            this.btnAddGenre.TabIndex = 26;
            this.btnAddGenre.Text = "Добавить жанр";
            this.btnAddGenre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddGenre.UseVisualStyleBackColor = false;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.btnAddAuthor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(115)))), ((int)(((byte)(128)))));
            this.btnAddAuthor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.btnAddAuthor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.btnAddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAuthor.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAuthor.Location = new System.Drawing.Point(347, 0);
            this.btnAddAuthor.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(170, 20);
            this.btnAddAuthor.TabIndex = 27;
            this.btnAddAuthor.Text = "Добавить автора";
            this.btnAddAuthor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddAuthor.UseVisualStyleBackColor = false;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // CheckAuthors
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.dataGridGenres);
            this.Controls.Add(this.dataGridAuthors);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CheckAuthors";
            this.Size = new System.Drawing.Size(1070, 684);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGenres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAuthors;
        private System.Windows.Forms.DataGridView dataGridGenres;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorName;
        private System.Windows.Forms.DataGridViewButtonColumn authorEdit;
        private System.Windows.Forms.DataGridViewButtonColumn authorDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreName;
        private System.Windows.Forms.DataGridViewButtonColumn genreEdit;
        private System.Windows.Forms.DataGridViewButtonColumn genreDelete;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Button btnAddAuthor;
    }
}
