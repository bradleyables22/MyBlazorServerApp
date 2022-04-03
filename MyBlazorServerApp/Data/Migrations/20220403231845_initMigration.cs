using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlazorServerApp.Data.Migrations
{
    public partial class initMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GuestEntries",
                columns: table => new
                {
                    GuestEntryID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GuestName = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    EntryTimeDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    GuestInput = table.Column<string>(type: "TEXT", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestEntries", x => x.GuestEntryID);
                });

            migrationBuilder.InsertData(
                table: "GuestEntries",
                columns: new[] { "GuestEntryID", "EntryTimeDate", "GuestInput", "GuestName" },
                values: new object[] { 1, new DateTime(2022, 4, 3, 19, 18, 44, 914, DateTimeKind.Local).AddTicks(4225), "This is entry number 1", "John Doe 1" });

            migrationBuilder.InsertData(
                table: "GuestEntries",
                columns: new[] { "GuestEntryID", "EntryTimeDate", "GuestInput", "GuestName" },
                values: new object[] { 2, new DateTime(2022, 4, 3, 19, 18, 44, 914, DateTimeKind.Local).AddTicks(4267), "This is entry number 2", "John Doe 2" });

            migrationBuilder.InsertData(
                table: "GuestEntries",
                columns: new[] { "GuestEntryID", "EntryTimeDate", "GuestInput", "GuestName" },
                values: new object[] { 3, new DateTime(2022, 4, 3, 19, 18, 44, 914, DateTimeKind.Local).AddTicks(4270), "This is entry number 3", "John Doe 3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GuestEntries");
        }
    }
}
