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
    [Migration("20200531121628_modelss")]
    partial class modelss
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

            modelBuilder.Entity("AdminLteExample.Models.CarBrands", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId");

                    b.Property<string>("BrandName")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("CarBrands");
                });

            modelBuilder.Entity("AdminLteExample.Models.CarModels", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId");

                    b.Property<string>("Category")
                        .HasMaxLength(150);

                    b.Property<int>("ModelId");

                    b.Property<string>("ModelName")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("CarModels");
                });

            modelBuilder.Entity("AdminLteExample.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("CarPlate")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<int?>("Phone");

                    b.Property<string>("VehicleType")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("AdminLteExample.Models.CustomerDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<string>("Operation")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<decimal>("OperationCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("OperationDate");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerDetails");
                });

            modelBuilder.Entity("AdminLteExample.Models.CustomerDetails", b =>
                {
                    b.HasOne("AdminLteExample.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
