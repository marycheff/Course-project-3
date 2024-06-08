namespace Library.Admin
{
    partial class AddGenre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGenre));
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textGenreName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(142, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "ДОБАВИТЬ ЖАНР";
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.btnAddGenre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(115)))), ((int)(((byte)(128)))));
            this.btnAddGenre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.btnAddGenre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.btnAddGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGenre.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.btnAddGenre.Location = new System.Drawing.Point(135, 309);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(215, 40);
            this.btnAddGenre.TabIndex = 34;
            this.btnAddGenre.Text = "Добавить жанр";
            this.btnAddGenre.UseVisualStyleBackColor = false;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(28, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Название жанра";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textGenreName
            // 
            this.textGenreName.Font = new System.Drawing.Font("Tahoma", 12.75F);
            this.textGenreName.Location = new System.Drawing.Point(32, 166);
            this.textGenreName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textGenreName.Name = "textGenreName";
            this.textGenreName.Size = new System.Drawing.Size(424, 28);
            this.textGenreName.TabIndex = 32;
            // 
            // AddGenre
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textGenreName);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddGenre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Библиотека - Добавить жанр";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textGenreName;
    }
}