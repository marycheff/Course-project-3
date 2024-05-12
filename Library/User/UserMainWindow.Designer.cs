namespace Library
{
    partial class UserMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBooksList = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btnBooksList);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Location = new System.Drawing.Point(-5, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1269, 42);
            this.panel1.TabIndex = 4;
            // 
            // btnBooksList
            // 
            this.btnBooksList.BackColor = System.Drawing.Color.Transparent;
            this.btnBooksList.Location = new System.Drawing.Point(604, 6);
            this.btnBooksList.Name = "btnBooksList";
            this.btnBooksList.Size = new System.Drawing.Size(61, 31);
            this.btnBooksList.TabIndex = 6;
            this.btnBooksList.Text = "Книги";
            this.btnBooksList.UseVisualStyleBackColor = false;
            this.btnBooksList.Click += new System.EventHandler(this.btnBooksList_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.Location = new System.Drawing.Point(17, 6);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(61, 31);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "Профиль";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Location = new System.Drawing.Point(1196, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(61, 31);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Выйти";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-5, 41);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1269, 642);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // UserMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "UserMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.Load += UserMainWindow_Load;

        }

       

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnBooksList;
    }
}