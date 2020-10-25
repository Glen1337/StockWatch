using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockWatch.Data.Migrations
{
    public partial class addseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Symbol",
                table: "Trades",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Portfolios",
                columns: new[] { "PortfolioId", "ApplicationUserId", "Title", "TotalValue" },
                values: new object[] { 1L, null, "Glen's Portfolio 1", 0m });

            migrationBuilder.InsertData(
                table: "Trades",
                columns: new[] { "TradeId", "Action", "PortfolioId", "Price", "Quantity", "Symbol", "TransactionStamp", "Type" },
                values: new object[] { 1L, "Sell", 1L, 67.38m, 12m, "FSLR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stock" });

            migrationBuilder.InsertData(
                table: "Trades",
                columns: new[] { "TradeId", "Action", "PortfolioId", "Price", "Quantity", "Symbol", "TransactionStamp", "Type" },
                values: new object[] { 2L, "Buy", 1L, 27.38m, 612m, "SNAP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stock" });

            migrationBuilder.InsertData(
                table: "Trades",
                columns: new[] { "TradeId", "Action", "PortfolioId", "Price", "Quantity", "Symbol", "TransactionStamp", "Type" },
                values: new object[] { 3L, "Buy", 1L, 1027.38m, 2m, "CMG", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stock" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trades",
                keyColumn: "TradeId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Trades",
                keyColumn: "TradeId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Trades",
                keyColumn: "TradeId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Portfolios",
                keyColumn: "PortfolioId",
                keyValue: 1L);

            migrationBuilder.AlterColumn<string>(
                name: "Symbol",
                table: "Trades",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
