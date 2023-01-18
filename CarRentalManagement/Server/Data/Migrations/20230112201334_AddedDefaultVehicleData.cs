using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultVehicleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "ColourId", "CreatedBy", "DateCreated", "DateUpdated", "LicencePlateNumber", "ManufacturerId", "ModelId", "RentalRate", "UpdatedBy", "Vin", "Year" },
                values: new object[,]
                {
                    { 1, 2, "System", new DateTime(2023, 1, 12, 20, 13, 33, 637, DateTimeKind.Local).AddTicks(9154), new DateTime(2023, 1, 12, 20, 13, 33, 637, DateTimeKind.Local).AddTicks(9159), "ABC-123", 2, 3, 750.0, "System", "ABC-123", 2020 },
                    { 2, 1, "System", new DateTime(2023, 1, 12, 20, 13, 33, 637, DateTimeKind.Local).AddTicks(9165), new DateTime(2023, 1, 12, 20, 13, 33, 637, DateTimeKind.Local).AddTicks(9168), "EFG-123", 3, 5, 850.0, "System", "EFG-123", 2022 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37ccb19d-b273-4634-88eb-c692e0f0f4b8",
                column: "ConcurrencyStamp",
                value: "176d81dd-fc85-4ec1-935a-7ee874af332f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44031f2e-904e-414c-adb1-c0a4d391ddab",
                column: "ConcurrencyStamp",
                value: "fff60da4-4de5-410f-9461-d4bdea4a2cd8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5839dff5-2d5d-499a-b12b-0efae987dd25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89a0523e-baa3-41ab-8a8c-c16b524c3d65", "AQAAAAEAACcQAAAAEItkNMYaMl3o/LO7KX5sBFK3+slcwZoZGCbnX5QuzLA0YBd3ELL+2yILiMTRCitHCg==", "51e696ab-b756-4643-990b-24081fa0b56f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f86bb2cd-776d-4551-8ef4-21cf956f2ea1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6625df30-5984-4528-b652-ad361a701032", "AQAAAAEAACcQAAAAEN9Wt9C9qtDfMt8G2UNDSCln1zJ25dixaQL82eAD6EZcpQCh3AxfKpKRi4hXaGCpnw==", "5e60d694-567b-4aaa-afa8-20a04c6f813a" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(8669), new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(8709) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(8712), new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(8716), new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(8719), new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 6, 34, 917, DateTimeKind.Local).AddTicks(8490), new DateTime(2023, 1, 12, 20, 6, 34, 917, DateTimeKind.Local).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(8907), new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(8912), new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(8916), new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(8920), new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(8991), new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(8993) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(8996), new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(8999), new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(9003), new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(9006), new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(9009), new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(9013), new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(9014) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(9016), new DateTime(2023, 1, 12, 20, 6, 34, 902, DateTimeKind.Local).AddTicks(9018) });
        }
    }
}
