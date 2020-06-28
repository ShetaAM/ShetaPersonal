using Microsoft.EntityFrameworkCore.Migrations;

namespace ShetaPersonal.Data.Migrations
{
    public partial class data20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezomes_RezomeVaziyats_RezomeVaziyatRVId",
                table: "Rezomes");

            migrationBuilder.DropForeignKey(
                name: "FK_Vaziyats_RezomeVaziyats_RezomeVaziyatRVId",
                table: "Vaziyats");

            migrationBuilder.DropTable(
                name: "RezomeVaziyats");

            migrationBuilder.DropIndex(
                name: "IX_Vaziyats_RezomeVaziyatRVId",
                table: "Vaziyats");

            migrationBuilder.DropIndex(
                name: "IX_Rezomes_RezomeVaziyatRVId",
                table: "Rezomes");

            migrationBuilder.DropColumn(
                name: "RezomeVaziyatRVId",
                table: "Vaziyats");

            migrationBuilder.DropColumn(
                name: "RezomeVaziyatRVId",
                table: "Rezomes");

            migrationBuilder.AddColumn<int>(
                name: "VaziyatId",
                table: "Rezomes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rezomes_VaziyatId",
                table: "Rezomes",
                column: "VaziyatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezomes_Vaziyats_VaziyatId",
                table: "Rezomes",
                column: "VaziyatId",
                principalTable: "Vaziyats",
                principalColumn: "VaziyatId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezomes_Vaziyats_VaziyatId",
                table: "Rezomes");

            migrationBuilder.DropIndex(
                name: "IX_Rezomes_VaziyatId",
                table: "Rezomes");

            migrationBuilder.DropColumn(
                name: "VaziyatId",
                table: "Rezomes");

            migrationBuilder.AddColumn<int>(
                name: "RezomeVaziyatRVId",
                table: "Vaziyats",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RezomeVaziyatRVId",
                table: "Rezomes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RezomeVaziyats",
                columns: table => new
                {
                    RVId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RezomeId = table.Column<int>(type: "int", nullable: false),
                    VaziyatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RezomeVaziyats", x => x.RVId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vaziyats_RezomeVaziyatRVId",
                table: "Vaziyats",
                column: "RezomeVaziyatRVId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezomes_RezomeVaziyatRVId",
                table: "Rezomes",
                column: "RezomeVaziyatRVId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezomes_RezomeVaziyats_RezomeVaziyatRVId",
                table: "Rezomes",
                column: "RezomeVaziyatRVId",
                principalTable: "RezomeVaziyats",
                principalColumn: "RVId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vaziyats_RezomeVaziyats_RezomeVaziyatRVId",
                table: "Vaziyats",
                column: "RezomeVaziyatRVId",
                principalTable: "RezomeVaziyats",
                principalColumn: "RVId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
