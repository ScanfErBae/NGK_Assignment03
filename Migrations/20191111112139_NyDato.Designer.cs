﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NGK_Assignment_3.Data;

namespace NGK_Assignment_3.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20191111112139_NyDato")]
    partial class NyDato
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NGK_Assignment_3.Model.Measurement", b =>
                {
                    b.Property<int>("MeasurementID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("Date");

                    b.Property<int>("Humidity");

                    b.Property<int>("MeasurementLocationID");

                    b.Property<double>("Pressure");

                    b.Property<double>("Temp");

                    b.HasKey("MeasurementID");

                    b.HasIndex("MeasurementLocationID")
                        .IsUnique();

                    b.ToTable("Measurements");
                });

            modelBuilder.Entity("NGK_Assignment_3.Model.MeasurementLocation", b =>
                {
                    b.Property<int>("MeasurementLocationID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("Name");

                    b.HasKey("MeasurementLocationID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("NGK_Assignment_3.Model.Measurement", b =>
                {
                    b.HasOne("NGK_Assignment_3.Model.MeasurementLocation", "Location")
                        .WithOne("Measurement")
                        .HasForeignKey("NGK_Assignment_3.Model.Measurement", "MeasurementLocationID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}