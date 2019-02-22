using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CardinalDeadStockWebApi.Data.Migrations
{
    public partial class dbm003 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationUserDesiredShoes",
                columns: table => new
                {
                    ApplicationUserDesiredShoesId = table.Column<Guid>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    DesiredShoeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserDesiredShoes", x => x.ApplicationUserDesiredShoesId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserDesiredShoes");
        }
    }
}
