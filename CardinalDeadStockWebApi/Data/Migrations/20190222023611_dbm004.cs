using Microsoft.EntityFrameworkCore.Migrations;

namespace CardinalDeadStockWebApi.Data.Migrations
{
    public partial class dbm004 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "ApplicationUserDesiredShoes",
                newName: "IdentityUserId");

            migrationBuilder.AlterColumn<string>(
                name: "IdentityUserId",
                table: "ApplicationUserDesiredShoes",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserDesiredShoes_DesiredShoeId",
                table: "ApplicationUserDesiredShoes",
                column: "DesiredShoeId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserDesiredShoes_IdentityUserId",
                table: "ApplicationUserDesiredShoes",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserDesiredShoes_DesiredShoes_DesiredShoeId",
                table: "ApplicationUserDesiredShoes",
                column: "DesiredShoeId",
                principalTable: "DesiredShoes",
                principalColumn: "DesiredShoeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserDesiredShoes_AspNetUsers_IdentityUserId",
                table: "ApplicationUserDesiredShoes",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserDesiredShoes_DesiredShoes_DesiredShoeId",
                table: "ApplicationUserDesiredShoes");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserDesiredShoes_AspNetUsers_IdentityUserId",
                table: "ApplicationUserDesiredShoes");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUserDesiredShoes_DesiredShoeId",
                table: "ApplicationUserDesiredShoes");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUserDesiredShoes_IdentityUserId",
                table: "ApplicationUserDesiredShoes");

            migrationBuilder.RenameColumn(
                name: "IdentityUserId",
                table: "ApplicationUserDesiredShoes",
                newName: "ApplicationUserId");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "ApplicationUserDesiredShoes",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
