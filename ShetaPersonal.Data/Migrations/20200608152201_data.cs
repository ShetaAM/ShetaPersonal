using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShetaPersonal.Data.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 200, nullable: false),
                    Password = table.Column<string>(maxLength: 200, nullable: false),
                    FName = table.Column<string>(maxLength: 200, nullable: false),
                    LName = table.Column<string>(maxLength: 200, nullable: false),
                    BirthDay = table.Column<DateTime>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Daneshes",
                columns: table => new
                {
                    DId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    DaneshName = table.Column<string>(nullable: false),
                    AboutUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Daneshes", x => x.DId);
                    table.ForeignKey(
                        name: "FK_Daneshes_Abouts_AboutUserId",
                        column: x => x.AboutUserId,
                        principalTable: "Abouts",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Maharats",
                columns: table => new
                {
                    MId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Persent = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    AboutUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maharats", x => x.MId);
                    table.ForeignKey(
                        name: "FK_Maharats_Abouts_AboutUserId",
                        column: x => x.AboutUserId,
                        principalTable: "Abouts",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rezomes",
                columns: table => new
                {
                    RezomeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    RezomeTitle = table.Column<string>(maxLength: 200, nullable: false),
                    RezomeImage = table.Column<string>(maxLength: 200, nullable: true),
                    RezomeLink = table.Column<string>(maxLength: 200, nullable: true),
                    AboutUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezomes", x => x.RezomeId);
                    table.ForeignKey(
                        name: "FK_Rezomes_Abouts_AboutUserId",
                        column: x => x.AboutUserId,
                        principalTable: "Abouts",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sabeghes",
                columns: table => new
                {
                    SId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Stitle = table.Column<string>(maxLength: 200, nullable: false),
                    StartTime = table.Column<string>(nullable: false),
                    EndTime = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Icon = table.Column<string>(nullable: true),
                    AboutUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sabeghes", x => x.SId);
                    table.ForeignKey(
                        name: "FK_Sabeghes_Abouts_AboutUserId",
                        column: x => x.AboutUserId,
                        principalTable: "Abouts",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Socials",
                columns: table => new
                {
                    SociaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    SocialName = table.Column<string>(maxLength: 200, nullable: false),
                    SocialIcon = table.Column<string>(maxLength: 200, nullable: true),
                    SocialLink = table.Column<string>(maxLength: 200, nullable: true),
                    AboutUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socials", x => x.SociaId);
                    table.ForeignKey(
                        name: "FK_Socials_Abouts_AboutUserId",
                        column: x => x.AboutUserId,
                        principalTable: "Abouts",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tahsilats",
                columns: table => new
                {
                    TahsilatId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Daneshgah = table.Column<string>(maxLength: 200, nullable: false),
                    Reshte = table.Column<string>(maxLength: 200, nullable: false),
                    gerayesh = table.Column<string>(maxLength: 200, nullable: false),
                    StartTime = table.Column<string>(nullable: false),
                    EndTime = table.Column<string>(nullable: false),
                    AboutUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tahsilats", x => x.TahsilatId);
                    table.ForeignKey(
                        name: "FK_Tahsilats_Abouts_AboutUserId",
                        column: x => x.AboutUserId,
                        principalTable: "Abouts",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Takhasoses",
                columns: table => new
                {
                    TakhasosId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    AboutUserId = table.Column<int>(nullable: true)
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

            migrationBuilder.CreateTable(
                name: "TamasHas",
                columns: table => new
                {
                    TamasId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    name = table.Column<string>(maxLength: 200, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(maxLength: 11, nullable: false),
                    Massage = table.Column<string>(nullable: false),
                    AboutUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TamasHas", x => x.TamasId);
                    table.ForeignKey(
                        name: "FK_TamasHas_Abouts_AboutUserId",
                        column: x => x.AboutUserId,
                        principalTable: "Abouts",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rezomedetails",
                columns: table => new
                {
                    DetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RezomeId = table.Column<int>(nullable: false),
                    DetailCaption = table.Column<string>(maxLength: 200, nullable: false),
                    DetailValue = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezomedetails", x => x.DetailId);
                    table.ForeignKey(
                        name: "FK_Rezomedetails_Rezomes_RezomeId",
                        column: x => x.RezomeId,
                        principalTable: "Rezomes",
                        principalColumn: "RezomeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Daneshes_AboutUserId",
                table: "Daneshes",
                column: "AboutUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Maharats_AboutUserId",
                table: "Maharats",
                column: "AboutUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezomedetails_RezomeId",
                table: "Rezomedetails",
                column: "RezomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezomes_AboutUserId",
                table: "Rezomes",
                column: "AboutUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sabeghes_AboutUserId",
                table: "Sabeghes",
                column: "AboutUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Socials_AboutUserId",
                table: "Socials",
                column: "AboutUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tahsilats_AboutUserId",
                table: "Tahsilats",
                column: "AboutUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Takhasoses_AboutUserId",
                table: "Takhasoses",
                column: "AboutUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TamasHas_AboutUserId",
                table: "TamasHas",
                column: "AboutUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Daneshes");

            migrationBuilder.DropTable(
                name: "Maharats");

            migrationBuilder.DropTable(
                name: "Rezomedetails");

            migrationBuilder.DropTable(
                name: "Sabeghes");

            migrationBuilder.DropTable(
                name: "Socials");

            migrationBuilder.DropTable(
                name: "Tahsilats");

            migrationBuilder.DropTable(
                name: "Takhasoses");

            migrationBuilder.DropTable(
                name: "TamasHas");

            migrationBuilder.DropTable(
                name: "Rezomes");

            migrationBuilder.DropTable(
                name: "Abouts");
        }
    }
}
