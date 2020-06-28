using Microsoft.EntityFrameworkCore.Migrations;

namespace ShetaPersonal.Data.Migrations
{
    public partial class data10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RezomeTecses",
                columns: table => new
                {
                    RTId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RezomeId = table.Column<int>(nullable: false),
                    TecTitle = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RezomeTecses", x => x.RTId);
                    table.ForeignKey(
                        name: "FK_RezomeTecses_Rezomes_RezomeId",
                        column: x => x.RezomeId,
                        principalTable: "Rezomes",
                        principalColumn: "RezomeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RezomeTecses_RezomeId",
                table: "RezomeTecses",
                column: "RezomeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RezomeTecses");
        }
    }
}
