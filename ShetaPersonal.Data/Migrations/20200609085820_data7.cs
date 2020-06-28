using Microsoft.EntityFrameworkCore.Migrations;

namespace ShetaPersonal.Data.Migrations
{
    public partial class data7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Maharats");

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Daneshes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tozihat",
                table: "Daneshes",
                maxLength: 200,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Daneshes");

            migrationBuilder.DropColumn(
                name: "Tozihat",
                table: "Daneshes");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Maharats",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
