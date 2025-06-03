using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrossistenApi.Migrations
{
    /// <inheritdoc />
    public partial class fixedTestDataProductsOnReceiptsQuantitysFromZero : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 7,
                column: "Quantity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 16,
                column: "Quantity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 18,
                column: "Quantity",
                value: 10);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 7,
                column: "Quantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 16,
                column: "Quantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 18,
                column: "Quantity",
                value: 0);
        }
    }
}
