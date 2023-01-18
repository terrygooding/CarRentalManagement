using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedValidationToCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37ccb19d-b273-4634-88eb-c692e0f0f4b8",
                column: "ConcurrencyStamp",
                value: "52d4f9c1-a96f-42c7-a327-146c4fab5f4d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44031f2e-904e-414c-adb1-c0a4d391ddab",
                column: "ConcurrencyStamp",
                value: "c2852ef6-127d-457a-b6b5-53219d477bc8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5839dff5-2d5d-499a-b12b-0efae987dd25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04b291fe-2072-482f-86a6-6b21f984c639", "AQAAAAEAACcQAAAAEB6IvW8G44iWD2ojJZc2nWjZFlDNKIoveLKHjiUd5k+BT89PZHY+eYls90EAfi7oNg==", "f799ab63-b520-4bc2-8b60-39e5594ee4a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f86bb2cd-776d-4551-8ef4-21cf956f2ea1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03723163-b60a-4692-bed1-6b1bdee87c48", "AQAAAAEAACcQAAAAEMDv32IQB4aszoZMpjoaGFpflt0q4aAHSsP+eal0y5Sh6nmJwbSwliTQj9yfbhYUTw==", "9080903c-1a1e-4b8e-abdc-efbf5296ad84" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 18, 21, 43, 0, 564, DateTimeKind.Local).AddTicks(8716), new DateTime(2023, 1, 18, 21, 43, 0, 564, DateTimeKind.Local).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(8753), new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(8791), new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(8795), new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(8798), new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 18, 21, 43, 0, 564, DateTimeKind.Local).AddTicks(8421), new DateTime(2023, 1, 18, 21, 43, 0, 564, DateTimeKind.Local).AddTicks(8463) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(9020), new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(9027), new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(9030), new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(9033), new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(9171), new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(9177), new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(9178) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(9180), new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(9184), new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(9187), new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(9189) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(9190), new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(9194), new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(9195) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(9197), new DateTime(2023, 1, 18, 21, 43, 0, 550, DateTimeKind.Local).AddTicks(9198) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 18, 21, 43, 0, 564, DateTimeKind.Local).AddTicks(8561), new DateTime(2023, 1, 18, 21, 43, 0, 564, DateTimeKind.Local).AddTicks(8564) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 18, 21, 43, 0, 564, DateTimeKind.Local).AddTicks(8567), new DateTime(2023, 1, 18, 21, 43, 0, 564, DateTimeKind.Local).AddTicks(8569) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37ccb19d-b273-4634-88eb-c692e0f0f4b8",
                column: "ConcurrencyStamp",
                value: "228a5290-241a-46aa-bd4c-fb0a88ea89f7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44031f2e-904e-414c-adb1-c0a4d391ddab",
                column: "ConcurrencyStamp",
                value: "80b8bea4-f646-4782-a3bb-3f1cd8ca2b4e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5839dff5-2d5d-499a-b12b-0efae987dd25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfdeeaa3-4c95-4c1c-afe5-a20f866f2519", "AQAAAAEAACcQAAAAECh2uRbtjZFc/1OEqSGqCquZwqXnTpITWhqACnsmf/0P8jV9Yr4d186HrgkHa3cRlQ==", "724d11ee-0ed0-40a0-9d49-f35f7632cf2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f86bb2cd-776d-4551-8ef4-21cf956f2ea1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffd58694-ef78-4959-a583-1ba6ab848208", "AQAAAAEAACcQAAAAECrAHl5RNdzWOJt6Fy8ab+ZROvjyi47l5Njfyzqc6YkeXKywwnUKzXtW+Y+f9VmVAw==", "b04b14a3-a524-498d-b1fb-7d31a6c3995b" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 13, 11, 2, 24, 575, DateTimeKind.Local).AddTicks(2375), new DateTime(2023, 1, 13, 11, 2, 24, 575, DateTimeKind.Local).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7519), new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7556) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7559), new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7562), new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7564) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7566), new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7567) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 13, 11, 2, 24, 575, DateTimeKind.Local).AddTicks(2147), new DateTime(2023, 1, 13, 11, 2, 24, 575, DateTimeKind.Local).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7740), new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7745), new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7750), new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7753), new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7816), new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7819) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7821), new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7822) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7824), new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7826) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7827), new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7831), new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7834), new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7836) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7838), new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7841), new DateTime(2023, 1, 13, 11, 2, 24, 561, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 13, 11, 2, 24, 575, DateTimeKind.Local).AddTicks(2252), new DateTime(2023, 1, 13, 11, 2, 24, 575, DateTimeKind.Local).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 13, 11, 2, 24, 575, DateTimeKind.Local).AddTicks(2257), new DateTime(2023, 1, 13, 11, 2, 24, 575, DateTimeKind.Local).AddTicks(2259) });
        }
    }
}
