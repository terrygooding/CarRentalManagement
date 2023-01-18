using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class UpdatedCustomersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37ccb19d-b273-4634-88eb-c692e0f0f4b8",
                column: "ConcurrencyStamp",
                value: "da85313f-237e-4fe3-a2b5-20982f14db3c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44031f2e-904e-414c-adb1-c0a4d391ddab",
                column: "ConcurrencyStamp",
                value: "2ed90563-5cc6-4bf7-b7c6-bbb3e4c20731");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5839dff5-2d5d-499a-b12b-0efae987dd25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b034e02-50be-463e-a6c4-f25676da4c39", "AQAAAAEAACcQAAAAEE8hHAtLBBZkXA10qb64YeyXfcflzEPyu/u/QO3KG1UqGmbGhu1sIjA01SXXPEWeog==", "56078df0-2a8a-444c-8b35-5539861ca9c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f86bb2cd-776d-4551-8ef4-21cf956f2ea1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e552b537-2090-43ac-bc5a-db5cc19fc66f", "AQAAAAEAACcQAAAAEL+3fR7e6CK0bBGTFYagYuWCXEntWt4pZyZGJMUDnKRfq02ya4hqJr1SuNETAqoDoQ==", "16bd95bc-7f5d-41dc-bfdb-9c6b1ff4df5e" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(8832), new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(8870), new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(8874), new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(8877), new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(9064), new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(9070), new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(9074), new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(9079), new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(9146), new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(9149) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(9151), new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(9154), new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(9158), new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(9161), new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(9163) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(9165), new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(9169), new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(9172), new DateTime(2023, 1, 12, 9, 56, 34, 686, DateTimeKind.Local).AddTicks(9174) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

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
    }
}
