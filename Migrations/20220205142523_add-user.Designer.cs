﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using internship_api.Models;

#nullable disable

namespace internship_api.Migrations
{
    [DbContext(typeof(IntDbContext))]
    [Migration("20220205142523_add-user")]
    partial class adduser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("internship_api.Models.product.Product", b =>
                {
                    b.Property<string>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("longtext");

                    b.Property<string>("ProductName")
                        .HasColumnType("longtext");

                    b.HasKey("ProductId");

                    b.ToTable("IntProducts");
                });

            modelBuilder.Entity("internship_api.Models.user.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("IntUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
