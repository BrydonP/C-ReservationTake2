using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RestaurantReservation.Models {
    public class ConnectionDB:DbContext {

        public ConnectionDB(DbContextOptions<ConnectionDB>options):base(options) {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<User> Users { get; set; }
       

    }
}
