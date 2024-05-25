namespace Library.Admin.UserControls
{
    partial class AddBook
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboAvailable = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboGenre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboAuthor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(617, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 27);
            this.button1.TabIndex = 56;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(617, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 27);
            this.button2.TabIndex = 55;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(115)))), ((int)(((byte)(128)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(478, 630);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 41);
            this.btnSave.TabIndex = 54;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddImage
            // 
            this.btnAddImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.btnAddImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(115)))), ((int)(((byte)(128)))));
            this.btnAddImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.btnAddImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.btnAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImage.Location = new System.Drawing.Point(815, 400);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(75, 23);
            this.btnAddImage.TabIndex = 53;
            this.btnAddImage.Text = "Добавить";
            this.btnAddImage.UseVisualStyleBackColor = false;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BackgroundImage = global::Library.Properties.Resources.DEFAULT_ADD;
            this.panel1.Location = new System.Drawing.Point(690, 94);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 300);
            this.panel1.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(182, 320);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 51;
            this.label5.Text = "Доступна";
            // 
            // comboAvailable
            // 
            this.comboAvailable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAvailable.FormattingEnabled = true;
            this.comboAvailable.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboAvailable.Location = new System.Drawing.Point(180, 346);
            this.comboAvailable.Name = "comboAvailable";
            this.comboAvailable.Size = new System.Drawing.Size(428, 27);
            this.comboAvailable.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(180, 404);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 23);
            this.label4.TabIndex = 49;
            this.label4.Text = "Описание";
            // 
            // textDescription
            // 
            this.textDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDescription.Location = new System.Drawing.Point(180, 430);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(428, 96);
            this.textDescription.TabIndex = 48;
            this.textDescription.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(180, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 47;
            this.label3.Text = "Жанр";
            // 
            // comboGenre
            // 
            this.comboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGenre.FormattingEnabled = true;
            this.comboGenre.Location = new System.Drawing.Point(180, 262);
            this.comboGenre.Name = "comboGenre";
            this.comboGenre.Size = new System.Drawing.Size(428, 27);
            this.comboGenre.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(180, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 45;
            this.label2.Text = "Автор";
            // 
            // comboAuthor
            // 
            this.comboAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAuthor.FormattingEnabled = true;
            this.comboAuthor.Location = new System.Drawing.Point(180, 178);
            this.comboAuthor.Name = "comboAuthor";
            this.comboAuthor.Size = new System.Drawing.Size(428, 27);
            this.comboAuthor.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(180, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 43;
            this.label1.Text = "Название";
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(180, 94);
            this.textTitle.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(428, 27);
            this.textTitle.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(686, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 57;
            this.label6.Text = "Обложка";
            // 
            // AddBook
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboAvailable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboGenre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboAuthor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTitle);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AddBook";
            this.Size = new System.Drawing.Size(1070, 684);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboAvailable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox textDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboGenre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.Label label6;
    }
}
