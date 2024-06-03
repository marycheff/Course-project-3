using Library.DB;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Library.User.UserControls
{
    public partial class MyBooks : UserControl
    {
        int currentReservationId;
        public event EventHandler RefreshRequest;
        public MyBooks(int userId)
        {
            InitializeComponent();
            if (DbBook.HasReservedBook(userId))
            {
                textNoRentedBook.Visible = false;

                textRentedBookLabel.Visible = true;
                textRentedBookTitle.Visible = true;

                textReservationCodeLabel.Visible = true;
                textReservationCode.Visible = true;

                textReservationDateLabel.Visible = true;
                textReservationDate.Visible = true;
                btnCancelReservation.Visible = true;

                Reservation currentReservation = DbBook.GetCurrentReservationInfo(userId);
                BookInfo book = DbBook.GetBook(currentReservation.BookId);
                textRentedBookTitle.Text = book.Title;
                textReservationCode.Text = currentReservation.ReservationCode.Insert(2, "-");
                textReservationDate.Text = currentReservation.ReservationDate.ToShortDateString() + " " + currentReservation.ReservationDate.ToShortTimeString();

                currentReservationId = DbBook.GetReservationIdByDate(currentReservation.ReservationDate);
            }
            List<Reservation> reservationsList = DbBook.GetHistoryReservations(userId);

            if (reservationsList.Count > 0)
            {
                dataGridView1.Visible = true;
                foreach (Reservation reservation in reservationsList)
                {
                    object[] rowData = new object[dataGridView1.ColumnCount];
                    rowData[0] = DbBook.GetBookTitleById(reservation.BookId);
                    rowData[1] = reservation.ReservationDate.ToShortDateString() + " " + reservation.ReservationDate.ToShortTimeString();
                    dataGridView1.Rows.Add(rowData);
                }
                dataGridView1.Sort(dataGridView1.Columns[1], System.ComponentModel.ListSortDirection.Descending);

            }




        }


        private void btnCancelReservation_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("Отменить бронирование?", "Отмена бронирования", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (DbBook.DeleteReservation(currentReservationId))
                {
                    RefreshRequest?.Invoke(this, e);
                }
            }
        }

        private void MyBooks_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
