using Microsoft.EntityFrameworkCore.Migrations;

namespace ShetaPersonal.Data.Migrations
{
    public partial class data16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Galleries_Abouts_AboutUserId",
                table: "Galleries");

            migrationBuilder.DropTable(
                name: "Takhasoses");

            migrationBuilder.DropIndex(
                name: "IX_Galleries_AboutUserId",
                table: "Galleries");

            migrationBuilder.DropColumn(
                name: "AboutUserId",
                table: "Galleries");

            migrationBuilder.AddColumn<int>(
                name: "RezomeId",
                table: "Galleries",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Galleries_RezomeId",
                table: "Galleries",
                column: "RezomeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Galleries_Rezomes_RezomeId",
                table: "Galleries",
                column: "RezomeId",
                principalTable: "Rezomes",
                principalColumn: "RezomeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Galleries_Rezomes_RezomeId",
                table: "Galleries");

            migrationBuilder.DropIndex(
                name: "IX_Galleries_RezomeId",
                table: "Galleries");

            migrationBuilder.DropColumn(
                name: "RezomeId",
                table: "Galleries");

            migrationBuilder.AddColumn<int>(
                name: "AboutUserId",
                table: "Galleries",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Takhasoses",
                columns: table => new
                {
                    TakhasosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutUserId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Takhasoses", x => x.TakhasosId);
                    table.ForeignKey(
                        name: "FK_Takhasoses_Abouts_AboutUserId",
                        column: x => x.AboutUserId,
                        principalTable: "Abouts",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Galleries_AboutUserId",
                table: "Galleries",
                column: "AboutUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Takhasoses_AboutUserId",
                table: "Takhasoses",
                column: "AboutUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Galleries_Abouts_AboutUserId",
                table: "Galleries",
                column: "AboutUserId",
                principalTable: "Abouts",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
