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
            
            FillCurrentReservation(userId);
            FillReservationsHistory(userId);
            FillRentalsHistory(userId);


        }

        private void FillCurrentReservation(int userId)
        {
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
                textReservationDate.Text = currentReservation.ReservationDate.ToString("dd.MM.yyyy HH:mm");

                currentReservationId = DbBook.GetReservationIdByDate(currentReservation.ReservationDate);
            }
        }
        private void FillReservationsHistory(int userId)
        {
            List<Reservation> reservationsList = DbBook.GetReservationsHistory(userId);
            if (reservationsList.Count > 0)
            {
                dataGridReservations.Visible = true;
                foreach (Reservation reservation in reservationsList)
                {
                    object[] rowData = new object[dataGridReservations.ColumnCount];
                    rowData[0] = DbBook.GetBookTitleById(reservation.BookId);
                    rowData[1] = reservation.ReservationDate.ToString("dd.MM.yyyy HH:mm");
                    dataGridReservations.Rows.Add(rowData);
                }
                dataGridReservations.Sort(dataGridReservations.Columns[1], System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void FillRentalsHistory(int userId)
        {
            List<Rental> rentalList = DbBook.GetRentalsHistory(userId);
            if (rentalList.Count > 0)
            {
                dataGridRentals.Visible = true;
                foreach (Rental rental in rentalList)
                {
                    object[] rowData = new object[dataGridRentals.ColumnCount];
                    rowData[0] = DbBook.GetBookTitleById(rental.BookId);
                    rowData[1] = rental.RentalDate.ToString("dd.MM.yyyy HH:mm");
                    rowData[2] = rental.ReturnDate.ToString("dd.MM.yyyy HH:mm");
                    dataGridRentals.Rows.Add(rowData);

                }
                //dataGridView1.Sort(dataGridView1.Columns[2], System.ComponentModel.ListSortDirection.Descending);

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

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
