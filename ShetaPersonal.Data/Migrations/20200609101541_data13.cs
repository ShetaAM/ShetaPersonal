using Microsoft.EntityFrameworkCore.Migrations;

namespace ShetaPersonal.Data.Migrations
{
    public partial class data13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RezomeId",
                table: "Vaziyats");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RezomeId",
                table: "Vaziyats",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
