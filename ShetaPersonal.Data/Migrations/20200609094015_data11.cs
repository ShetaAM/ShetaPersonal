using Microsoft.EntityFrameworkCore.Migrations;

namespace ShetaPersonal.Data.Migrations
{
    public partial class data11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VaziyatRezomes",
                columns: table => new
                {
                    VaziyatId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RezomeId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VaziyatRezomes");
        }
    }
}
