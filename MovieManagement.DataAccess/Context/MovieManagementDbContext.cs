using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MovieManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.DataAccess.Context
{
    public class MovieManagementDbContext : DbContext
    {
        public MovieManagementDbContext(DbContextOptions<MovieManagementDbContext> options) : base(options)
        {
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Biography> Biographies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>().HasData(
                    new Actor { Id = 1, FirstName = "Chuck", LastName = "Norris", CreatedBy = "System", ModifiedBy = "System" },
                    new Actor { Id = 2, FirstName = "Jane", LastName = "Doe", CreatedBy = "System", ModifiedBy = "System" },
                    new Actor { Id = 3, FirstName = "Van", LastName = "Helsing", CreatedBy = "System", ModifiedBy = "System" },
                    new Actor { Id = 4, FirstName = "Ana", LastName = "Hathway", CreatedBy = "System", ModifiedBy = "System" },
                    new Actor { Id = 5, FirstName = "Mia", LastName = "Khalifa", CreatedBy = "System", ModifiedBy = "System" }
                );

            modelBuilder.Entity<Movie>().HasData(
                    new Movie { Id = 1, Name = "Wakanda Forever", Description = "Box office we coming", ActorId = 1, CreatedBy = "System", ModifiedBy = "System" },
                    new Movie { Id = 2, Name = "Wakanda Forever", Description = "Box office we coming", ActorId = 2, CreatedBy = "System", ModifiedBy = "System" },
                    new Movie { Id = 3, Name = "Wakanda Forever", Description = "Box office we coming", ActorId = 5, CreatedBy = "System", ModifiedBy = "System" },
                    new Movie { Id = 4, Name = "Spiderman", Description = "Spiderman we coming", ActorId = 3, CreatedBy = "System", ModifiedBy = "System" },
                    new Movie { Id = 5, Name = "Matrix Reloaded", Description = "Matrix Reloaded we coming", ActorId = 4, CreatedBy = "System", ModifiedBy = "System" }
                );

            modelBuilder.Entity<Genre>().HasData(
                    new Genre { Id = 1, Name = "Action", CreatedBy = "System", ModifiedBy = "System" },
                    new Genre { Id = 2, Name = "Horror", CreatedBy = "System", ModifiedBy = "System" },
                    new Genre { Id = 3, Name = "Comedy", CreatedBy = "System", ModifiedBy = "System" }
                );
        }
    }
}
