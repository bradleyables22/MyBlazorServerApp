using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlazorServerApp.Data.Migrations
{
    public partial class AddStarWarsCounter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StarWarsAffiliations",
                columns: table => new
                {
                    AffilID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Affiliation = table.Column<string>(type: "TEXT", maxLength: 1, nullable: false),
                    Counter = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StarWarsAffiliations", x => x.AffilID);
                });

            migrationBuilder.UpdateData(
                table: "GuestEntries",
                keyColumn: "GuestEntryID",
                keyValue: 1,
                column: "EntryTimeDate",
                value: new DateTime(2022, 4, 15, 12, 22, 47, 773, DateTimeKind.Local).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "GuestEntries",
                keyColumn: "GuestEntryID",
                keyValue: 2,
                column: "EntryTimeDate",
                value: new DateTime(2022, 4, 15, 12, 22, 47, 773, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "GuestEntries",
                keyColumn: "GuestEntryID",
                keyValue: 3,
                column: "EntryTimeDate",
                value: new DateTime(2022, 4, 15, 12, 22, 47, 773, DateTimeKind.Local).AddTicks(1614));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StarWarsAffiliations");

            migrationBuilder.UpdateData(
                table: "GuestEntries",
                keyColumn: "GuestEntryID",
                keyValue: 1,
                column: "EntryTimeDate",
                value: new DateTime(2022, 4, 3, 19, 18, 44, 914, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "GuestEntries",
                keyColumn: "GuestEntryID",
                keyValue: 2,
                column: "EntryTimeDate",
                value: new DateTime(2022, 4, 3, 19, 18, 44, 914, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "GuestEntries",
                keyColumn: "GuestEntryID",
                keyValue: 3,
                column: "EntryTimeDate",
                value: new DateTime(2022, 4, 3, 19, 18, 44, 914, DateTimeKind.Local).AddTicks(4270));
        }
    }
}
