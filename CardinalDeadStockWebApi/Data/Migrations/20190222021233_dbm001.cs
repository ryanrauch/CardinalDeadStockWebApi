using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CardinalDeadStockWebApi.Data.Migrations
{
    public partial class dbm001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DesiredShoes",
                columns: table => new
                {
                    DesiredShoeId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    URL = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    ShoeType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesiredShoes", x => x.DesiredShoeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DesiredShoes");
        }
    }
}
