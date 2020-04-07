using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class TicketContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"server=*;Database=*;Trusted_Connection=*"); 
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Journey> Journeies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TicketEntityConfiguration());
            modelBuilder.ApplyConfiguration(new JourneyEntityConfiguration());

            
            modelBuilder.Entity<Journey>().HasData(
                new Journey { Id = 1, BusId = 1, Station = "İstanbul", Destination = "İzmir", price = "20 TL", JourneyDate = DateTime.Today },
                new Journey { Id = 2, BusId = 2, Station = "İstanbul", Destination = "Ankara", price = "50 TL", JourneyDate = DateTime.Today.AddDays(1)},
                new Journey { Id = 3, BusId = 1, Station = "İstanbul", Destination = "İzmir", price = "30 TL", JourneyDate = DateTime.Today.AddDays(2)},
                new Journey { Id = 4, BusId = 2, Station = "İzmir", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today.AddDays(3) },
                new Journey { Id = 5, BusId = 1, Station = "İstanbul", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today.AddDays(3) },
                new Journey { Id = 6, BusId = 2, Station = "İstanbul", Destination = "İzmir", price = "30 TL", JourneyDate = DateTime.Today.AddDays(5) },
                new Journey { Id = 7, BusId = 1, Station = "İstanbul", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today.AddDays(6) },
                new Journey { Id = 8, BusId = 2, Station = "İstanbul", Destination = "İzmir", price = "30 TL", JourneyDate = DateTime.Today.AddDays(7) },
                new Journey { Id = 9, BusId = 1, Station = "İzmir", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today.AddDays(8) },
                new Journey { Id = 10, BusId = 1, Station = "İstanbul", Destination = "İzmir", price = "30 TL", JourneyDate = DateTime.Today.AddDays(8) },
                new Journey { Id = 11, BusId = 2, Station = "İstanbul", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today.AddDays(1) },
                new Journey { Id = 12, BusId = 2, Station = "İstanbul", Destination = "İzmir", price = "30 TL", JourneyDate = DateTime.Today.AddDays(2) },
                new Journey { Id = 13, BusId = 1, Station = "İzmir", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today.AddDays(3) },
                new Journey { Id = 14, BusId = 2, Station = "İstanbul", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today.AddDays(4) },
                new Journey { Id = 15, BusId = 1, Station = "İzmir", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today.AddDays(5) },
                new Journey { Id = 16, BusId = 1, Station = "İstanbul", Destination = "İzmir", price = "30 TL", JourneyDate = DateTime.Today.AddDays(6) },
                new Journey { Id = 17, BusId = 2, Station = "İstanbul", Destination = "İzmir", price = "20 TL", JourneyDate = DateTime.Today.AddDays(7) },
                new Journey { Id = 18, BusId = 2, Station = "İstanbul", Destination = "İzmir", price = "20 TL", JourneyDate = DateTime.Today.AddDays(8) },
                new Journey { Id = 19, BusId = 1, Station = "İzmir", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today.AddDays(10) },
                new Journey { Id = 20, BusId = 2, Station = "İstanbul", Destination = "İzmir", price = "30 TL", JourneyDate = DateTime.Today.AddDays(10) },
                new Journey { Id = 21, BusId = 1, Station = "İzmir", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today.AddDays(11) },
                new Journey { Id = 22, BusId = 1, Station = "İstanbul", Destination = "İzmir", price = "20 TL", JourneyDate = DateTime.Today.AddDays(11) },
                new Journey { Id = 23, BusId = 2, Station = "İstanbul", Destination = "İzmir", price = "20 TL", JourneyDate = DateTime.Today.AddDays(12) },
                new Journey { Id = 24, BusId = 2, Station = "İstanbul", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today.AddDays(12) },
                new Journey { Id = 25, BusId = 1, Station = "İzmir", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today.AddDays(12) },
                new Journey { Id = 26, BusId = 2, Station = "İstanbul", Destination = "İzmir", price = "20 TL", JourneyDate = DateTime.Today.AddDays(13) },
                new Journey { Id = 27, BusId = 2, Station = "İstanbul", Destination = "İzmir", price = "20 TL", JourneyDate = DateTime.Today.AddDays(14) },
                new Journey { Id = 28, BusId = 1, Station = "İstanbul", Destination = "İzmir", price = "20 TL", JourneyDate = DateTime.Today.AddDays(15) },
                new Journey { Id = 29, BusId = 2, Station = "İstanbul", Destination = "İzmir", price = "20 TL", JourneyDate = DateTime.Today.AddDays(16) },
                new Journey { Id = 30, BusId = 1, Station = "İstanbul", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today.AddDays(17) },
                new Journey { Id = 31, BusId = 1, Station = "İstanbul", Destination = "İzmir", price = "20 TL", JourneyDate = DateTime.Today.AddDays(18) },
                new Journey { Id = 32, BusId = 2, Station = "İzmir", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today.AddDays(18) },
                new Journey { Id = 33, BusId = 1, Station = "İstanbul", Destination = "İzmir", price = "30 TL", JourneyDate = DateTime.Today.AddDays(19) },
                new Journey { Id = 34, BusId = 1, Station = "İstanbul", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today.AddDays(20) },
                new Journey { Id = 35, BusId = 2, Station = "İstanbul", Destination = "İzmir", price = "20 TL", JourneyDate = DateTime.Today.AddDays(20) },
                new Journey { Id = 36, BusId = 1, Station = "İstanbul", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today },
                new Journey { Id = 37, BusId = 2, Station = "İstanbul", Destination = "İzmir", price = "20 TL", JourneyDate = DateTime.Today.AddDays(1) },
                new Journey { Id = 38, BusId = 2, Station = "İzmir", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today.AddDays(1) },
                new Journey { Id = 39, BusId = 1, Station = "İstanbul", Destination = "İzmir", price = "20 TL", JourneyDate = DateTime.Today },
                new Journey { Id = 40, BusId = 2, Station = "İstanbul", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today },
                new Journey { Id = 41, BusId = 1, Station = "İstanbul", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today.AddDays(1) },
                new Journey { Id = 42, BusId = 1, Station = "İstanbul", Destination = "İzmir", price = "20 TL", JourneyDate = DateTime.Today.AddDays(2) },
                new Journey { Id = 43, BusId = 2, Station = "İzmir", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today.AddDays(3) },
                new Journey { Id = 44, BusId = 1, Station = "İstanbul", Destination = "İzmir", price = "30 TL", JourneyDate = DateTime.Today.AddDays(4) },
                new Journey { Id = 45, BusId = 1, Station = "İstanbul", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today.AddDays(1) },
                new Journey { Id = 46, BusId = 2, Station = "İzmir", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today },
                new Journey { Id = 47, BusId = 1, Station = "İzmir", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today.AddDays(1) },
                new Journey { Id = 48, BusId = 1, Station = "İstanbul", Destination = "İzmir", price = "20 TL", JourneyDate = DateTime.Today.AddDays(4) },
                new Journey { Id = 49, BusId = 2, Station = "İstanbul", Destination = "İzmir", price = "20 TL", JourneyDate = DateTime.Today.AddDays(6) },
                new Journey { Id = 50, BusId = 1, Station = "İzmir", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today.AddDays(7) },
                new Journey { Id = 51, BusId = 1, Station = "İstanbul", Destination = "İzmir", price = "20 TL", JourneyDate = DateTime.Today.AddDays(3) },
                new Journey { Id = 52, BusId = 2, Station = "İzmir", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today.AddDays(18) },
                new Journey { Id = 53, BusId = 1, Station = "İstanbul", Destination = "İzmir", price = "30 TL", JourneyDate = DateTime.Today.AddDays(19) },
                new Journey { Id = 54, BusId = 1, Station = "İstanbul", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today.AddDays(20) },
                new Journey { Id = 55, BusId = 2, Station = "İstanbul", Destination = "İzmir", price = "20 TL", JourneyDate = DateTime.Today.AddDays(20) },
                new Journey { Id = 56, BusId = 1, Station = "İstanbul", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today },
                new Journey { Id = 57, BusId = 2, Station = "İstanbul", Destination = "İzmir", price = "20 TL", JourneyDate = DateTime.Today.AddDays(7) },
                new Journey { Id = 58, BusId = 2, Station = "İzmir", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today.AddDays(1) },
                new Journey { Id = 59, BusId = 1, Station = "İstanbul", Destination = "İzmir", price = "20 TL", JourneyDate = DateTime.Today },
                new Journey { Id = 60, BusId = 2, Station = "İstanbul", Destination = "İzmir", price = "20 TL", JourneyDate = DateTime.Today },
                new Journey { Id = 61, BusId = 1, Station = "İstanbul", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today.AddDays(1) },
                new Journey { Id = 62, BusId = 1, Station = "İstanbul", Destination = "İzmir", price = "20 TL", JourneyDate = DateTime.Today.AddDays(2) },
                new Journey { Id = 63, BusId = 2, Station = "İzmir", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today.AddDays(5) },
                new Journey { Id = 64, BusId = 1, Station = "İstanbul", Destination = "İzmir", price = "30 TL", JourneyDate = DateTime.Today.AddDays(4) },
                new Journey { Id = 65, BusId = 1, Station = "İstanbul", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today.AddDays(1) },
                new Journey { Id = 66, BusId = 2, Station = "İzmir", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today },
                new Journey { Id = 67, BusId = 1, Station = "İstanbul", Destination = "Ankara", price = "20 TL", JourneyDate = DateTime.Today.AddDays(1) }
            );
            modelBuilder.Entity<Bus>().HasData(
                new Bus { Id = 1, BusName = "Suit", Capacity = 40 },
                new Bus { Id = 2, BusName = "Class", Capacity = 40 }
            );

            modelBuilder.Entity<Ticket>().HasData(
                new Ticket { Id = 1, JourneyId = 1, UserId = 1 },
                new Ticket { Id = 2, JourneyId = 2, UserId = 2 },
                new Ticket { Id = 3, JourneyId = 3, UserId = 1 },
                new Ticket { Id = 4, JourneyId = 4, UserId = 2 },
                new Ticket { Id = 5, JourneyId = 5, UserId = 1 },
                new Ticket { Id = 6, JourneyId = 6, UserId = 2 },
                new Ticket { Id = 7, JourneyId = 7, UserId = 1 }
            );

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Email = "ornek@ornek.com", PasswordHash = BitConverter.GetBytes(54564), PasswordSalt = BitConverter.GetBytes(14528), Status = false },
                new User { Id = 2, Email = "mail@ornek.com", PasswordHash = BitConverter.GetBytes(54564), PasswordSalt = BitConverter.GetBytes(14528), Status = false }
            );

            
            
    }
}
}
