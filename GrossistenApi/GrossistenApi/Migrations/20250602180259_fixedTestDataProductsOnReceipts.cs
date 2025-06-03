using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GrossistenApi.Migrations
{
    /// <inheritdoc />
    public partial class fixedTestDataProductsOnReceipts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ReceiptId", "ShowOnReceipt" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ReceiptId", "ShowOnReceipt" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ReceiptId", "ShowOnReceipt" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ShowInAvailableToPurchase", "ShowInStock" },
                values: new object[] { true, true });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 10,
                column: "ShowInAvailableToPurchase",
                value: true);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ReceiptId", "ShowOnReceipt" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 12,
                column: "ReceiptId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ReceiptId", "ShowOnReceipt" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 14,
                column: "ReceiptId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ReceiptId", "ShowOnReceipt" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ReceiptId", "ShowInStock", "ShowOnReceipt" },
                values: new object[] { null, true, false });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ReceiptId", "ShowOnReceipt" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ReceiptId", "ShowInStock", "ShowOnReceipt" },
                values: new object[] { null, true, false });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ReceiptId", "ShowInAvailableToPurchase", "ShowOnReceipt" },
                values: new object[] { null, true, false });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ReceiptId", "ShowOnReceipt" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 26,
                column: "ShowOnReceipt",
                value: false);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 30,
                column: "ShowOnReceipt",
                value: false);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 35,
                column: "ShowOnReceipt",
                value: false);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 37,
                column: "ShowOnReceipt",
                value: false);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 40,
                column: "ShowOnReceipt",
                value: false);

            migrationBuilder.InsertData(
                table: "ProductsTable",
                columns: new[] { "Id", "ArticleNumber", "Category", "Description", "Price", "Quantity", "ReceiptId", "ShowInAvailableToPurchase", "ShowInStock", "ShowOnReceipt", "Size", "Title" },
                values: new object[,]
                {
                    { 41, "5012345678900", "Kläder", "Blå jeans, normal passform", 499.0, 5, 2, false, false, true, "M", "Jeans" },
                    { 42, "6012345678901", "Kläder", "Grå hoodie", 599.0, 4, 4, false, false, true, "M", "Hoodie" },
                    { 43, "8001234567890", "Accessoarer", "Analog klocka", 1299.0, 3, 6, false, false, true, "25 cm", "Klocka" },
                    { 44, "1101234567895", "Böcker", "The Great Gatsby", 149.0, 10, 1, false, false, true, "13×20 cm", "Bok" },
                    { 45, "1201234567896", "Leksaker", "Träschackspel", 349.0, 3, 2, false, false, true, "40×40 cm", "Schackspel" },
                    { 46, "1301234567897", "Leksaker", "Superhjältefigur", 249.0, 6, 3, false, false, true, "15 cm", "Actionfigur" },
                    { 47, "1401234567898", "Hem", "24-delars set i rostfritt stål", 599.0, 8, 4, false, false, true, "30×20×5 cm", "Bestickset" },
                    { 48, "1501234567899", "Hem", "LED-skrivbordslampa", 349.0, 6, 5, false, false, true, "45 cm", "Skrivbordslampa" },
                    { 49, "1601234567800", "Skönhet", "Blommig doft 50 ml", 799.0, 5, 6, false, false, true, "50 ml", "Parfym" },
                    { 50, "1701234567801", "Elektronik", "Trådlösa over-ear", 1299.0, 7, 7, false, false, true, "15×18 cm", "Hörlurar" },
                    { 51, "1801234567802", "Sport", "Halkfri 6 mm", 299.0, 8, 8, false, false, true, "183×61 cm", "Yogamatta" },
                    { 52, "1901234567803", "Utomhus", "Tält för 2 personer", 1599.0, 10, 9, false, false, true, "210×140×110 cm", "Tält" },
                    { 53, "2101234567804", "Husdjur", "Hållbar tuggleksak", 129.0, 9, 10, false, false, true, "15×5 cm", "Hundleksak" }
                });

            migrationBuilder.UpdateData(
                table: "ReceiptsTable",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "showAsIncomingReceipt", "showAsOutgoingReceipt" },
                values: new object[] { false, true });

            migrationBuilder.UpdateData(
                table: "ReceiptsTable",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "showAsIncomingReceipt", "showAsOutgoingReceipt" },
                values: new object[] { false, true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ReceiptId", "ShowOnReceipt" },
                values: new object[] { 2, true });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ReceiptId", "ShowOnReceipt" },
                values: new object[] { 4, true });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ReceiptId", "ShowOnReceipt" },
                values: new object[] { 6, true });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ShowInAvailableToPurchase", "ShowInStock" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 10,
                column: "ShowInAvailableToPurchase",
                value: false);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ReceiptId", "ShowOnReceipt" },
                values: new object[] { 1, true });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 12,
                column: "ReceiptId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ReceiptId", "ShowOnReceipt" },
                values: new object[] { 3, true });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 14,
                column: "ReceiptId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ReceiptId", "ShowOnReceipt" },
                values: new object[] { 5, true });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ReceiptId", "ShowInStock", "ShowOnReceipt" },
                values: new object[] { 6, false, true });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ReceiptId", "ShowOnReceipt" },
                values: new object[] { 7, true });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ReceiptId", "ShowInStock", "ShowOnReceipt" },
                values: new object[] { 8, false, true });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ReceiptId", "ShowInAvailableToPurchase", "ShowOnReceipt" },
                values: new object[] { 9, false, true });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ReceiptId", "ShowOnReceipt" },
                values: new object[] { 10, true });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 26,
                column: "ShowOnReceipt",
                value: true);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 30,
                column: "ShowOnReceipt",
                value: true);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 35,
                column: "ShowOnReceipt",
                value: true);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 37,
                column: "ShowOnReceipt",
                value: true);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 40,
                column: "ShowOnReceipt",
                value: true);

            migrationBuilder.UpdateData(
                table: "ReceiptsTable",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "showAsIncomingReceipt", "showAsOutgoingReceipt" },
                values: new object[] { true, false });

            migrationBuilder.UpdateData(
                table: "ReceiptsTable",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "showAsIncomingReceipt", "showAsOutgoingReceipt" },
                values: new object[] { true, false });
        }
    }
}
