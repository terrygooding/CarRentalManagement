using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class DefaultUserChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37ccb19d-b273-4634-88eb-c692e0f0f4b8",
                column: "ConcurrencyStamp",
                value: "8d3f951a-f01c-4bd2-9f8c-ed796a88823d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44031f2e-904e-414c-adb1-c0a4d391ddab",
                column: "ConcurrencyStamp",
                value: "532a4402-4bc8-4417-aaad-6fa6f141b2aa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5839dff5-2d5d-499a-b12b-0efae987dd25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba4dbb3a-32d2-4ca3-80b1-13b15d0462fb", "AQAAAAEAACcQAAAAEPhiBwxe7854GdLNZaSOJeZ09TXgUy8HVQqP8M4dT1sHv7yxkTnIGdaEaViX1ANXyA==", "8486cc1e-0d27-47fc-a30f-8cdfe9f5d76c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f86bb2cd-776d-4551-8ef4-21cf956f2ea1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9eb343a-b090-408d-96b9-414910d11d4f", "AQAAAAEAACcQAAAAEBaCPUnr9Uju6OGs5OSow2/oWCe845Ko01ChZ/YnIZoshbY23CpiEOMqaRU/Jcqkcw==", "bde56b59-b2d1-4467-818b-0bdaf99a3346" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3480), new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3514) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3517), new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3519) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3521), new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3525), new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3721), new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3724) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3727), new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3728) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3730), new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3732) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3734), new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3736) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3806), new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3808) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3810), new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3812) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3814), new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3816) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3818), new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3819) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3821), new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3823) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3825), new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3826) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3829), new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3830) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3832), new DateTime(2023, 1, 11, 17, 29, 24, 566, DateTimeKind.Local).AddTicks(3834) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37ccb19d-b273-4634-88eb-c692e0f0f4b8",
                column: "ConcurrencyStamp",
                value: "d1681f3e-4d91-4194-a6af-e1b306605c3b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44031f2e-904e-414c-adb1-c0a4d391ddab",
                column: "ConcurrencyStamp",
                value: "f8918a48-6218-40a6-ad39-b77f5e1ac60c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5839dff5-2d5d-499a-b12b-0efae987dd25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e507cc0-7511-4fb5-913b-e51d53165868", "AQAAAAEAACcQAAAAEMICepqg3A93en3HaVkijzm8l7js93VOThmSBm8rw4t17WBegvxm/v7JY3NlUZBRbA==", "65f92548-735a-49b1-b20a-7ce49f0019a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f86bb2cd-776d-4551-8ef4-21cf956f2ea1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c165988-3d56-4e7b-8313-b9e8135d25c4", "AQAAAAEAACcQAAAAENnu0BYvr+6bbKM93LI9Wf642ozpEO9U1lu6fRI0vth9NUBb2OLOik7oI4w0kc5VGw==", "86058d99-8b92-4f70-bd45-16a6e0d39a6b" });

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
        }
    }
}
