using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "Estates",
                newName: "DistrictName");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 22, 10, 425, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 22, 10, 425, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 22, 10, 425, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 22, 10, 425, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 22, 10, 425, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 22, 10, 425, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 22, 10, 425, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 22, 10, 425, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "EstateType",
                keyColumn: "EstateTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 22, 10, 425, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "EstateType",
                keyColumn: "EstateTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 22, 10, 425, DateTimeKind.Local).AddTicks(4903));

            migrationBuilder.UpdateData(
                table: "EstateType",
                keyColumn: "EstateTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 22, 10, 425, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 22, 10, 425, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 22, 10, 425, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 22, 10, 425, DateTimeKind.Local).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 22, 10, 425, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 16, 22, 10, 425, DateTimeKind.Local).AddTicks(4956));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DistrictName",
                table: "Estates",
                newName: "District");

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
    }
}
