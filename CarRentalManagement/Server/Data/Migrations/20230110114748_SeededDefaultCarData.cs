using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3282), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3319), "Black", "System" },
                    { 2, "System", new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3322), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3324), "Red", "System" },
                    { 3, "System", new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3326), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3327), "White", "System" },
                    { 4, "System", new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3329), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3330), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3493), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3496), "Porshe", "System" },
                    { 2, "System", new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3499), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3500), "Lamborghini", "System" },
                    { 3, "System", new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3502), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3504), "Ferrari", "System" },
                    { 4, "System", new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3506), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3507), "Maserati", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3744), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3748), "Cayenne", "System" },
                    { 2, "System", new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3751), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3752), "Maca", "System" },
                    { 3, "System", new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3754), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3755), "Aventador", "System" },
                    { 4, "System", new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3757), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3759), "Huracan", "System" },
                    { 5, "System", new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3761), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3762), "Portofino", "System" },
                    { 6, "System", new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3764), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3766), "Roma", "System" },
                    { 7, "System", new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3768), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3769), "Ghibli", "System" },
                    { 8, "System", new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3771), new DateTime(2023, 1, 10, 11, 47, 47, 914, DateTimeKind.Local).AddTicks(3772), "Levante", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
