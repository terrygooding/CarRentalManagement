using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultCustomerData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "ContactNumber", "CreatedBy", "DateCreated", "DateUpdated", "EmailAddress", "FirstName", "LastName", "TaxId", "UpdatedBy" },
                values: new object[] { 1, "Blundeston, Norwich, UK", "0123456789", "System", new DateTime(2023, 1, 12, 20, 6, 34, 917, DateTimeKind.Local).AddTicks(8490), new DateTime(2023, 1, 12, 20, 6, 34, 917, DateTimeKind.Local).AddTicks(8545), "terry@bluedepthcreative.com", "Terry", "Gooding", "123-ABC", "System" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

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
    }
}
