using Microsoft.EntityFrameworkCore.Migrations;

namespace StockWatch.Data.Migrations
{
    public partial class fixes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trades_Portfolios_PortfolioID",
                table: "Trades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trades",
                table: "Trades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Portfolios",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Trades");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Portfolios");

            migrationBuilder.RenameColumn(
                name: "PortfolioID",
                table: "Trades",
                newName: "PortfolioId");

            migrationBuilder.RenameIndex(
                name: "IX_Trades_PortfolioID",
                table: "Trades",
                newName: "IX_Trades_PortfolioId");

            migrationBuilder.AlterColumn<long>(
                name: "PortfolioId",
                table: "Trades",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TradeId",
                table: "Trades",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "PortfolioId",
                table: "Portfolios",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trades",
                table: "Trades",
                column: "TradeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Portfolios",
                table: "Portfolios",
                column: "PortfolioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trades_Portfolios_PortfolioId",
                table: "Trades",
                column: "PortfolioId",
                principalTable: "Portfolios",
                principalColumn: "PortfolioId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trades_Portfolios_PortfolioId",
                table: "Trades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trades",
                table: "Trades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Portfolios",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "TradeId",
                table: "Trades");

            migrationBuilder.DropColumn(
                name: "PortfolioId",
                table: "Portfolios");

            migrationBuilder.RenameColumn(
                name: "PortfolioId",
                table: "Trades",
                newName: "PortfolioID");

            migrationBuilder.RenameIndex(
                name: "IX_Trades_PortfolioId",
                table: "Trades",
                newName: "IX_Trades_PortfolioID");

            migrationBuilder.AlterColumn<long>(
                name: "PortfolioID",
                table: "Trades",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<long>(
                name: "ID",
                table: "Trades",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "ID",
                table: "Portfolios",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trades",
                table: "Trades",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Portfolios",
                table: "Portfolios",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Trades_Portfolios_PortfolioID",
                table: "Trades",
                column: "PortfolioID",
                principalTable: "Portfolios",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
