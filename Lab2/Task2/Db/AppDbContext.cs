using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task2.Db.Entities;

namespace Task2.Db
{
    public class AppDbContext : DbContext
    {
        public DbSet<SomeEntity> SomeEntities { get; set; }
        public DbSet<SomeImageEntity> SomeImageEntities { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Lab2T2;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SomeEntity>().HasData(
                new SomeEntity { Id = 1, Name = "TestEntity", Description = "This is test entity", Status = EntityStatus.Inactive },
                new SomeEntity { Id = 2, Name = "TestEntity2", Description = "Yeah, this is also test entity", Status = EntityStatus.Other },
                new SomeEntity { Id = 3, Name = "CoolTestEntity", Description = "Test entity but cpol", Status = EntityStatus.Inactive },
                new SomeEntity { Id = 4, Name = "CoolerTestEntity", Description = "Even cooler then previos one", Status = EntityStatus.Inactive },
                new SomeEntity { Id = 5, Name = "Bob", Description = "Bob used to active lifestyle", Status = EntityStatus.Active }
            );

            modelBuilder.Entity<SomeImageEntity>().HasData(
                new SomeImageEntity { Id = 6, Name = "test1", Description = "This is test entity", Status = EntityStatus.Inactive, ImageUrl = "someUrl1" },
                new SomeImageEntity { Id = 7, Name = "test4", Description = "Yeah, this is also test entity", Status = EntityStatus.Other, ImageUrl = "someUrl" },
                new SomeImageEntity { Id = 8, Name = "test3", Description = "test", Status = EntityStatus.Inactive, ImageUrl = "someUrl" },
                new SomeImageEntity { Id = 9, Name = "test", Description = "test", Status = EntityStatus.Inactive, ImageUrl = "someUrl" },
                new SomeImageEntity { Id = 10, Name = "Bob", Description = "Good old bob", Status = EntityStatus.Active, ImageUrl = "someUrl1" }
            );
        }
    }
}
