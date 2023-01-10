using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fd777e6-6443-4eab-815a-723124fbc3ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8f1f71b-da63-439f-a043-88a16eab2065");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "37ccb19d-b273-4634-88eb-c692e0f0f4b8", "d1681f3e-4d91-4194-a6af-e1b306605c3b", "Administrator", "ADMINISTRATOR" },
                    { "44031f2e-904e-414c-adb1-c0a4d391ddab", "f8918a48-6218-40a6-ad39-b77f5e1ac60c", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5839dff5-2d5d-499a-b12b-0efae987dd25", 0, "9e507cc0-7511-4fb5-913b-e51d53165868", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEMICepqg3A93en3HaVkijzm8l7js93VOThmSBm8rw4t17WBegvxm/v7JY3NlUZBRbA==", null, false, "65f92548-735a-49b1-b20a-7ce49f0019a5", false, "admin@localhost.com" },
                    { "f86bb2cd-776d-4551-8ef4-21cf956f2ea1", 0, "6c165988-3d56-4e7b-8313-b9e8135d25c4", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAENnu0BYvr+6bbKM93LI9Wf642ozpEO9U1lu6fRI0vth9NUBb2OLOik7oI4w0kc5VGw==", null, false, "86058d99-8b92-4f70-bd45-16a6e0d39a6b", false, "user@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3248), new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3286), new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3290), new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3291) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3293), new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3492), new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3495) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3498), new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3501), new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3505), new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3628), new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3634), new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3635) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3637), new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3641), new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3642) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3644), new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3646) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3647), new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3651), new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3652) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3654), new DateTime(2023, 1, 10, 12, 55, 24, 784, DateTimeKind.Local).AddTicks(3656) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "37ccb19d-b273-4634-88eb-c692e0f0f4b8", "5839dff5-2d5d-499a-b12b-0efae987dd25" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "44031f2e-904e-414c-adb1-c0a4d391ddab", "f86bb2cd-776d-4551-8ef4-21cf956f2ea1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "37ccb19d-b273-4634-88eb-c692e0f0f4b8", "5839dff5-2d5d-499a-b12b-0efae987dd25" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "44031f2e-904e-414c-adb1-c0a4d391ddab", "f86bb2cd-776d-4551-8ef4-21cf956f2ea1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37ccb19d-b273-4634-88eb-c692e0f0f4b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44031f2e-904e-414c-adb1-c0a4d391ddab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5839dff5-2d5d-499a-b12b-0efae987dd25");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f86bb2cd-776d-4551-8ef4-21cf956f2ea1");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

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
    }
}
