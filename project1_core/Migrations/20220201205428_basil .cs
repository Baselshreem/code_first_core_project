using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace project1_core.Migrations
{
    public partial class basil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "catogris",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_catogris", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "countactus",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    massage = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    subj = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countactus", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "temnmmbers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    joptitle = table.Column<string>(nullable: true),
                    img = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_temnmmbers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    img = table.Column<string>(nullable: true),
                    topic = table.Column<string>(nullable: true),
                    catogriid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.id);
                    table.ForeignKey(
                        name: "FK_News_catogris_catogriid",
                        column: x => x.catogriid,
                        principalTable: "catogris",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_News_catogriid",
                table: "News",
                column: "catogriid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "countactus");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "temnmmbers");

            migrationBuilder.DropTable(
                name: "catogris");
        }
    }
}
