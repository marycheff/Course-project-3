namespace Library.Admin
{
    partial class AddAuthor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAuthor));
            this.label1 = new System.Windows.Forms.Label();
            this.textAuthorName = new System.Windows.Forms.TextBox();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(93, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Имя автора";
            // 
            // textAuthorName
            // 
            this.textAuthorName.Font = new System.Drawing.Font("Tahoma", 12.75F);
            this.textAuthorName.Location = new System.Drawing.Point(96, 188);
            this.textAuthorName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textAuthorName.Name = "textAuthorName";
            this.textAuthorName.Size = new System.Drawing.Size(424, 28);
            this.textAuthorName.TabIndex = 16;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(105)))), ((int)(((byte)(115)))));
            this.btnAddAuthor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(115)))), ((int)(((byte)(128)))));
            this.btnAddAuthor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.btnAddAuthor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(90)))), ((int)(((byte)(99)))));
            this.btnAddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAuthor.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.btnAddAuthor.Location = new System.Drawing.Point(199, 337);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(215, 40);
            this.btnAddAuthor.TabIndex = 30;
            this.btnAddAuthor.Text = "Добавить автора";
            this.btnAddAuthor.UseVisualStyleBackColor = false;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(196, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "ДОБАВИТЬ АВТОРА";
            // 
            // AddAuthor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(612, 458);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textAuthorName);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAuthor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Библиотека - Добавить автора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAuthorName;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Label label4;
    }
}