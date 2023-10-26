using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Districts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Districts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Districts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Districts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Cities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Cities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 21, 57, 676, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 21, 57, 676, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 10, 26, 16, 21, 57, 676, DateTimeKind.Local).AddTicks(4709), null, 1, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 10, 26, 16, 21, 57, 676, DateTimeKind.Local).AddTicks(4711), null, 1, null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 21, 57, 676, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 21, 57, 676, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 10, 26, 16, 21, 57, 676, DateTimeKind.Local).AddTicks(4751), null, 1, null });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 10, 26, 16, 21, 57, 676, DateTimeKind.Local).AddTicks(4753), null, 1, null });

            migrationBuilder.UpdateData(
                table: "EstateType",
                keyColumn: "EstateTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 21, 57, 676, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "EstateType",
                keyColumn: "EstateTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 21, 57, 676, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "EstateType",
                keyColumn: "EstateTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 21, 57, 676, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 21, 57, 676, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 21, 57, 676, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 21, 57, 676, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 21, 57, 676, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 21, 57, 676, DateTimeKind.Local).AddTicks(4664));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Cities");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 14, 51, 56, 356, DateTimeKind.Local).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 14, 51, 56, 356, DateTimeKind.Local).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 14, 51, 56, 356, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 14, 51, 56, 356, DateTimeKind.Local).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "EstateType",
                keyColumn: "EstateTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 14, 51, 56, 356, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "EstateType",
                keyColumn: "EstateTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 14, 51, 56, 356, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "EstateType",
                keyColumn: "EstateTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 14, 51, 56, 356, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 14, 51, 56, 356, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 14, 51, 56, 356, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 14, 51, 56, 356, DateTimeKind.Local).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 14, 51, 56, 356, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 14, 51, 56, 356, DateTimeKind.Local).AddTicks(2075));
        }
    }
}
