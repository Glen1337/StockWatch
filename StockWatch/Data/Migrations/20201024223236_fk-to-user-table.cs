using Microsoft.EntityFrameworkCore.Migrations;

namespace StockWatch.Data.Migrations
{
    public partial class fktousertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_AspNetUsers_ApplicationUserId",
                table: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_ApplicationUserId",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Portfolios");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Portfolios",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_UserId",
                table: "Portfolios",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_AspNetUsers_UserId",
                table: "Portfolios",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_AspNetUsers_UserId",
                table: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_UserId",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Portfolios");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Portfolios",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_ApplicationUserId",
                table: "Portfolios",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_AspNetUsers_ApplicationUserId",
                table: "Portfolios",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
