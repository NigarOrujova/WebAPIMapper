using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIApp2.Data.Configurations;
using WebAPIApp2.Data.Entities;

namespace WebAPIApp2.Data.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.Entity<Product>().HasData(
                new Product { Id=1,Name="pro1",Price=12.99,Count=2},
                new Product { Id=2,Name="pro2",Price=24.99,Count=5},
                new Product { Id=3,Name="pro3",Price=15.99,Count=3}
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
