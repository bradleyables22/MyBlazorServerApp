using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlazorServerApp.Data.Migrations
{
    public partial class AddUserMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    UserPassword = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Role = table.Column<string>(type: "TEXT", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserID);
                });

            migrationBuilder.UpdateData(
                table: "GuestEntries",
                keyColumn: "GuestEntryID",
                keyValue: 1,
                column: "EntryTimeDate",
                value: new DateTime(2022, 4, 16, 9, 48, 9, 112, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "GuestEntries",
                keyColumn: "GuestEntryID",
                keyValue: 2,
                column: "EntryTimeDate",
                value: new DateTime(2022, 4, 16, 9, 48, 9, 112, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "GuestEntries",
                keyColumn: "GuestEntryID",
                keyValue: 3,
                column: "EntryTimeDate",
                value: new DateTime(2022, 4, 16, 9, 48, 9, 112, DateTimeKind.Local).AddTicks(9591));

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "UserID", "Role", "UserName", "UserPassword" },
                values: new object[] { 1, "Admin", "TheLordCommander", "Loser9009!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");

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
    }
}
