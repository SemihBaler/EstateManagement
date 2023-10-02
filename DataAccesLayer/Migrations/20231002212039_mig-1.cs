using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "EstateType",
                columns: table => new
                {
                    EstateTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstateType", x => x.EstateTypeId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Estates",
                columns: table => new
                {
                    EstateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<int>(type: "int", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstateTypeId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estates", x => x.EstateId);
                    table.ForeignKey(
                        name: "FK_Estates_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Estates_EstateType_EstateTypeId",
                        column: x => x.EstateTypeId,
                        principalTable: "EstateType",
                        principalColumn: "EstateTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Budget = table.Column<int>(type: "int", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    EstateTypeId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customers_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customers_EstateType_EstateTypeId",
                        column: x => x.EstateTypeId,
                        principalTable: "EstateType",
                        principalColumn: "EstateTypeId");
                    table.ForeignKey(
                        name: "FK_Customers_User_TypeId",
                        column: x => x.TypeId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 3, 0, 20, 38, 987, DateTimeKind.Local).AddTicks(5157), null, "Satılık", 1, null },
                    { 2, new DateTime(2023, 10, 3, 0, 20, 38, 987, DateTimeKind.Local).AddTicks(5167), null, "Kiralık", 1, null }
                });

            migrationBuilder.InsertData(
                table: "EstateType",
                columns: new[] { "EstateTypeId", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 3, 0, 20, 38, 987, DateTimeKind.Local).AddTicks(5400), null, "Müstakil", 1, null },
                    { 2, new DateTime(2023, 10, 3, 0, 20, 38, 987, DateTimeKind.Local).AddTicks(6912), null, "Daire", 1, null },
                    { 3, new DateTime(2023, 10, 3, 0, 20, 38, 987, DateTimeKind.Local).AddTicks(6915), null, "Arsa", 1, null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "CreatedDate", "DeletedDate", "LastName", "Mail", "Name", "Password", "PhoneNumber", "Role", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 3, 0, 20, 38, 987, DateTimeKind.Local).AddTicks(7016), null, null, null, "Ahmet", null, null, "User", 1, null },
                    { 2, new DateTime(2023, 10, 3, 0, 20, 38, 987, DateTimeKind.Local).AddTicks(7017), null, null, null, "Mehmet", null, null, "Customer", 1, null },
                    { 3, new DateTime(2023, 10, 3, 0, 20, 38, 987, DateTimeKind.Local).AddTicks(7018), null, null, null, "Yade", null, null, "Admin", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Adress", "Budget", "CategoryId", "CreatedDate", "DeletedDate", "EstateTypeId", "LastName", "Mail", "Name", "PhoneNumber", "Status", "TypeId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Ankara", 5000000, 1, new DateTime(2023, 10, 3, 0, 20, 38, 987, DateTimeKind.Local).AddTicks(5293), null, null, "Baler", "semihbaler@gmail.com", "Semih", null, 1, 2, null },
                    { 2, "Balıkesir", 12000, 2, new DateTime(2023, 10, 3, 0, 20, 38, 987, DateTimeKind.Local).AddTicks(5299), null, null, "Baler", null, "Merve", null, 1, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Estates",
                columns: new[] { "EstateId", "Adress", "CategoryId", "City", "CreatedDate", "DeletedDate", "District", "EstateTypeId", "Price", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Bağlıca", 1, "Ankara", new DateTime(2023, 10, 3, 0, 20, 38, 987, DateTimeKind.Local).AddTicks(5348), null, "Etimesgut", 2, 7500000, 1, null },
                    { 2, "Alacaatlı", 1, "Ankara", new DateTime(2023, 10, 3, 0, 20, 38, 987, DateTimeKind.Local).AddTicks(5350), null, "Çankaya", 3, 12000000, 1, null },
                    { 3, "Burhaniye", 2, "Balıkesir", new DateTime(2023, 10, 3, 0, 20, 38, 987, DateTimeKind.Local).AddTicks(5352), null, "Susurluk", 1, 6500, 1, null },
                    { 4, "Elvan", 1, "İzmir", new DateTime(2023, 10, 3, 0, 20, 38, 987, DateTimeKind.Local).AddTicks(5352), null, "merkez", 1, 1500000, 1, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CategoryId",
                table: "Customers",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_EstateTypeId",
                table: "Customers",
                column: "EstateTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_TypeId",
                table: "Customers",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Estates_CategoryId",
                table: "Estates",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Estates_EstateTypeId",
                table: "Estates",
                column: "EstateTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Estates");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "EstateType");
        }
    }
}
