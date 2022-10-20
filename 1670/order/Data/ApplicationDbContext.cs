using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using order.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace order.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Laptop>().HasData(
                new Laptop { Id = 1, Name = "Dell", Price = 1000, Image = "https://uscom.vn/wp-content/uploads/2022/06/mba20222.jpg", Quantity = 10},
                   new Laptop { Id = 2, Name = "Macbook", Price = 1000, Image = "https://uscom.vn/wp-content/uploads/2022/06/mba20222.jpg", Quantity = 20 },
                       new Laptop { Id = 3, Name = "Asus", Price = 1000, Image = "https://uscom.vn/wp-content/uploads/2022/06/mba20222.jpg", Quantity = 25 },
                           new Laptop { Id = 4, Name = "HP", Price = 1000, Image = "https://uscom.vn/wp-content/uploads/2022/06/mba20222.jpg", Quantity = 30 }
                );
        }
    }
}
