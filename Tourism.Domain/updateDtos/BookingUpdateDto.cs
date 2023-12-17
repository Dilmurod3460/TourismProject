using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourism.Domain.updateDtos
{
    public class BookingUpdateDto
    {
        public int BookingId { get; set; }
        public int TourId { get; set; }
        public string BookingDate { get; set; }
        public bool PaymentStatus { get; set; }
    }
}
