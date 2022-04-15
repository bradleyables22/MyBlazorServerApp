using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlazorServerApp.Data.Migrations
{
    public partial class UpdateToStarWars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Counter",
                table: "StarWarsAffiliations");

            migrationBuilder.AddColumn<DateTime>(
                name: "EDT",
                table: "StarWarsAffiliations",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GuestEntries",
                keyColumn: "GuestEntryID",
                keyValue: 1,
                column: "EntryTimeDate",
                value: new DateTime(2022, 4, 15, 14, 13, 44, 688, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "GuestEntries",
                keyColumn: "GuestEntryID",
                keyValue: 2,
                column: "EntryTimeDate",
                value: new DateTime(2022, 4, 15, 14, 13, 44, 688, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "GuestEntries",
                keyColumn: "GuestEntryID",
                keyValue: 3,
                column: "EntryTimeDate",
                value: new DateTime(2022, 4, 15, 14, 13, 44, 688, DateTimeKind.Local).AddTicks(7829));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EDT",
                table: "StarWarsAffiliations");

            migrationBuilder.AddColumn<int>(
                name: "Counter",
                table: "StarWarsAffiliations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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
    }
}
