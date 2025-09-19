using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Formula.Migrations
{
    /// <inheritdoc />
    public partial class InitalCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sponzori",
                columns: table => new
                {
                    sponzorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    naziv = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sponzori", x => x.sponzorId);
                });

            migrationBuilder.CreateTable(
                name: "Timovi",
                columns: table => new
                {
                    timId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazivTima = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timovi", x => x.timId);
                });

            migrationBuilder.CreateTable(
                name: "Trke",
                columns: table => new
                {
                    trkaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    datumTrke = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trke", x => x.trkaId);
                });

            migrationBuilder.CreateTable(
                name: "Vozaci",
                columns: table => new
                {
                    vozacId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nacionalnost = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    brojVozaca = table.Column<int>(type: "int", nullable: false),
                    datumRodjenja = table.Column<DateOnly>(type: "date", nullable: false),
                    tim = table.Column<int>(type: "int", nullable: false),
                    timId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozaci", x => x.vozacId);
                    table.ForeignKey(
                        name: "FK_Vozaci_Timovi_timId",
                        column: x => x.timId,
                        principalTable: "Timovi",
                        principalColumn: "timId");
                });

            migrationBuilder.CreateTable(
                name: "Staze",
                columns: table => new
                {
                    stazaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazivStaze = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duzina = table.Column<float>(type: "real", nullable: false),
                    trke = table.Column<int>(type: "int", nullable: false),
                    TrketrkaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staze", x => x.stazaId);
                    table.ForeignKey(
                        name: "FK_Staze_Trke_TrketrkaId",
                        column: x => x.TrketrkaId,
                        principalTable: "Trke",
                        principalColumn: "trkaId");
                });

            migrationBuilder.CreateTable(
                name: "Rezultati",
                columns: table => new
                {
                    rezultatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vozacId = table.Column<int>(type: "int", nullable: false),
                    trkaId = table.Column<int>(type: "int", nullable: false),
                    trketrkaId = table.Column<int>(type: "int", nullable: false),
                    poeni = table.Column<int>(type: "int", nullable: false),
                    datum = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezultati", x => x.rezultatId);
                    table.ForeignKey(
                        name: "FK_Rezultati_Trke_trketrkaId",
                        column: x => x.trketrkaId,
                        principalTable: "Trke",
                        principalColumn: "trkaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rezultati_Vozaci_vozacId",
                        column: x => x.vozacId,
                        principalTable: "Vozaci",
                        principalColumn: "vozacId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SponzoriVozac",
                columns: table => new
                {
                    sponzorId = table.Column<int>(type: "int", nullable: false),
                    vozacId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SponzoriVozac", x => new { x.sponzorId, x.vozacId });
                    table.ForeignKey(
                        name: "FK_SponzoriVozac_Sponzori_sponzorId",
                        column: x => x.sponzorId,
                        principalTable: "Sponzori",
                        principalColumn: "sponzorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SponzoriVozac_Vozaci_vozacId",
                        column: x => x.vozacId,
                        principalTable: "Vozaci",
                        principalColumn: "vozacId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rezultati_trketrkaId",
                table: "Rezultati",
                column: "trketrkaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezultati_vozacId",
                table: "Rezultati",
                column: "vozacId");

            migrationBuilder.CreateIndex(
                name: "IX_SponzoriVozac_vozacId",
                table: "SponzoriVozac",
                column: "vozacId");

            migrationBuilder.CreateIndex(
                name: "IX_Staze_TrketrkaId",
                table: "Staze",
                column: "TrketrkaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vozaci_timId",
                table: "Vozaci",
                column: "timId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rezultati");

            migrationBuilder.DropTable(
                name: "SponzoriVozac");

            migrationBuilder.DropTable(
                name: "Staze");

            migrationBuilder.DropTable(
                name: "Sponzori");

            migrationBuilder.DropTable(
                name: "Vozaci");

            migrationBuilder.DropTable(
                name: "Trke");

            migrationBuilder.DropTable(
                name: "Timovi");
        }
    }
}
