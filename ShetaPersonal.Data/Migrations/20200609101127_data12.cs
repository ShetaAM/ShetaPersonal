using Microsoft.EntityFrameworkCore.Migrations;

namespace ShetaPersonal.Data.Migrations
{
    public partial class data12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VaziyatRezomes");

            migrationBuilder.DropColumn(
                name: "vazeiyat",
                table: "Rezomes");

            migrationBuilder.AddColumn<int>(
                name: "RezomeVaziyatRVId",
                table: "Rezomes",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RezomeVaziyats",
                columns: table => new
                {
                    RVId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RezomeId = table.Column<int>(nullable: false),
                    VaziyatId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RezomeVaziyats", x => x.RVId);
                });

            migrationBuilder.CreateTable(
                name: "Vaziyats",
                columns: table => new
                {
                    VaziyatId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RezomeId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    RezomeVaziyatRVId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaziyats", x => x.VaziyatId);
                    table.ForeignKey(
                        name: "FK_Vaziyats_RezomeVaziyats_RezomeVaziyatRVId",
                        column: x => x.RezomeVaziyatRVId,
                        principalTable: "RezomeVaziyats",
                        principalColumn: "RVId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rezomes_RezomeVaziyatRVId",
                table: "Rezomes",
                column: "RezomeVaziyatRVId");

            migrationBuilder.CreateIndex(
                name: "IX_Vaziyats_RezomeVaziyatRVId",
                table: "Vaziyats",
                column: "RezomeVaziyatRVId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezomes_RezomeVaziyats_RezomeVaziyatRVId",
                table: "Rezomes",
                column: "RezomeVaziyatRVId",
                principalTable: "RezomeVaziyats",
                principalColumn: "RVId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezomes_RezomeVaziyats_RezomeVaziyatRVId",
                table: "Rezomes");

            migrationBuilder.DropTable(
                name: "Vaziyats");

            migrationBuilder.DropTable(
                name: "RezomeVaziyats");

            migrationBuilder.DropIndex(
                name: "IX_Rezomes_RezomeVaziyatRVId",
                table: "Rezomes");

            migrationBuilder.DropColumn(
                name: "RezomeVaziyatRVId",
                table: "Rezomes");

            migrationBuilder.AddColumn<string>(
                name: "vazeiyat",
                table: "Rezomes",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "VaziyatRezomes",
                columns: table => new
                {
                    VaziyatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RezomeId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaziyatRezomes", x => x.VaziyatId);
                    table.ForeignKey(
                        name: "FK_VaziyatRezomes_Rezomes_RezomeId",
                        column: x => x.RezomeId,
                        principalTable: "Rezomes",
                        principalColumn: "RezomeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VaziyatRezomes_RezomeId",
                table: "VaziyatRezomes",
                column: "RezomeId");
        }
    }
}
