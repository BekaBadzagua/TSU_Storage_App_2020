using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Context
{
    public static class DatabaseInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().HasData(
               new Product()
               {
                   Id = 1,
                   Name = "Guitar",
                   Manufacturer = "Gibson",
                   Picture = "picture_link"
               },
                 new Product()
                 {
                     Id = 2,
                     Name = "Piano",
                     Manufacturer = "Yamaha",
                     Picture = "picture_link"
                 },
                 new Product()
                 {
                     Id = 3,
                     Name = "Strings",
                     Manufacturer = "Dadario",
                     Picture = "picture_link"
                 }
               );

            modelBuilder.Entity<Store>().HasData(
                new Store()
                {
                    Id = 1,
                    Name = "MusicRoom",
                    Address = "New York, #132",
                    Type = "Market"
                },
                new Store()
                {
                    Id = 2,
                    Name = "MusicHouse",
                    Address = "Las Vegas, #9",
                    Type = "Market"
                }
            );


            modelBuilder.Entity<StoreProduct>().HasData(
                new StoreProduct()
                {
                    Id = 1,
                    StoreID = 1,
                    ProductID=1,
                    Price=980,
                    BarCode=12216654
                },
                new StoreProduct()
                {
                    Id = 2,
                    StoreID = 2,
                    ProductID = 1,
                    Price = 1080,
                    BarCode = 12315651
                },
                new StoreProduct()
                {
                    Id = 3,
                    StoreID = 2,
                    ProductID = 2,
                    Price = 1900,
                    BarCode = 12451210
                }
            );

        }
    }
}
