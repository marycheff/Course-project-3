
using System;

namespace Library
{
    internal class Reservation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public string ReservationCode { get; set; }
        public DateTime ReservationDate { get; set; }
        public bool Rented { get; set; }
    }
}
