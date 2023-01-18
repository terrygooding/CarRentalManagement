using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class UpdatedDbToHandleObjectCycles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Models",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Models",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Manufacturers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Manufacturers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Colours",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Colours",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "SYSTEM", new DateTime(2023, 1, 13, 11, 2, 24, 575, DateTimeKind.Local).AddTicks(2252), new DateTime(2023, 1, 13, 11, 2, 24, 575, DateTimeKind.Local).AddTicks(2254), "SYSTEM" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "SYSTEM", new DateTime(2023, 1, 13, 11, 2, 24, 575, DateTimeKind.Local).AddTicks(2257), new DateTime(2023, 1, 13, 11, 2, 24, 575, DateTimeKind.Local).AddTicks(2259), "SYSTEM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Models",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Models",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Manufacturers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Manufacturers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Colours",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Colours",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 21, 54, 24, 482, DateTimeKind.Local).AddTicks(3873), new DateTime(2023, 1, 12, 21, 54, 24, 482, DateTimeKind.Local).AddTicks(3875) });

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
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2023, 1, 12, 21, 54, 24, 482, DateTimeKind.Local).AddTicks(3791), new DateTime(2023, 1, 12, 21, 54, 24, 482, DateTimeKind.Local).AddTicks(3794), "System" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2023, 1, 12, 21, 54, 24, 482, DateTimeKind.Local).AddTicks(3797), new DateTime(2023, 1, 12, 21, 54, 24, 482, DateTimeKind.Local).AddTicks(3799), "System" });
        }
    }
}
