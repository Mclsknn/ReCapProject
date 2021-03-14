using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{  
    //Context : Db tabloları ile proje classlarını bağlamak
    public class RentCarDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-RQR1VLD;Database=RentCar;Trusted_Connection=true");
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        //Custom mapping entity olan car ı veri tabanındaki arac tablosuna bağlama
        //public DbSet<Car> Arac { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{   //fluent mapping 
        //    //modelBuilder.HasDefaultSchema("admin");
        //    modelBuilder.Entity<Car>().ToTable("Cars");
        //    modelBuilder.Entity<Car>().Property(p => p.CarId).HasColumnName("CarID");
        //    modelBuilder.Entity<Car>().Property(p => p.CarName).HasColumnName("AracName");
        //}
    }
}
