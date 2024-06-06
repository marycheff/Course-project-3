using Library.DB;
using System;
using System.Windows.Forms;

namespace Library.Admin.UserControls
{
    public partial class GiveBook : UserControl
    {
        Reservation reservation;
        public event EventHandler RefreshRequest;
        public GiveBook()
        {
            InitializeComponent();
            textReservationCode.Focus();
        }

        private void btnCheckReservation_Click(object sender, EventArgs e)
        {
            reservation = DbBook.GetReservationByCode(textReservationCode.Text.Trim().Replace("-", ""));
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

        private void btnGiveBook_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Выдать книгу?", "Выдача книги", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (DbBook.GiveBook(reservation))
                {
                    MessageBox.Show("Книга успешно выдана", "Выдача книги", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshRequest?.Invoke(this, e);
                }
            }
            
        }

        private void textUserName_Click(object sender, EventArgs e)
        {

        }
    }
}
