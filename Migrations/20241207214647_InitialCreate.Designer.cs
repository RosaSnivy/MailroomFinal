﻿// <auto-generated />
using System;
using Mailroom.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MailroomFinal.Migrations
{
    [DbContext(typeof(MailroomDbContext))]
    [Migration("20241207214647_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("Mailroom.Models.History", b =>
                {
                    b.Property<int>("HistoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PackageID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ResidentID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("timeReceived")
                        .HasColumnType("TEXT");

                    b.HasKey("HistoryID");

                    b.HasIndex("PackageID");

                    b.HasIndex("ResidentID");

                    b.ToTable("Historys");
                });

            modelBuilder.Entity("Mailroom.Models.Package", b =>
                {
                    b.Property<int>("PackageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ResidentsResidentID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("postalService")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PackageID");

                    b.HasIndex("ResidentsResidentID");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("Mailroom.Models.Resident", b =>
                {
                    b.Property<int>("ResidentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("unitNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("ResidentID");

                    b.ToTable("Residents");
                });

            modelBuilder.Entity("Mailroom.Models.StaffLogin", b =>
                {
                    b.Property<int>("StaffLoginID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StaffLoginID");

                    b.ToTable("StaffLogins");
                });

            modelBuilder.Entity("Mailroom.Models.UnknownPackage", b =>
                {
                    b.Property<int>("UnknownPackageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("postalService")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UnknownPackageID");

                    b.ToTable("UnknownPackages");
                });

            modelBuilder.Entity("Mailroom.Models.History", b =>
                {
                    b.HasOne("Mailroom.Models.Package", "Package")
                        .WithMany()
                        .HasForeignKey("PackageID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mailroom.Models.Resident", "Resident")
                        .WithMany()
                        .HasForeignKey("ResidentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Package");

                    b.Navigation("Resident");
                });

            modelBuilder.Entity("Mailroom.Models.Package", b =>
                {
                    b.HasOne("Mailroom.Models.Resident", "Residents")
                        .WithMany()
                        .HasForeignKey("ResidentsResidentID");

                    b.Navigation("Residents");
                });
#pragma warning restore 612, 618
        }
    }
}