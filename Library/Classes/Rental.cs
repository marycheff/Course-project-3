﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Rental
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ReservationId { get; set; }
        public int BookId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
