using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YellowBucket1.Models;

namespace YellowBucket1.Data
{
    public class MoviesContext : DbContext
    {
        public MoviesContext (DbContextOptions<MoviesContext> options)
            : base(options)
        {
        }
        

        public DbSet<YellowBucket1.Models.Movies> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movies>().ToTable("Movies");
            modelBuilder.Entity<Inventories>().ToTable("Inventories");
            modelBuilder.Entity<Kiosks>().ToTable("Kiosks");
        }

        public static implicit operator MoviesContext(Movies v)
        {
            throw new NotImplementedException();
        }
    }
}
