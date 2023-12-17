using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tourism.Domain.Entities.Booking;
using Tourism.Domain.Entities.Destination;
using Tourism.Domain.Entities.Tours;
using Tourism.Domain.Entities.User;

namespace Tourism.Application.Absreactions
{
    public interface ITourismDbContext
    {
        public DbSet<User>users { get; set; }
        public DbSet<Tour> tours { get; set; }
        public DbSet<Destination> destination { get; set; }
        public DbSet<Booking> bookings { get; set; }

    }
}
