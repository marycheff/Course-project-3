using Library.DB;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Library.Admin.UserControls
{
    public partial class TakeBook : UserControl
    {
        public TakeBook()
        {
            InitializeComponent();
            LoadRentalsData();
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 11, FontStyle.Bold);
        }

        private void LoadRentalsData()
        {
            List<Rental> allRentals = DbBook.GetAllRentals();
            dataGridView1.Rows.Clear();
            foreach (Rental rental in allRentals)
            {
                int rentalId = rental.Id;
                string userName = DbUser.GetUserNameById(rental.UserId);
                string bookTitle = DbBook.GetBookTitleById(rental.BookId);
                string rentalDate = rental.RentalDate.ToString("dd.MM.yyyy HH:mm");

                dataGridView1.Rows.Add(rentalId, userName, bookTitle, rentalDate);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["btnTakeBook"].Index)
            {
                int rentalId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                DialogResult result = MessageBox.Show($"Принять книгу от пользователя?\n{dataGridView1.Rows[e.RowIndex].Cells["Username"].Value}", "Подтверждение принятия книги", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (DbBook.TakeBook(rentalId))
                    {
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Книга принята", "Принятие книги", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
