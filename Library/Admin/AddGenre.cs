using System;
using System.Windows.Forms;

namespace Library.Admin
{
    public partial class AddGenre : Form
    {
        public AddGenre()
        {
            InitializeComponent();
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            string genreName = textGenreName.Text.Trim();

            if (Validation.ValidGenreName(genreName))
            {
                MessageBox.Show("YES");
            }
        }
    }
}
