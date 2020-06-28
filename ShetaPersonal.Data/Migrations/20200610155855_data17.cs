using Microsoft.EntityFrameworkCore.Migrations;

namespace ShetaPersonal.Data.Migrations
{
    public partial class data17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Galleries_Rezomes_RezomeId",
                table: "Galleries");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Galleries");

            migrationBuilder.AlterColumn<int>(
                name: "RezomeId",
                table: "Galleries",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Galleries_Rezomes_RezomeId",
                table: "Galleries",
                column: "RezomeId",
                principalTable: "Rezomes",
                principalColumn: "RezomeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Galleries_Rezomes_RezomeId",
                table: "Galleries");

            migrationBuilder.AlterColumn<int>(
                name: "RezomeId",
                table: "Galleries",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Galleries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Galleries_Rezomes_RezomeId",
                table: "Galleries",
                column: "RezomeId",
                principalTable: "Rezomes",
                principalColumn: "RezomeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
