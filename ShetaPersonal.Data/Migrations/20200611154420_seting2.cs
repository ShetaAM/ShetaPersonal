using Microsoft.EntityFrameworkCore.Migrations;

namespace ShetaPersonal.Data.Migrations
{
    public partial class seting2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    SettingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteIsActive = table.Column<bool>(maxLength: 200, nullable: false),
                    NotActiveMassage = table.Column<string>(maxLength: 200, nullable: true),
                    NotActiveImage = table.Column<string>(maxLength: 200, nullable: true),
                    SiteName = table.Column<string>(maxLength: 200, nullable: false),
                    TagName = table.Column<string>(maxLength: 200, nullable: false),
                    SiteIcon = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.SettingId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");
        }
    }
}
