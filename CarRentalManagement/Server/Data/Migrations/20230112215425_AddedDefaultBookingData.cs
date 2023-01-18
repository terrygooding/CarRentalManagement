using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultBookingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37ccb19d-b273-4634-88eb-c692e0f0f4b8",
                column: "ConcurrencyStamp",
                value: "78395c87-6411-43df-bab8-90f4e1401bcc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44031f2e-904e-414c-adb1-c0a4d391ddab",
                column: "ConcurrencyStamp",
                value: "6ad955dd-17cc-4778-b530-c10c16c629e8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5839dff5-2d5d-499a-b12b-0efae987dd25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "addd9417-45a1-4025-892f-439478a25bd3", "AQAAAAEAACcQAAAAEJ4OCNhs/+fyXh6en0zl5+qdG8nx5HjeWHbg2s0D+6rPmyunWilwfgHKHW1Rev+M9w==", "d478debc-45c2-4cd4-9962-d55ee8722476" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f86bb2cd-776d-4551-8ef4-21cf956f2ea1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "332d1124-9a09-4994-91c2-bcabf6b08d46", "AQAAAAEAACcQAAAAELhnJIS475hUYh3q6eBzrUbpF+aRCiBUp3EP1UqcTuLLyJhCVL1n0IGHO8SqAwH+Gw==", "200a61b1-89b9-4dc8-bf31-7ad0641e702f" });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CreatedBy", "CustomerId", "DateCreated", "DateIn", "DateOut", "DateUpdated", "UpdatedBy", "VehicleId" },
                values: new object[] { 1, "System", 1, new DateTime(2023, 1, 12, 21, 54, 24, 482, DateTimeKind.Local).AddTicks(3873), new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 12, 21, 54, 24, 482, DateTimeKind.Local).AddTicks(3875), "System", 1 });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8388), new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8424) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8427), new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8429) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8431), new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8433) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8435), new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8436) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 21, 54, 24, 482, DateTimeKind.Local).AddTicks(3695), new DateTime(2023, 1, 12, 21, 54, 24, 482, DateTimeKind.Local).AddTicks(3723) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8636), new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8642), new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8644) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8646), new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8649), new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8651) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8720), new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8725), new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8728), new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8732), new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8735), new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8737) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8739), new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8742), new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8746), new DateTime(2023, 1, 12, 21, 54, 24, 468, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 21, 54, 24, 482, DateTimeKind.Local).AddTicks(3791), new DateTime(2023, 1, 12, 21, 54, 24, 482, DateTimeKind.Local).AddTicks(3794) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 21, 54, 24, 482, DateTimeKind.Local).AddTicks(3797), new DateTime(2023, 1, 12, 21, 54, 24, 482, DateTimeKind.Local).AddTicks(3799) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37ccb19d-b273-4634-88eb-c692e0f0f4b8",
                column: "ConcurrencyStamp",
                value: "d7f429b4-33ef-4f4e-8af1-a4186ff304ed");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44031f2e-904e-414c-adb1-c0a4d391ddab",
                column: "ConcurrencyStamp",
                value: "4547ab63-0a71-4804-9747-819cbf3eb39e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5839dff5-2d5d-499a-b12b-0efae987dd25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbab646b-02c3-4d3e-a57f-e8cb0c8da8c7", "AQAAAAEAACcQAAAAEPO+2SbPkwGrCGGtFo7U5z/QmIzrd5GNW0nuK1xlaaB1B1NZ8UWa0N32DyNpzZD88A==", "6e59573a-895b-4dfc-9cc2-915988849142" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f86bb2cd-776d-4551-8ef4-21cf956f2ea1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95dc0371-60db-498f-8459-b2c06b97aaf3", "AQAAAAEAACcQAAAAEFe4qPH8aQPhmyQENP0L1X8yu39M82Wl9TiTaOuJ3K07SHBQILuQBPpcLGIGMHu3Yg==", "f6646925-4afd-4bfb-a388-ce504cbe7879" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(1593), new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(1641), new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(1647), new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(1654), new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 13, 33, 637, DateTimeKind.Local).AddTicks(8955), new DateTime(2023, 1, 12, 20, 13, 33, 637, DateTimeKind.Local).AddTicks(9013) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(2084), new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(2095), new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(2101), new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(2104) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(2107), new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(2394), new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(2404), new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(2408) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(2411), new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(2413) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(2417), new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(2424), new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(2430), new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(2437), new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(2443), new DateTime(2023, 1, 12, 20, 13, 33, 617, DateTimeKind.Local).AddTicks(2446) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 13, 33, 637, DateTimeKind.Local).AddTicks(9154), new DateTime(2023, 1, 12, 20, 13, 33, 637, DateTimeKind.Local).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 13, 33, 637, DateTimeKind.Local).AddTicks(9165), new DateTime(2023, 1, 12, 20, 13, 33, 637, DateTimeKind.Local).AddTicks(9168) });
        }
    }
}
