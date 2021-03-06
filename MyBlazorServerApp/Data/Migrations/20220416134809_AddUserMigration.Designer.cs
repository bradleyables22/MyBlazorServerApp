// <auto-generated />
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
    [Migration("20220416134809_AddUserMigration")]
    partial class AddUserMigration
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
                            EntryTimeDate = new DateTime(2022, 4, 16, 9, 48, 9, 112, DateTimeKind.Local).AddTicks(9555),
                            GuestInput = "This is entry number 1",
                            GuestName = "John Doe 1"
                        },
                        new
                        {
                            GuestEntryID = 2,
                            EntryTimeDate = new DateTime(2022, 4, 16, 9, 48, 9, 112, DateTimeKind.Local).AddTicks(9588),
                            GuestInput = "This is entry number 2",
                            GuestName = "John Doe 2"
                        },
                        new
                        {
                            GuestEntryID = 3,
                            EntryTimeDate = new DateTime(2022, 4, 16, 9, 48, 9, 112, DateTimeKind.Local).AddTicks(9591),
                            GuestInput = "This is entry number 3",
                            GuestName = "John Doe 3"
                        });
                });

            modelBuilder.Entity("MyBlazorServerApp.Data.Models.StarWarsAffiliation", b =>
                {
                    b.Property<int>("AffilID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Affiliation")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EDT")
                        .HasColumnType("TEXT");

                    b.HasKey("AffilID");

                    b.ToTable("StarWarsAffiliations");
                });

            modelBuilder.Entity("MyBlazorServerApp.Data.Models.UserInfo", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.HasKey("UserID");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            Role = "Admin",
                            UserName = "TheLordCommander",
                            UserPassword = "Loser9009!"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
