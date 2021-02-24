using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YellowBucket1.Models;

namespace YellowBucket1.Data {
    public class MoviesContext : DbContext {
        public MoviesContext (DbContextOptions<MoviesContext> options) : base(options) { }

        public DbSet<YellowBucket1.Models.Movies> Movies { get; set; }
        public DbSet<YellowBucket1.Models.CustomerReviews> CustomerReviews { get; set; }
        public DbSet<YellowBucket1.Models.Customers> Customers { get; set; }
        public DbSet<YellowBucket1.Models.Genres> Genres { get; set; }
        public DbSet<YellowBucket1.Models.Inventories> Inventories { get; set; }
        public DbSet<YellowBucket1.Models.Kiosks> Kiosks { get; set; }
        public DbSet<YellowBucket1.Models.MoviesGenres> MoviesGenres { get; set; }
        public DbSet<YellowBucket1.Models.Rentals> Rentals { get; set; }
        public DbSet<YellowBucket1.Models.Wishlists> Wishlists { get; set; }
        public DbSet<YellowBucket1.Models.Passwords> Passwords { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Movies>().ToTable("Movies");
            modelBuilder.Entity<Inventories>().ToTable("Inventories");
            modelBuilder.Entity<Kiosks>().ToTable("Kiosks");
            
            modelBuilder.Entity<Customers>().ToTable("Customers");
            modelBuilder.Entity<CustomerReviews>().ToTable("CustomerReviews");
            modelBuilder.Entity<Genres>().ToTable("Genres");
            
            modelBuilder.Entity<Rentals>().ToTable("Rentals");
            modelBuilder.Entity<Wishlists>().ToTable("Wishlists");
            modelBuilder.Entity<MoviesGenres>().ToTable("MoviesGenres");

            modelBuilder.Entity<Passwords>().ToTable("Passwords");

            modelBuilder.Entity<MoviesGenres>()
                .HasOne(p => p.Movies)
                .WithMany(b => b.MoviesGenres)
                .HasForeignKey(p => p.MoviesID)
                .HasPrincipalKey(b => b.ID);
            modelBuilder.Entity<MoviesGenres>()
                .HasOne(d => d.Genres)
                .WithMany(e => e.MoviesGenres)
                .HasForeignKey(f => f.GenresID)
                .HasPrincipalKey(b => b.ID);
            modelBuilder.Entity<MoviesGenres>()
                .HasKey(c => new { c.MoviesID, c.GenresID });

            modelBuilder.Entity<Passwords>() .HasKey(c => new {
                c.Username
            });
        }

        public static implicit operator MoviesContext(Movies v) {
                throw new NotImplementedException();
        }
    }
}
