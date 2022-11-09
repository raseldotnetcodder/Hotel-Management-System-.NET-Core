using HotelApplication.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Database
{
    public class HotelDBContext : IdentityDbContext<ApplicationUser>
    {
        public HotelDBContext(DbContextOptions<HotelDBContext> options)
            : base(options)
        { }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Complementary> Complementaries { get; set; }
        public DbSet<Suplementary> Suplementaries { get; set; }
        public DbSet<RoomFeature> RoomFeatureRelationships { get; set; }
        public DbSet<ItemImage> ItemImageRelationships { get; set; }
        public DbSet<BookingSuplementary> BookingSuplementaryRelationships { get; set; }
        public DbSet<BookingComplementary> BookingComplementaryRelationships { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Room & Features relationship
            builder.Entity<RoomFeature>()
                .HasKey(x => new { x.RoomId, x.FeatureId });

            builder.Entity<RoomFeature>()
                .HasOne(rf => rf.Room)
                .WithMany(r => r.Features);

            builder.Entity<RoomFeature>()
                .HasOne(f => f.Feature)
                .WithMany(r => r.Rooms);

            // Item & Images relationship
            builder.Entity<ItemImage>()
                .HasKey(x => new { x.ItemId, x.ImageId });

            // Booking & Suplementary relationship
            builder.Entity<BookingSuplementary>()
                .HasKey(x => new { x.BookingId, x.SuplementaryId });

            builder.Entity<BookingSuplementary>()
                .HasOne(rf => rf.Booking)
                .WithMany(r => r.Suplementaries);

            builder.Entity<BookingSuplementary>()
                .HasOne(f => f.Suplementary)
                .WithMany(r => r.Bookings);

            // Booking & Complementary relationship
            builder.Entity<BookingComplementary>()
                .HasKey(x => new { x.BookingId, x.ComplementaryId });

            builder.Entity<BookingComplementary>()
                .HasOne(rf => rf.Booking)
                .WithMany(r => r.Complementaries);

            builder.Entity<BookingComplementary>()
                .HasOne(f => f.Complementary)
                .WithMany(r => r.Bookings);
        }
    }
}
