using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultRoleDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9fd777e6-6443-4eab-815a-723124fbc3ff", "2ae62347-b7ce-469e-896d-ab72e8a69a57", "Administrator", "ADMINISTRATOR" },
                    { "d8f1f71b-da63-439f-a043-88a16eab2065", "0b16122c-ec28-4f80-99e3-47486321eb9d", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(7743), new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(7804) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(7809), new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(7816), new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(7819) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(7822), new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(8342), new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(8353), new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(8356) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(8359), new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(8364), new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(8768), new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(8776), new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(8781), new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(8787), new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(8792), new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(8798), new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(8803), new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(8809), new DateTime(2023, 1, 10, 12, 4, 59, 79, DateTimeKind.Local).AddTicks(8812) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fd777e6-6443-4eab-815a-723124fbc3ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8f1f71b-da63-439f-a043-88a16eab2065");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3282), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3322), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3326), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3329), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3493), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3496) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3499), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3502), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3504) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3506), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3507) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3744), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3748) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3751), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3752) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3754), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3755) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3757), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3759) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3761), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3762) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3764), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3766) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3768), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3769) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3771), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3772) });
        }
    }
}
