using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GrossistenApi.Migrations
{
    /// <inheritdoc />
    public partial class updatetestdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Klassisk vit t-shirt", "T-shirt" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Blå jeans, normal passform");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Löparsneakers");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Grå hoodie");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Basebollkeps", "Keps" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Analog klocka", "Klocka" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Size", "Title" },
                values: new object[] { "33 cm ultrabook", "33 cm", "Bärbar dator" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Size", "Title" },
                values: new object[] { "Keramisk mugg 350 ml", "350 ml", "Kaffemugg" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Size", "Title" },
                values: new object[] { "Reseryggsäck 20 L", "20 L", "Ryggsäck" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Title" },
                values: new object[] { "UV-skydd", "Solglasögon" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ReceiptId", "Title" },
                values: new object[] { 1, "Bok" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ReceiptId", "Title" },
                values: new object[] { "Träschackspel", 2, "Schackspel" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ReceiptId", "Title" },
                values: new object[] { "Superhjältefigur", 3, "Actionfigur" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ReceiptId", "Title" },
                values: new object[] { "24-delars set i rostfritt stål", 4, "Bestickset" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ReceiptId", "Title" },
                values: new object[] { "LED-skrivbordslampa", 5, "Skrivbordslampa" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ReceiptId", "Size", "Title" },
                values: new object[] { "Blommig doft 50 ml", 6, "50 ml", "Parfym" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ReceiptId", "Title" },
                values: new object[] { "Trådlösa over-ear", 7, "Hörlurar" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ReceiptId", "Title" },
                values: new object[] { "Halkfri 6 mm", 8, "Yogamatta" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ReceiptId", "Title" },
                values: new object[] { "Tält för 2 personer", 9, "Tält" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ReceiptId", "Title" },
                values: new object[] { "Hållbar tuggleksak", 10, "Hundleksak" });

            migrationBuilder.InsertData(
                table: "ProductsTable",
                columns: new[] { "Id", "ArticleNumber", "Category", "Description", "Price", "Quantity", "ReceiptId", "ShowInAvailableToPurchase", "ShowInStock", "ShowOnReceipt", "Size", "Title" },
                values: new object[,]
                {
                    { 21, "2201234567805", "Clothes", "Vattentät jacka", 899.0, 30, null, true, true, false, "L", "Jacka" },
                    { 22, "2301234567806", "Footwear", "Sommarsandaler", 349.0, 45, null, true, true, false, "38", "Sandaler" },
                    { 23, "2401234567807", "Accessories", "Läderbälte", 299.0, 60, null, true, true, false, "M", "Skärp" },
                    { 24, "2501234567808", "Electronics", "6,5\" skärm, 128GB", 5999.0, 25, null, true, true, true, null, "Smartphone" },
                    { 25, "2601234567809", "Home", "Bomull, 45×45 cm", 199.0, 100, null, true, true, false, null, "Prydnadskudde" },
                    { 26, "2701234567810", "Books", "Vegetariska recept", 249.0, 80, null, true, true, true, null, "Kokbok" },
                    { 27, "2801234567811", "Toys", "1000 bitar landskap", 159.0, 70, null, true, true, false, null, "Pussel" },
                    { 28, "2901234567812", "Beauty", "Fuktgivande 200 ml", 129.0, 50, null, true, true, false, null, "Lotion" },
                    { 29, "3001234567813", "Sports", "Strl S/M, justerbar", 499.0, 40, null, true, true, false, "S/M", "Cykelhjälm" },
                    { 30, "3101234567814", "Outdoor", "Lättvikts för camping", 699.0, 20, null, true, true, true, null, "Sovsäck" },
                    { 31, "3201234567815", "Pet", "Fjäder på pinne", 79.0, 120, null, true, true, false, null, "Kattleksak" },
                    { 32, "3301234567816", "Clothes", "Svart t-shirt", 199.0, 90, null, true, true, false, "M", "T-shirt" },
                    { 33, "3401234567817", "Footwear", "Vandringskängor", 1299.0, 35, null, true, true, false, "42", "Kängor" },
                    { 34, "3501234567818", "Accessories", "Läder, svart", 349.0, 55, null, true, true, false, null, "Plånbok" },
                    { 35, "3601234567819", "Electronics", "Portabel, vattentät", 799.0, 45, null, true, true, true, null, "Bluetooth-högtalare" },
                    { 36, "3701234567820", "Home", "Analog träfinish", 299.0, 65, null, true, true, false, null, "Väggklocka" },
                    { 37, "3801234567821", "Books", "Moderna klassiker", 179.0, 90, null, true, true, true, null, "Roman" },
                    { 38, "3901234567822", "Toys", "Strategispel för 2–4", 399.0, 40, null, true, true, false, null, "Brädspel" },
                    { 39, "4001234567823", "Beauty", "Ögonskugga & läppstift", 499.0, 30, null, true, true, false, null, "Sminkkit" },
                    { 40, "4101234567824", "Sports", "2×5 kg, justerbart", 899.0, 25, null, true, true, true, null, "Hantelset" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Classic white T-Shirt", "T-Shirt" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Regular fit blue jeans");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Running sneakers");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Grey hoodie");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Baseball cap", "Cap" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Analog watch", "Watch" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Size", "Title" },
                values: new object[] { "33-Cm ultrabook", null, "Laptop" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Size", "Title" },
                values: new object[] { "Ceramic mug 350 ml", null, "Coffee Mug" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Size", "Title" },
                values: new object[] { "Travel backpack 20 L", "L", "Backpack" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Title" },
                values: new object[] { "UV protection", "Sunglasses" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ReceiptId", "Title" },
                values: new object[] { 11, "Book" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ReceiptId", "Title" },
                values: new object[] { "Wooden chess set", null, "Chess Set" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ReceiptId", "Title" },
                values: new object[] { "Superhero figurine", null, "Action Figure" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ReceiptId", "Title" },
                values: new object[] { "24-piece stainless set", null, "Cutlery Set" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ReceiptId", "Title" },
                values: new object[] { "LED desk lamp", 15, "Desk Lamp" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ReceiptId", "Size", "Title" },
                values: new object[] { "Floral scent 50 ml", null, null, "Perfume" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ReceiptId", "Title" },
                values: new object[] { "Wireless over-ear", null, "Headphones" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ReceiptId", "Title" },
                values: new object[] { "Non-slip 6 mm", 18, "Yoga Mat" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ReceiptId", "Title" },
                values: new object[] { "2-person hiking tent", null, "Tent" });

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ReceiptId", "Title" },
                values: new object[] { "Durable chew toy", null, "Dog Toy" });
        }
    }
}
