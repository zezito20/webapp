﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using burguerwebapp.Data;

namespace burguerwebapp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200415072156_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("burguerwebapp.Models.Burguer", b =>
                {
                    b.Property<int>("BurguerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsBestSeller");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("BurguerId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Burguers");

                    b.HasData(
                        new
                        {
                            BurguerId = 1,
                            CategoryId = 1,
                            Description = "Veggie Burger with sweet potatoes",
                            ImageUrl = "https://localhost:44375/images/chickenburger.jpg",
                            IsBestSeller = true,
                            Name = "Chicken Burguer",
                            Price = 12.95m
                        },
                        new
                        {
                            BurguerId = 2,
                            CategoryId = 2,
                            Description = "Traditional Beef Burger",
                            ImageUrl = "https://localhost:44375/images/BaconBurgers.jpg",
                            IsBestSeller = false,
                            Name = "Burguer",
                            Price = 13.95m
                        },
                        new
                        {
                            BurguerId = 3,
                            CategoryId = 2,
                            Description = "Double Taste",
                            ImageUrl = "https://localhost:44375/images/dbeef.jpg",
                            IsBestSeller = false,
                            Name = "Double Beef Burguer",
                            Price = 14.95m
                        },
                        new
                        {
                            BurguerId = 4,
                            CategoryId = 1,
                            Description = "Veggie and SpiII-cy!",
                            ImageUrl = "https://localhost:44375/images/flamebur.jpg",
                            IsBestSeller = false,
                            Name = "waygyou Burguer",
                            Price = 14.95m
                        });
                });

            modelBuilder.Entity("burguerwebapp.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.Property<string>("Description");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Vegetarian",
                            Description = "Meat Free"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Beef",
                            Description = "for meat lovers"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Chicken",
                            Description = "tastefull chicken burguers"
                        });
                });

            modelBuilder.Entity("burguerwebapp.Models.Burguer", b =>
                {
                    b.HasOne("burguerwebapp.Models.Category", "Category")
                        .WithMany("Burguers")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
