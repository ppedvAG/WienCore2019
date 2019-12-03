using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WienCore2019.Migrations
{
    public partial class hannes1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rechnung",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KundenID = table.Column<int>(nullable: true),
                    Datum = table.Column<DateTime>(type: "date", nullable: true),
                    Summe = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rechnung", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positionen",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RechnungID = table.Column<int>(nullable: false),
                    Anzahl = table.Column<int>(nullable: true),
                    Text = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Preis = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positionen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Positionen_Rechnung_RechnungID",
                        column: x => x.RechnungID,
                        principalTable: "Rechnung",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Positionen_RechnungID",
                table: "Positionen",
                column: "RechnungID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Positionen");

            migrationBuilder.DropTable(
                name: "Rechnung");
        }
    }
}
