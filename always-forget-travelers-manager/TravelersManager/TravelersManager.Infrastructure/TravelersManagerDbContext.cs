using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelersManager.Domain;
using TravelersManager.Domain.JoinEntities;

namespace TravelersManager.Infrastructure
{
    public class TravelersManagerDbContext : DbContext
    {


        public TravelersManagerDbContext(DbContextOptions<TravelersManagerDbContext>? options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Traveler>()
                .HasOne(c => c.Category)
                .WithMany(t => t.Travelers)
                .HasForeignKey(t => t.CategoryId);

            modelBuilder.Entity<Traveler>()
                .HasMany(a => a.Addresses)
                .WithMany(t => t.Travelers)
                .UsingEntity<TravelerAddress>();

            modelBuilder.Entity<Traveler>()
                .HasMany(p => p.PhoneNumbers)
                .WithMany(t => t.Travelers)
                .UsingEntity<TravelerNumbers>();
        }

        public DbSet<Traveler> Travelers { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
