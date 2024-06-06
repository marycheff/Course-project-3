using Library.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                object[] rowData = new object[dataGridView1.ColumnCount];
                rowData[1] = DbUser.GetUserNameById(rental.UserId);
                rowData[2] = DbBook.GetBookTitleById(rental.BookId);
                rowData[3] = rental.RentalDate.ToString("dd.MM.yyyy HH:mm");
                rowData[0] = rental.Id;
                dataGridView1.Rows.Add(rowData);
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
