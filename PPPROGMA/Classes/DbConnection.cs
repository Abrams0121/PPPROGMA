using Microsoft.EntityFrameworkCore;
using PPPROGMA.Classes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA
{
    internal class DbConnection : DbContext
    {
        public DbSet<Accommodation> accommodations { get; set; }
        public DbSet<Autorisation> Autorisation { get; set; }
        public DbSet<Combinetion_of_tours> combinetion_Of_Tours { get; set; }
        public DbSet<Combinetion_of_tours_list> combinetion_Of_Tours_Lists { get; set; }
        public DbSet<Days_list> days_Lists { get; set; }
        public DbSet<Food> foods { get; set; }
        public DbSet<Food_list> food_Lists { get; set; }
        public DbSet<General_service> general_services { get; set; }
        public DbSet<General_service_list> general_service_list { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<Services_list> services_list { get; set; }
        public DbSet<Sprav_transport_type> sprav_transport_type { get; set;}
        public DbSet<Tour_days> tour_Days { get; set;}
        public DbSet<Tours> tours { get; set;}
        public DbSet<Transport> transports { get; set;}
        public DbSet<Transport_list> transport_list { get; set;}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;User=root;Password=qwerty;Database=tourconstractorbd");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tours>()
                .HasMany(e => e.days_Lists)
                .WithOne(e => e.tour)
                .IsRequired();

            modelBuilder.Entity<Days_list>()
                .HasMany(e => e.tour_Days)
                .WithOne(e => e.Days_list)
                .IsRequired();


            modelBuilder.Entity<Accommodation>()
                .HasMany(e => e.tour_Days)
                .WithOne(e => e.Accommodation)
                .IsRequired();

            modelBuilder.Entity<Tour_days>()
                .HasMany(e => e.Food_list)
                .WithOne(e => e.Tour_day)
                .IsRequired();
            modelBuilder.Entity<Tour_days>()
                .HasMany(e => e.General_service_list)
                .WithOne(e => e.Tour_day)
                .IsRequired();
            modelBuilder.Entity<Tour_days>()
                .HasMany(e => e.Transport_list)
                .WithOne(e => e.Tour_day)
                .IsRequired();
            modelBuilder.Entity<Tour_days>()
                .HasMany(e => e.Combinetion_of_tours_list)
                .WithOne(e => e.Tour_days)
                .IsRequired();
            modelBuilder.Entity<Tour_days>()
                .HasMany(e => e.Services_list)
                .WithOne(e => e.Tour_day)
                .IsRequired();

            modelBuilder.Entity<Combinetion_of_tours>()
                .HasMany(e => e.combinetion_Of_Tours_List)
                .WithOne(e => e.combinetion_Of_Tours)
                .IsRequired();
            modelBuilder.Entity<General_service>()
                .HasMany(e => e.general_Service_List)
                .WithOne(e => e.general_Service)
                .IsRequired();
            modelBuilder.Entity<Service>()
                .HasMany(e => e.Services_list)
                .WithOne(e => e.Services)
                .IsRequired();
            modelBuilder.Entity<Transport>()
                .HasMany(e => e.transport_List)
                .WithOne(e => e.Transport)
                .IsRequired();
            modelBuilder.Entity<Sprav_transport_type>()
                .HasMany(e => e.transport)
                .WithOne(e => e.Sprav_Transport_type)
                .IsRequired();
        }


    }
}
