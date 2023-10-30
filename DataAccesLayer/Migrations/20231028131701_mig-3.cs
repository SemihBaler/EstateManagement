using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 17, 1, 651, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 17, 1, 651, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 17, 1, 651, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 17, 1, 651, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 17, 1, 651, DateTimeKind.Local).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 17, 1, 651, DateTimeKind.Local).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 17, 1, 651, DateTimeKind.Local).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 17, 1, 651, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "EstateType",
                keyColumn: "EstateTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 17, 1, 651, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "EstateType",
                keyColumn: "EstateTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 17, 1, 651, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "EstateType",
                keyColumn: "EstateTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 17, 1, 651, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 17, 1, 651, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 17, 1, 651, DateTimeKind.Local).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 17, 1, 651, DateTimeKind.Local).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 17, 1, 651, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 17, 1, 651, DateTimeKind.Local).AddTicks(5929));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 16, 26, 26, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 16, 26, 26, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 16, 26, 26, DateTimeKind.Local).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 16, 26, 26, DateTimeKind.Local).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 16, 26, 26, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 16, 26, 26, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 16, 26, 26, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 16, 26, 26, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "EstateType",
                keyColumn: "EstateTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 16, 26, 26, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "EstateType",
                keyColumn: "EstateTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 16, 26, 26, DateTimeKind.Local).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "EstateType",
                keyColumn: "EstateTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 16, 26, 26, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 16, 26, 26, DateTimeKind.Local).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 16, 26, 26, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 16, 26, 26, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 16, 26, 26, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 16, 26, 26, DateTimeKind.Local).AddTicks(5377));
        }
    }
}
