using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesWebAPI.Migrations
{
    public partial class createdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buyers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buyers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesPoints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesPoints", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProvidedProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SalesPointId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductQuantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProvidedProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProvidedProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProvidedProducts_SalesPoints_SalesPointId",
                        column: x => x.SalesPointId,
                        principalTable: "SalesPoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<string>(type: "TEXT", nullable: false),
                    Time = table.Column<string>(type: "TEXT", nullable: false),
                    SalesPointId = table.Column<int>(type: "INTEGER", nullable: false),
                    BuyerId = table.Column<int>(type: "INTEGER", nullable: true),
                    TotalAmount = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_Buyers_BuyerId",
                        column: x => x.BuyerId,
                        principalTable: "Buyers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sales_SalesPoints_SalesPointId",
                        column: x => x.SalesPointId,
                        principalTable: "SalesPoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductQuantity = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductIdAmount = table.Column<int>(type: "INTEGER", nullable: false),
                    SaleId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleDatas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleDatas_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleDatas_Sales_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Buyers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Tom" });

            migrationBuilder.InsertData(
                table: "Buyers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Jack" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 1, "FuckToy", 228.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 2, "shit", 1337.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 3, "Smth", 2344.0 });

            migrationBuilder.InsertData(
                table: "SalesPoints",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Eldorado" });

            migrationBuilder.InsertData(
                table: "SalesPoints",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "DnsShop" });

            migrationBuilder.InsertData(
                table: "ProvidedProducts",
                columns: new[] { "Id", "ProductId", "ProductQuantity", "SalesPointId" },
                values: new object[] { 1, 1, 2, 1 });

            migrationBuilder.InsertData(
                table: "ProvidedProducts",
                columns: new[] { "Id", "ProductId", "ProductQuantity", "SalesPointId" },
                values: new object[] { 2, 2, 2, 1 });

            migrationBuilder.InsertData(
                table: "ProvidedProducts",
                columns: new[] { "Id", "ProductId", "ProductQuantity", "SalesPointId" },
                values: new object[] { 3, 1, 2, 2 });

            migrationBuilder.InsertData(
                table: "ProvidedProducts",
                columns: new[] { "Id", "ProductId", "ProductQuantity", "SalesPointId" },
                values: new object[] { 4, 2, 2, 2 });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "BuyerId", "Date", "SalesPointId", "Time", "TotalAmount" },
                values: new object[] { 1, 1, "12.05.2020", 1, "12:34:02", 228.0 });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "BuyerId", "Date", "SalesPointId", "Time", "TotalAmount" },
                values: new object[] { 2, 2, "28.08.2021", 2, "10:45:23", 3681.0 });

            migrationBuilder.InsertData(
                table: "SaleDatas",
                columns: new[] { "Id", "ProductId", "ProductIdAmount", "ProductQuantity", "SaleId" },
                values: new object[] { 1, 1, 228, 1, 1 });

            migrationBuilder.InsertData(
                table: "SaleDatas",
                columns: new[] { "Id", "ProductId", "ProductIdAmount", "ProductQuantity", "SaleId" },
                values: new object[] { 2, 2, 1337, 1, 2 });

            migrationBuilder.InsertData(
                table: "SaleDatas",
                columns: new[] { "Id", "ProductId", "ProductIdAmount", "ProductQuantity", "SaleId" },
                values: new object[] { 3, 3, 2344, 1, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_ProvidedProducts_ProductId",
                table: "ProvidedProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProvidedProducts_SalesPointId",
                table: "ProvidedProducts",
                column: "SalesPointId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDatas_ProductId",
                table: "SaleDatas",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDatas_SaleId",
                table: "SaleDatas",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_BuyerId",
                table: "Sales",
                column: "BuyerId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_SalesPointId",
                table: "Sales",
                column: "SalesPointId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProvidedProducts");

            migrationBuilder.DropTable(
                name: "SaleDatas");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Buyers");

            migrationBuilder.DropTable(
                name: "SalesPoints");
        }
    }
}
