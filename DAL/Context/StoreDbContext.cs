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
                .Property(x => x.Picture)
                .HasMaxLength(500)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .HasMany(x => x.ProductStores)
                .WithOne(x => x.Product)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Store>()
                .Property(x => x.Name)
                .HasMaxLength(500)
                .IsRequired();

            modelBuilder.Entity<Store>()
                .Property(x => x.Address)
                .HasMaxLength(500)
                .IsRequired();

            modelBuilder.Entity<Store>()
                .Property(x => x.Type)
                .HasMaxLength(500)
                .IsRequired();

            modelBuilder.Entity<Store>()
                .HasMany(x => x.StoreProducts)
                .WithOne(x => x.Store)
                .OnDelete(DeleteBehavior.Cascade);

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