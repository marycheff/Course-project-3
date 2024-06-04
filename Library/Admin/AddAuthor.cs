using System;
using System.Windows.Forms;

namespace Library.Admin
{
    public partial class AddAuthor : Form
    {
        public AddAuthor()
        {
            InitializeComponent();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            string authorName = textAuthorName.Text.Trim();

            if (Validation.ValidAuthorName(authorName))
            {
                MessageBox.Show("YES");
            }
        }
    }
}
