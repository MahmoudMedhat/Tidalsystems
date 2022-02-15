
using Microsoft.EntityFrameworkCore;

using System;
using Task.Domain.Model;

namespace Task.Infra.Repositories
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options)
           : base(options)
        {
        }

        public DbSet<Locations> locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Locations>().HasData(
        new Locations
        {
            Id=1,
            Latitude = 30.033333,
            Longitude = 31.233334,
            CityName = "Cairo",
        }
    );


        }
    }

}
