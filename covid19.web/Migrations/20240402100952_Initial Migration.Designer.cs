﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using covid19.web.Data;

#nullable disable

namespace covid19.web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240402100952_Initial Migration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("covid19.web.Models.Entities.CoronaֹVaccine", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Corona_Manufacturer1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Corona_Manufacturer2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Corona_Manufacturer3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Corona_Manufacturer4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Corona_Vaccine1")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Corona_Vaccine2")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Corona_Vaccine3")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Corona_Vaccine4")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("CoronaֹVaccine");
                });

            modelBuilder.Entity("covid19.web.Models.Entities.Patient", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Covid_Positive_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Covid_Recovery_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date_Of_Birth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mobile_Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telphone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("full_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });
#pragma warning restore 612, 618
        }
    }
}
