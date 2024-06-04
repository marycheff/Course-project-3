using Library.DB;
using System;
using System.Windows.Forms;

namespace Library.Admin.UserControls
{
    public partial class GiveBook : UserControl
    {
        public GiveBook()
        {
            InitializeComponent();
        }

        private void btnCheckReservation_Click(object sender, EventArgs e)
        {
            Reservation reservation = DbBook.GetReservationByCode(textReservationCode.Text.Trim().Replace("-", ""));
            if (reservation == null)
            {
                MessageBox.Show("Введен неверный код выдачи книги", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                panel1.Visible = true;
                textRentedBookTitle.Text = DbBook.GetBookTitleById(reservation.BookId);
                textBookId.Text = reservation.BookId.ToString();
                textUserName.Text = DbUser.GetUserNameById(reservation.UserId);
                textUserId.Text = reservation.UserId.ToString();
                textReservationDate.Text = reservation.ReservationDate.ToShortDateString() + " " + reservation.ReservationDate.ToShortTimeString();



            }

        }
        private void textReservationCode_Click(object sender, EventArgs e)
        {
            textReservationCode.SelectionStart = 0;
        }
    }
}
