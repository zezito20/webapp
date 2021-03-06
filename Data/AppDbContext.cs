﻿using burguerwebapp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace burguerwebapp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Burguer> Burguers { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //fill with categories

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Vegetarian", Description = "Meat Free" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Beef", Description = "for meat lovers" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Chicken", Description = "tastefull chicken burguers" });


            //fill up db with burguers

            modelBuilder.Entity<Burguer>().HasData(new Burguer

            {
                BurguerId = 1,
                Name = "Chicken Burguer",
                Description = "Veggie Burger with sweet potatoes",
                Price = 12.95M,
                ImageUrl = "https://strwebappdemoburguer.blob.core.windows.net/ctnwebappdemoburguer/chickenburger.jpg",
                CategoryId = 1,
                IsBestSeller = true,
            });

            modelBuilder.Entity<Burguer>().HasData(new Burguer

            {
                BurguerId = 2,
                Name = "Burguer",
                Description = "Traditional Beef Burger",
                Price = 13.95M,
                ImageUrl = "https://strwebappdemoburguer.blob.core.windows.net/ctnwebappdemoburguer/Impossible-Burger-600-x-400.jpg",
                CategoryId = 2,
                IsBestSeller = false,
            }); 

            modelBuilder.Entity<Burguer>().HasData(new Burguer

            {
                BurguerId = 3,
                Name = "Double Beef Burguer",
                Description = "Double Taste",
                Price = 14.95M,
                ImageUrl = "https://strwebappdemoburguer.blob.core.windows.net/ctnwebappdemoburguer/dbeef.jpg",
                CategoryId = 2,
                IsBestSeller = false,
            });

            modelBuilder.Entity<Burguer>().HasData(new Burguer

            {
                BurguerId = 4,
                Name = "waygyou Burguer",
                Description = "Veggie and SpiII-cy!",
                Price = 14.95M,
                ImageUrl = "https://strwebappdemoburguer.blob.core.windows.net/ctnwebappdemoburguer/BaconBurgers-infogourmet.jpg",
                CategoryId = 1,
                IsBestSeller = false,
            });

        }

    }
}
