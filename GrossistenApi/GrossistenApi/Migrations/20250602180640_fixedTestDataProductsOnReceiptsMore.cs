using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrossistenApi.Migrations
{
    /// <inheritdoc />
    public partial class fixedTestDataProductsOnReceiptsMore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 24,
                column: "ShowOnReceipt",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 24,
                column: "ShowOnReceipt",
                value: true);
        }
    }
}
