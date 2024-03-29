﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ResortBooking.Infrastructure.Data;

#nullable disable

namespace ResortBooking.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240217134814_AddDetails2")]
    partial class AddDetails2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.1.24081.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ResortBooking.Domain.Entities.Resort", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Resorts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "It is a beautiful resort with good and nice free space.",
                            ImageUrl = "https://placehold.co/600x400",
                            Name = "Royal Resort",
                            Occupancy = 4,
                            Price = 200.0,
                            Sqft = 550
                        },
                        new
                        {
                            Id = 2,
                            Description = "It is a beautiful, premium resort with good and nice free space.",
                            ImageUrl = "https://placehold.co/600x400",
                            Name = "Premium Resort",
                            Occupancy = 6,
                            Price = 500.0,
                            Sqft = 750
                        },
                        new
                        {
                            Id = 3,
                            Description = "It is a beautiful and super as a good budget friendly resort with good and nice free space.",
                            ImageUrl = "https://placehold.co/600x400",
                            Name = "Super Resort",
                            Occupancy = 5,
                            Price = 450.0,
                            Sqft = 650
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
