using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Context
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Store> Stores { get; set; }

        public DbSet<StoreProduct> StoreProduct { get; set; }

        // ანალოგიური შუალედურზე


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .Property(x => x.Name)
                .HasMaxLength(500)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .Property(x => x.Manufacturer)
                .HasMaxLength(500)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .Property(x => x.Pricture)
                .HasMaxLength(500)
                .IsRequired();


            modelBuilder.Entity<Store>()
                .Property(x => x.Name)
                .HasMaxLength(500)
                .IsRequired();

            modelBuilder.Entity<Store>()
                .Property(x => x.Adress)
                .HasMaxLength(500)
                .IsRequired();

            modelBuilder.Entity<Store>()
                .Property(x => x.Type)
                .HasMaxLength(500)
                .IsRequired();

            modelBuilder.Entity<StoreProduct>()
                .Property(x => x.BarCode)
                .IsRequired();
            modelBuilder.Entity<StoreProduct>()
                .Property(x => x.Price)
                .IsRequired();

            modelBuilder.Seed();
        }
    }
}