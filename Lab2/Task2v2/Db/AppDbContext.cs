using Microsoft.EntityFrameworkCore;
using Task2v2.Db.Entities;

namespace Task2v2.Db
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
                new SomeEntity { Id = Guid.NewGuid(), Name = "TestEntity", Description = "This is test entity", Status = EntityStatus.Inactive },
                new SomeEntity { Id = Guid.NewGuid(), Name = "TestEntity2", Description = "Yeah, this is also test entity", Status = EntityStatus.Other },
                new SomeEntity { Id = Guid.NewGuid(), Name = "CoolTestEntity", Description = "Test entity but cpol", Status = EntityStatus.Inactive },
                new SomeEntity { Id = Guid.NewGuid(), Name = "CoolerTestEntity", Description = "Even cooler then previos one", Status = EntityStatus.Inactive },
                new SomeEntity { Id = Guid.NewGuid(), Name = "Bob", Description = "Bob used to active lifestyle", Status = EntityStatus.Active }
            );
        }
    }
}
