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
    [Migration("20201225122604_LocationAdded")]
    partial class LocationAdded
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
                            Id = new Guid("7ddf494c-3663-4722-9212-0954eb88c0fc"),
                            Latitude = "13.4050",
                            Longitude = "52.5200",
                            Name = "Berlin"
                        },
                        new
                        {
                            Id = new Guid("0f9768f1-b4de-400c-8893-1e3179ff2f88"),
                            Latitude = "4.9041",
                            Longitude = "52.3676",
                            Name = "Amsterdam"
                        },
                        new
                        {
                            Id = new Guid("b8c8bf3c-67e2-44ca-a244-5e2f62f701dd"),
                            Latitude = "14.5058",
                            Longitude = "46.0569",
                            Name = "Ljubljana"
                        },
                        new
                        {
                            Id = new Guid("30cfd739-0740-4e5b-94a7-d20a0b295b9f"),
                            Latitude = "20.4489",
                            Longitude = "44.7866",
                            Name = "Belgrade"
                        },
                        new
                        {
                            Id = new Guid("0d6bd147-b508-4279-a683-3f8b76ccbc17"),
                            Latitude = "15.9819",
                            Longitude = "45.8150",
                            Name = "Zagreb"
                        },
                        new
                        {
                            Id = new Guid("d055ef84-13e1-4beb-8a11-ae6da2de93b7"),
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
                            Id = new Guid("50c9fcb1-1cca-49bd-9e68-f47dfa177956"),
                            Latitude = "12.4964",
                            Longitude = "41.9028",
                            Name = "Rome"
                        },
                        new
                        {
                            Id = new Guid("e77ac9f6-5dc7-4ae3-82b1-6174881ba904"),
                            Latitude = "2.3522",
                            Longitude = "48.8566",
                            Name = "Paris"
                        },
                        new
                        {
                            Id = new Guid("50cc0d1e-e2a1-4e5a-b714-25f71f7dd838"),
                            Latitude = "3.7038",
                            Longitude = "40.4168",
                            Name = "Madrid"
                        },
                        new
                        {
                            Id = new Guid("a09c4620-f8f6-46dc-8b4c-3b20ff6e2044"),
                            Latitude = "28.9784",
                            Longitude = "41.0082",
                            Name = "Istanbul"
                        },
                        new
                        {
                            Id = new Guid("4db77daf-6e78-4981-ade0-36c11440b987"),
                            Latitude = "37.6173",
                            Longitude = "55.7558",
                            Name = "Moscow"
                        },
                        new
                        {
                            Id = new Guid("89ee4f8c-c988-4267-aada-ecfd509271a7"),
                            Latitude = "18.0686",
                            Longitude = "59.3293",
                            Name = "Stockholm"
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
#pragma warning restore 612, 618
        }
    }
}