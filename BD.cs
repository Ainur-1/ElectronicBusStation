using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ElectronicBusStation
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class BusRoutes
    {
        public int RoutId { get; set; }
        public int NumberOfSeats { get; set; }
        public int FreeSeats { get; set; }

    }
    public class Timetable
    {
        public int BusId { get; set; }
        public DateTime DepartureTime { get; set; }
        public int TicketPrice { get; set; }
        public int NuberOfTicket { get; set; }

    }

    public class ApplicationContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<BusRoutes> busRoutes { get; set; }
        public DbSet<Timetable> timetable { get; set; }

        public ApplicationContext()
        {
            //Database.EnsureDeleted();   // удаляем бд со старой схемой
            Database.EnsureCreated();   // создаем бд с новой схемой
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Timetable>().HasKey(u => u.BusId);
            modelBuilder.Entity<BusRoutes>().HasKey(u => u.RoutId);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Busesappdb;Trusted_Connection=True;");
        }
    }
}
