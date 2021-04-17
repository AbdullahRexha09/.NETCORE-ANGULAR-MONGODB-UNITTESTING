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
    [Migration("20201225153004_lazyLoading")]
    partial class lazyLoading
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
                            Id = new Guid("38f5a480-7a02-40a5-827c-7589f191d92e"),
                            Latitude = "13.4050",
                            Longitude = "52.5200",
                            Name = "Berlin"
                        },
                        new
                        {
                            Id = new Guid("b9f4bb18-de16-477f-9ce9-cd93c9c1642d"),
                            Latitude = "4.9041",
                            Longitude = "52.3676",
                            Name = "Amsterdam"
                        },
                        new
                        {
                            Id = new Guid("75e03fa7-41f9-4748-a31d-0ce87bb380b1"),
                            Latitude = "14.5058",
                            Longitude = "46.0569",
                            Name = "Ljubljana"
                        },
                        new
                        {
                            Id = new Guid("bdde8166-e8b6-44a2-ac84-3ac5da58497c"),
                            Latitude = "20.4489",
                            Longitude = "44.7866",
                            Name = "Belgrade"
                        },
                        new
                        {
                            Id = new Guid("89a81304-9643-4813-bc13-060cd978c56f"),
                            Latitude = "15.9819",
                            Longitude = "45.8150",
                            Name = "Zagreb"
                        },
                        new
                        {
                            Id = new Guid("8a9be924-2356-4980-a381-e40933bb0ba2"),
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
                            Id = new Guid("13ed15d4-263c-47e8-a31c-11cb095aace1"),
                            Latitude = "12.4964",
                            Longitude = "41.9028",
                            Name = "Rome"
                        },
                        new
                        {
                            Id = new Guid("470e2e5c-2e49-46d9-bb5e-0d33482d34be"),
                            Latitude = "2.3522",
                            Longitude = "48.8566",
                            Name = "Paris"
                        },
                        new
                        {
                            Id = new Guid("ab33302d-e32e-490c-bf5c-4d440a57f30a"),
                            Latitude = "3.7038",
                            Longitude = "40.4168",
                            Name = "Madrid"
                        },
                        new
                        {
                            Id = new Guid("f3b0c5c0-af77-48fe-9307-d7feb7c00c86"),
                            Latitude = "28.9784",
                            Longitude = "41.0082",
                            Name = "Istanbul"
                        },
                        new
                        {
                            Id = new Guid("0eac29f7-7649-4b81-ab72-b2e35c1e9542"),
                            Latitude = "37.6173",
                            Longitude = "55.7558",
                            Name = "Moscow"
                        },
                        new
                        {
                            Id = new Guid("7a553363-c6f1-453c-b78a-9d8c84788597"),
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
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<Guid>("CityId")
                        .HasColumnName("cityid")
                        .HasColumnType("uniqueidentifier")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Location");

                    b.HasData(
                        new
                        {
                            Id = new Guid("84d3b430-8c57-40da-afc4-6315e5c8b9a7"),
                            Address = "Kosove",
                            CityId = new Guid("58ca7a2d-ef9d-47da-9ba2-2a27b76da85c"),
                            Name = "Filan Fisteku"
                        });
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
                        .HasColumnType("nvarchar(max)");

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

                    b.HasKey("Id");

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