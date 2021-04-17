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
    [Migration("20201225150525_LocationAdded2")]
    partial class LocationAdded2
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
                            Id = new Guid("f41a0aa8-f4f6-4864-9688-9d608fb51fbb"),
                            Latitude = "13.4050",
                            Longitude = "52.5200",
                            Name = "Berlin"
                        },
                        new
                        {
                            Id = new Guid("fe2baf00-c52a-4294-a1fd-dc6c6b2d486e"),
                            Latitude = "4.9041",
                            Longitude = "52.3676",
                            Name = "Amsterdam"
                        },
                        new
                        {
                            Id = new Guid("1972dc17-d28c-4e94-b2e0-bc285a82c1af"),
                            Latitude = "14.5058",
                            Longitude = "46.0569",
                            Name = "Ljubljana"
                        },
                        new
                        {
                            Id = new Guid("b11bb54b-4298-41e8-95d6-1b4dbb6cbd8c"),
                            Latitude = "20.4489",
                            Longitude = "44.7866",
                            Name = "Belgrade"
                        },
                        new
                        {
                            Id = new Guid("68bc7b6a-dfdb-41b8-85b9-4c712c7fd767"),
                            Latitude = "15.9819",
                            Longitude = "45.8150",
                            Name = "Zagreb"
                        },
                        new
                        {
                            Id = new Guid("dcd792cb-1d7f-425d-90e8-92fc800c735b"),
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
                            Id = new Guid("050682a4-32d4-451a-aa9f-2a037c6e0368"),
                            Latitude = "12.4964",
                            Longitude = "41.9028",
                            Name = "Rome"
                        },
                        new
                        {
                            Id = new Guid("61fee9ca-fb43-4faa-bdab-ccfe330a2e61"),
                            Latitude = "2.3522",
                            Longitude = "48.8566",
                            Name = "Paris"
                        },
                        new
                        {
                            Id = new Guid("ecd3a7aa-2cb5-4476-96a0-b30c833734e4"),
                            Latitude = "3.7038",
                            Longitude = "40.4168",
                            Name = "Madrid"
                        },
                        new
                        {
                            Id = new Guid("b2e69673-7427-427e-a32a-49f9efae0a08"),
                            Latitude = "28.9784",
                            Longitude = "41.0082",
                            Name = "Istanbul"
                        },
                        new
                        {
                            Id = new Guid("5b0ed914-54bc-4675-a75a-3c25fdff6138"),
                            Latitude = "37.6173",
                            Longitude = "55.7558",
                            Name = "Moscow"
                        },
                        new
                        {
                            Id = new Guid("aa92c52d-1a64-48f4-a9b5-84b5ee0133a8"),
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
                            Id = new Guid("52aba146-8690-41c7-81c4-ff63672819b3"),
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
