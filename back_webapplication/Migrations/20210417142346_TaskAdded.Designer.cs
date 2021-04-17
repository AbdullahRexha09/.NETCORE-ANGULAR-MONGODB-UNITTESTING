﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapplication.Models;

namespace webapplication.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210417142346_TaskAdded")]
    partial class TaskAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("webapplication.Models.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Latitude")
                        .HasColumnName("latitude")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Longitude")
                        .HasColumnName("longitude")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("City");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e5153a00-2c6e-4153-90f4-932042bc5279"),
                            Latitude = "13.4050",
                            Longitude = "52.5200",
                            Name = "Berlin"
                        },
                        new
                        {
                            Id = new Guid("a86f4621-9fda-4d22-a1bd-52e44d111017"),
                            Latitude = "4.9041",
                            Longitude = "52.3676",
                            Name = "Amsterdam"
                        },
                        new
                        {
                            Id = new Guid("26db13b3-1d1b-45d9-95fb-a89c7afd2e9a"),
                            Latitude = "14.5058",
                            Longitude = "46.0569",
                            Name = "Ljubljana"
                        },
                        new
                        {
                            Id = new Guid("e2654275-0eb4-4c9d-a90e-086ae4e57723"),
                            Latitude = "20.4489",
                            Longitude = "44.7866",
                            Name = "Belgrade"
                        },
                        new
                        {
                            Id = new Guid("e56d9e05-ced1-4b74-a7e3-d622f0c67c50"),
                            Latitude = "15.9819",
                            Longitude = "45.8150",
                            Name = "Zagreb"
                        },
                        new
                        {
                            Id = new Guid("d18b3827-0af6-43a4-9a03-66c67b3d29a7"),
                            Latitude = "18.4131",
                            Longitude = "43.8563",
                            Name = "Sarajevo"
                        },
                        new
                        {
                            Id = new Guid("58ca7a2d-ef9d-47da-9ba2-2a27b76da85c"),
                            Latitude = "21.1655",
                            Longitude = "42.6629",
                            Name = "Prishtina"
                        },
                        new
                        {
                            Id = new Guid("a5adeca9-dfdc-4c4c-abd6-199e902f0793"),
                            Latitude = "12.4964",
                            Longitude = "41.9028",
                            Name = "Rome"
                        },
                        new
                        {
                            Id = new Guid("81604445-a7f6-4995-add9-26ef57d672b9"),
                            Latitude = "2.3522",
                            Longitude = "48.8566",
                            Name = "Paris"
                        },
                        new
                        {
                            Id = new Guid("9aacc937-22d9-4215-9b76-e03d2c5903f8"),
                            Latitude = "3.7038",
                            Longitude = "40.4168",
                            Name = "Madrid"
                        },
                        new
                        {
                            Id = new Guid("2cb86e63-6be6-4cc8-89c9-856725333e76"),
                            Latitude = "28.9784",
                            Longitude = "41.0082",
                            Name = "Istanbul"
                        },
                        new
                        {
                            Id = new Guid("af7f85b3-a517-4266-ba83-69f6277693fb"),
                            Latitude = "37.6173",
                            Longitude = "55.7558",
                            Name = "Moscow"
                        },
                        new
                        {
                            Id = new Guid("8f445045-9be0-4029-88fb-1126cbec9c9a"),
                            Latitude = "18.0686",
                            Longitude = "59.3293",
                            Name = "Stockholm"
                        });
                });

            modelBuilder.Entity("webapplication.Models.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnName("address")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<Guid>("CityId")
                        .HasColumnName("cityid")
                        .HasColumnType("uniqueidentifier")
                        .HasMaxLength(60);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Location");

                    b.HasData(
                        new
                        {
                            Id = new Guid("307123e9-adf4-45ed-b330-3942b9b10aad"),
                            Address = "Kosove",
                            CityId = new Guid("58ca7a2d-ef9d-47da-9ba2-2a27b76da85c"),
                            Name = "Filan Fisteku"
                        });
                });

            modelBuilder.Entity("webapplication.Models.PMLTask", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Completed")
                        .HasColumnName("completed")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnName("duedate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("Parent")
                        .HasColumnName("parent")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnName("title")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("PMLTask");
                });

            modelBuilder.Entity("webapplication.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RefreshTokenExpiryTime")
                        .HasColumnName("refreshtokenexpirytime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Role")
                        .HasColumnName("role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnName("status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("User");
                });

            modelBuilder.Entity("webapplication.Models.Location", b =>
                {
                    b.HasOne("webapplication.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}