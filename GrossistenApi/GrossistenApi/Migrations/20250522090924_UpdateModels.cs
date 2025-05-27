using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GrossistenApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductsTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    ShowInAvailableToPurchase = table.Column<bool>(type: "bit", nullable: true),
                    ShowInStock = table.Column<bool>(type: "bit", nullable: true),
                    ShowOnReceipt = table.Column<bool>(type: "bit", nullable: true),
                    ReceiptId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptsTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiptProductId = table.Column<int>(type: "int", nullable: true),
                    PersonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Incoming = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Outgoing = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IncomingReceipt = table.Column<bool>(type: "bit", nullable: true),
                    OutgoingReceipt = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptsTable", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ProductsTable",
                columns: new[] { "Id", "ArticleNumber", "Category", "Description", "Price", "Quantity", "ReceiptId", "ShowInAvailableToPurchase", "ShowInStock", "ShowOnReceipt", "Size", "Title" },
                values: new object[,]
                {
                    { 1, "4006381333931", "Clothes", "Classic white T-Shirt", 199.0, 150, null, true, true, false, "L", "T-Shirt" },
                    { 2, "5012345678900", "Clothes", "Regular fit blue jeans", 499.0, 80, 2, true, true, true, "M", "Jeans" },
                    { 3, "5023456789012", "Footwear", "Running sneakers", 899.0, 60, null, true, true, false, "S", "Sneakers" },
                    { 4, "6012345678901", "Clothes", "Grey hoodie", 599.0, 40, 4, true, true, true, "M", "Hoodie" },
                    { 5, "7012345678902", "Accessories", "Baseball cap", 149.0, 200, null, true, true, false, "M", "Cap" },
                    { 6, "8001234567890", "Accessories", "Analog watch", 1299.0, 30, 6, true, true, true, null, "Watch" },
                    { 7, "9001234567891", "Electronics", "33-Cm ultrabook", 9999.0, 0, null, false, false, false, null, "Laptop" },
                    { 8, "3001234567892", "Home", "Ceramic mug 350 ml", 99.0, 120, null, true, true, false, null, "Coffee Mug" },
                    { 9, "2001234567893", "Accessories", "Travel backpack 20 L", 799.0, 50, null, true, true, false, "L", "Backpack" },
                    { 10, "1001234567894", "Accessories", "UV protection", 399.0, 75, null, false, true, false, null, "Sunglasses" },
                    { 11, "1101234567895", "Books", "The Great Gatsby", 149.0, 100, 11, true, true, true, null, "Book" },
                    { 12, "1201234567896", "Toys", "Wooden chess set", 349.0, 20, null, true, true, false, null, "Chess Set" },
                    { 13, "1301234567897", "Toys", "Superhero figurine", 249.0, 60, null, true, true, false, null, "Action Figure" },
                    { 14, "1401234567898", "Home", "24-piece stainless set", 599.0, 80, null, true, true, false, null, "Cutlery Set" },
                    { 15, "1501234567899", "Home", "LED desk lamp", 349.0, 35, 15, true, true, true, null, "Desk Lamp" },
                    { 16, "1601234567800", "Beauty", "Floral scent 50 ml", 799.0, 0, null, true, false, false, null, "Perfume" },
                    { 17, "1701234567801", "Electronics", "Wireless over-ear", 1299.0, 45, null, true, true, false, null, "Headphones" },
                    { 18, "1801234567802", "Sports", "Non-slip 6 mm", 299.0, 0, 18, true, false, true, null, "Yoga Mat" },
                    { 19, "1901234567803", "Outdoor", "2-person hiking tent", 1599.0, 15, null, false, true, false, null, "Tent" },
                    { 20, "2101234567804", "Pet", "Durable chew toy", 129.0, 90, null, true, true, false, null, "Dog Toy" }
                });

            migrationBuilder.InsertData(
                table: "ReceiptsTable",
                columns: new[] { "Id", "Incoming", "IncomingReceipt", "Outgoing", "OutgoingReceipt", "PersonName", "ReceiptProductId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), true, null, false, "Peter Nilsson", 3 },
                    { 2, new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), true, null, false, "Maria Andersson", 2 },
                    { 3, new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), true, null, false, "Johan Karlsson", 7 },
                    { 4, new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), true, null, false, "Elin Larsson", 10 },
                    { 5, new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), true, null, false, "Lars Gustafsson", 17 },
                    { 6, null, false, new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), true, "Anna Sjöberg", 1 },
                    { 7, null, false, new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), true, "Oskar Lindqvist", 13 },
                    { 8, null, false, new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), true, "Sara Ek", 20 },
                    { 9, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Local), true, null, false, "Fredrik Öberg", 5 },
                    { 10, new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local), true, null, false, "Maria Johansson", 12 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsTable");

            migrationBuilder.DropTable(
                name: "ReceiptsTable");
        }
    }
}
