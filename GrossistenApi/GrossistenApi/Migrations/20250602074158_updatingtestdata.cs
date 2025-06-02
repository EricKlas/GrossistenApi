using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrossistenApi.Migrations
{
    /// <inheritdoc />
    public partial class updatingtestdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 6,
                column: "Size",
                value: "25 cm");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 8,
                column: "Size",
                value: "8 cm");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 10,
                column: "Size",
                value: "Glasbredd 52 mm");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 11,
                column: "Size",
                value: "13×20 cm");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 12,
                column: "Size",
                value: "40×40 cm");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 13,
                column: "Size",
                value: "15 cm");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 14,
                column: "Size",
                value: "30×20×5 cm");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 15,
                column: "Size",
                value: "Höjd 45 cm");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 17,
                column: "Size",
                value: "15×18 cm");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 18,
                column: "Size",
                value: "183×61 cm");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 19,
                column: "Size",
                value: "210×140×110 cm");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 20,
                column: "Size",
                value: "15×5 cm");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 24,
                column: "Size",
                value: "16×7,5×0,8 cm");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 25,
                column: "Size",
                value: "45×45 cm");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 26,
                column: "Size",
                value: "18×24 cm");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 27,
                column: "Size",
                value: "50×70 cm");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 28,
                column: "Size",
                value: "200 ml");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 30,
                column: "Size",
                value: "210×75 cm");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 31,
                column: "Size",
                value: "30 cm");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 34,
                column: "Size",
                value: "10×8 cm");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 35,
                column: "Size",
                value: "15×8×7 cm");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 36,
                column: "Size",
                value: "20 cm");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 37,
                column: "Size",
                value: "12×19 cm");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 38,
                column: "Size",
                value: "30×30×5 cm");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 39,
                column: "Size",
                value: "20×15×3 cm");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 40,
                column: "Size",
                value: "Varje hantel 25 cm");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 6,
                column: "Size",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 8,
                column: "Size",
                value: "350 ml");

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 10,
                column: "Size",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 11,
                column: "Size",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 12,
                column: "Size",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 13,
                column: "Size",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 14,
                column: "Size",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 15,
                column: "Size",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 17,
                column: "Size",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 18,
                column: "Size",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 19,
                column: "Size",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 20,
                column: "Size",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 24,
                column: "Size",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 25,
                column: "Size",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 26,
                column: "Size",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 27,
                column: "Size",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 28,
                column: "Size",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 30,
                column: "Size",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 31,
                column: "Size",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 34,
                column: "Size",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 35,
                column: "Size",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 36,
                column: "Size",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 37,
                column: "Size",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 38,
                column: "Size",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 39,
                column: "Size",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductsTable",
                keyColumn: "Id",
                keyValue: 40,
                column: "Size",
                value: null);
        }
    }
}
