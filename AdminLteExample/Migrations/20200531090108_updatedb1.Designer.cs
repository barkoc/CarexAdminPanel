﻿// <auto-generated />
using System;
using AdminLteExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdminLteExample.Migrations
{
    [DbContext(typeof(CarexDBContext))]
    [Migration("20200531090108_updatedb1")]
    partial class updatedb1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdminLteExample.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("AdminLteExample.Models.Cars", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId")
                        .HasMaxLength(50);

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<int>("ModelId")
                        .HasMaxLength(50);

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("AdminLteExample.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("CarPlate")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Email");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<int?>("Phone");

                    b.Property<string>("VehicleType")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("AdminLteExample.Models.CustomerDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId")
                        .IsRequired();

                    b.Property<string>("Operation")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<decimal>("OperationCost");

                    b.Property<DateTime?>("OperationDate")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("CustomerDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
