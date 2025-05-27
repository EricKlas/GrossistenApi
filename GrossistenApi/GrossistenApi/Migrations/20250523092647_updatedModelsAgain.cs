using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrossistenApi.Migrations
{
    /// <inheritdoc />
    public partial class updatedModelsAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Incoming",
                table: "ReceiptsTable");

            migrationBuilder.DropColumn(
                name: "ReceiptProductId",
                table: "ReceiptsTable");

            migrationBuilder.RenameColumn(
                name: "PersonName",
                table: "ReceiptsTable",
                newName: "WorkerName");

            migrationBuilder.RenameColumn(
                name: "OutgoingReceipt",
                table: "ReceiptsTable",
                newName: "showAsOutgoingReceipt");

            migrationBuilder.RenameColumn(
                name: "Outgoing",
                table: "ReceiptsTable",
                newName: "DateAndTimeCreated");

            migrationBuilder.RenameColumn(
                name: "IncomingReceipt",
                table: "ReceiptsTable",
                newName: "showAsIncomingReceipt");

            migrationBuilder.UpdateData(
                table: "ReceiptsTable",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTimeCreated",
                value: new DateTime(2025, 5, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ReceiptsTable",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTimeCreated",
                value: new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ReceiptsTable",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndTimeCreated",
                value: new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ReceiptsTable",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndTimeCreated",
                value: new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ReceiptsTable",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAndTimeCreated",
                value: new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ReceiptsTable",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAndTimeCreated",
                value: new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ReceiptsTable",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAndTimeCreated",
                value: new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "showAsOutgoingReceipt",
                table: "ReceiptsTable",
                newName: "OutgoingReceipt");

            migrationBuilder.RenameColumn(
                name: "showAsIncomingReceipt",
                table: "ReceiptsTable",
                newName: "IncomingReceipt");

            migrationBuilder.RenameColumn(
                name: "WorkerName",
                table: "ReceiptsTable",
                newName: "PersonName");

            migrationBuilder.RenameColumn(
                name: "DateAndTimeCreated",
                table: "ReceiptsTable",
                newName: "Outgoing");

            migrationBuilder.AddColumn<DateTime>(
                name: "Incoming",
                table: "ReceiptsTable",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReceiptProductId",
                table: "ReceiptsTable",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ReceiptsTable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Incoming", "Outgoing", "ReceiptProductId" },
                values: new object[] { new DateTime(2025, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), null, 3 });

            migrationBuilder.UpdateData(
                table: "ReceiptsTable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Incoming", "Outgoing", "ReceiptProductId" },
                values: new object[] { new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), null, 2 });

            migrationBuilder.UpdateData(
                table: "ReceiptsTable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Incoming", "Outgoing", "ReceiptProductId" },
                values: new object[] { new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), null, 7 });

            migrationBuilder.UpdateData(
                table: "ReceiptsTable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Incoming", "Outgoing", "ReceiptProductId" },
                values: new object[] { new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), null, 10 });

            migrationBuilder.UpdateData(
                table: "ReceiptsTable",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Incoming", "Outgoing", "ReceiptProductId" },
                values: new object[] { new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), null, 17 });

            migrationBuilder.UpdateData(
                table: "ReceiptsTable",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Incoming", "ReceiptProductId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "ReceiptsTable",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Incoming", "ReceiptProductId" },
                values: new object[] { null, 13 });

            migrationBuilder.UpdateData(
                table: "ReceiptsTable",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Incoming", "ReceiptProductId" },
                values: new object[] { null, 20 });

            migrationBuilder.UpdateData(
                table: "ReceiptsTable",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Incoming", "Outgoing", "ReceiptProductId" },
                values: new object[] { new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Local), null, 5 });

            migrationBuilder.UpdateData(
                table: "ReceiptsTable",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Incoming", "Outgoing", "ReceiptProductId" },
                values: new object[] { new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local), null, 12 });
        }
    }
}
