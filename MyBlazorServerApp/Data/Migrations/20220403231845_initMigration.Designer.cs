﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyBlazorServerApp.Data;

#nullable disable

namespace MyBlazorServerApp.Data.Migrations
{
    [DbContext(typeof(PortfolioDbContext))]
    [Migration("20220403231845_initMigration")]
    partial class initMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("MyBlazorServerApp.Data.Models.GuestEntry", b =>
                {
                    b.Property<int>("GuestEntryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EntryTimeDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("GuestInput")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT");

                    b.Property<string>("GuestName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.HasKey("GuestEntryID");

                    b.ToTable("GuestEntries");

                    b.HasData(
                        new
                        {
                            GuestEntryID = 1,
                            EntryTimeDate = new DateTime(2022, 4, 3, 19, 18, 44, 914, DateTimeKind.Local).AddTicks(4225),
                            GuestInput = "This is entry number 1",
                            GuestName = "John Doe 1"
                        },
                        new
                        {
                            GuestEntryID = 2,
                            EntryTimeDate = new DateTime(2022, 4, 3, 19, 18, 44, 914, DateTimeKind.Local).AddTicks(4267),
                            GuestInput = "This is entry number 2",
                            GuestName = "John Doe 2"
                        },
                        new
                        {
                            GuestEntryID = 3,
                            EntryTimeDate = new DateTime(2022, 4, 3, 19, 18, 44, 914, DateTimeKind.Local).AddTicks(4270),
                            GuestInput = "This is entry number 3",
                            GuestName = "John Doe 3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
