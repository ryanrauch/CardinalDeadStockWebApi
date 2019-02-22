using Microsoft.EntityFrameworkCore.Migrations;

namespace CardinalDeadStockWebApi.Data.Migrations
{
    public partial class dbm005 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerID",
                table: "DesiredShoes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "DesiredShoes");
        }
    }
}
