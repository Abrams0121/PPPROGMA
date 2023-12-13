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
        public DbSet<Food> foods { get; set; }
        public DbSet<Food_list> food_Lists { get; set; }
        public DbSet<General_service> general_services { get; set; }
        public DbSet<General_service_list> general_service_list { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<Services_list> services_list { get; set; }
        public DbSet<Sprav_transport_type> sprav_transport_type { get; set;}
        public DbSet<Tour_days> tour_Days { get; set;}
        public DbSet<Tour> tours { get; set;}
        public DbSet<Transport> transports { get; set;}
        public DbSet<Transport_list> transport_list { get; set;}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;User=root;Password=qwerty;Database=tourconstractorbd");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tour>()
                .HasMany(e => e.tour_Days)
                .WithOne(e => e.tour)
                .HasForeignKey(e => e.idTour)
                .HasPrincipalKey(e => e.idTours)
                .IsRequired();

            modelBuilder.Entity<Accommodation>()
                .HasMany(e => e.tour_Days)
                .WithOne(e => e.Accommodation)
                .HasForeignKey(e => e.idAccommodation)
                .HasPrincipalKey(e => e.idAccommodation)
                .IsRequired();

            modelBuilder.Entity<Tour_days>()
                .HasMany(e => e.Food_list)
                .WithOne(e => e.Tour_day)
                .HasForeignKey(e => e.idTour_days)
                .HasPrincipalKey(e => e.idTour_days)
                .IsRequired();

            modelBuilder.Entity<Tour_days>()
                .HasMany(e => e.General_service_list)
                .WithOne(e => e.Tour_day)
                .HasForeignKey(e => e.idTour_days)
                .HasPrincipalKey(e => e.idTour_days)
                .IsRequired();

            modelBuilder.Entity<Tour_days>()
                .HasMany(e => e.Transport_list)
                .WithOne(e => e.Tour_day)
                .HasForeignKey(e => e.idTour_days)
                .HasPrincipalKey(e => e.idTour_days)
                .IsRequired();

            modelBuilder.Entity<Tour_days>()
                .HasMany(e => e.Combinetion_of_tours_list)
                .WithOne(e => e.Tour_days)
                .HasForeignKey(e => e.idTour_days)
                .HasPrincipalKey(e => e.idTour_days)
                .IsRequired();

            modelBuilder.Entity<Tour_days>()
                .HasMany(e => e.Services_list)
                .WithOne(e => e.Tour_day)
                .HasForeignKey(e => e.idTour_days)
                .HasPrincipalKey(e => e.idTour_days)
                .IsRequired();

            modelBuilder.Entity<Combinetion_of_tours>()
                .HasMany(e => e.combinetion_Of_Tours_List)
                .WithOne(e => e.combinetion_Of_Tours)
                .HasForeignKey(e => e.idCombinetion_Of_Tours)
                .HasPrincipalKey(e => e.idcombinetion_of_tours)
                .IsRequired();

            modelBuilder.Entity<General_service>()
                .HasMany(e => e.general_Service_List)
                .WithOne(e => e.general_Service)
                .HasForeignKey(e => e.idGeneral_Service)
                .HasPrincipalKey(e => e.idgeneral_Service)
                .IsRequired();
            modelBuilder.Entity<Service>()
                .HasMany(e => e.Services_list)
                .WithOne(e => e.Service)
                .HasForeignKey(e => e.idServices)
                .HasPrincipalKey(e => e.idServices)
                .IsRequired();
            modelBuilder.Entity<Transport>()
                .HasMany(e => e.transport_List)
                .WithOne(e => e.Transport)
                .HasForeignKey(e => e.idTransport)
                .HasPrincipalKey(e => e.idTransport)
                .IsRequired();
            modelBuilder.Entity<Sprav_transport_type>()
                .HasMany(e => e.transport)
                .WithOne(e => e.Sprav_Transport_type)
                .HasForeignKey(e => e.idSprav_Transport_type)
                .HasPrincipalKey(e => e.idSprav_Transport_type)
                .IsRequired();
        }


    }
}
