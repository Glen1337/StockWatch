using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockWatch.Data.Migrations
{
    public partial class refertoportofliofromtrade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Portfolios",
                keyColumn: "PortfolioId",
                keyValue: 1L,
                column: "UserId",
                value: "53ab1a2c-b170-4232-9958-a1266114803c");

            migrationBuilder.InsertData(
                table: "Portfolios",
                columns: new[] { "PortfolioId", "Title", "TotalValue", "UserId" },
                values: new object[] { 2L, "Glen's Portfolio 1", 0m, "9722240c-3e76-4150-b241-70770531c119" });

            migrationBuilder.UpdateData(
                table: "Trades",
                keyColumn: "TradeId",
                keyValue: 1L,
                column: "Price",
                value: 67.24m);

            migrationBuilder.UpdateData(
                table: "Trades",
                keyColumn: "TradeId",
                keyValue: 2L,
                column: "Price",
                value: 27.67m);

            migrationBuilder.UpdateData(
                table: "Trades",
                keyColumn: "TradeId",
                keyValue: 3L,
                column: "PortfolioId",
                value: 2L);

            migrationBuilder.InsertData(
                table: "Trades",
                columns: new[] { "TradeId", "Action", "PortfolioId", "Price", "Quantity", "Symbol", "TransactionStamp", "Type" },
                values: new object[] { 4L, "Sell", 2L, 77.03m, 2m, "AMD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stock" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trades",
                keyColumn: "TradeId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Trades",
                keyColumn: "TradeId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Portfolios",
                keyColumn: "PortfolioId",
                keyValue: 2L);

            migrationBuilder.UpdateData(
                table: "Portfolios",
                keyColumn: "PortfolioId",
                keyValue: 1L,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trades",
                keyColumn: "TradeId",
                keyValue: 1L,
                column: "Price",
                value: 67.38m);

            migrationBuilder.UpdateData(
                table: "Trades",
                keyColumn: "TradeId",
                keyValue: 2L,
                column: "Price",
                value: 27.38m);

            migrationBuilder.InsertData(
                table: "Trades",
                columns: new[] { "TradeId", "Action", "PortfolioId", "Price", "Quantity", "Symbol", "TransactionStamp", "Type" },
                values: new object[] { 3L, "Buy", 1L, 1027.38m, 2m, "CMG", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stock" });
        }
    }
}
