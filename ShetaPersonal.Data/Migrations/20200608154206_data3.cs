using Microsoft.EntityFrameworkCore.Migrations;

namespace ShetaPersonal.Data.Migrations
{
    public partial class data3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Galleries",
                columns: table => new
                {
                    GalleryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Gallerytitle = table.Column<string>(maxLength: 200, nullable: false),
                    Image = table.Column<string>(maxLength: 200, nullable: false),
                    AboutUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galleries", x => x.GalleryId);
                    table.ForeignKey(
                        name: "FK_Galleries_Abouts_AboutUserId",
                        column: x => x.AboutUserId,
                        principalTable: "Abouts",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Galleries_AboutUserId",
                table: "Galleries",
                column: "AboutUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Galleries");
        }
    }
}
