using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RS1_Faktura.Migrations
{
    public partial class PonudaUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AkcijskiKatalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pocetak = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kraj = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkcijskiKatalog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Klijent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImePrezime = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klijent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proizvod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cijena = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvod", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faktura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KlijentId = table.Column<int>(type: "int", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faktura", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Faktura_Klijent_KlijentId",
                        column: x => x.KlijentId,
                        principalTable: "Klijent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KatalogStavka",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProizvodId = table.Column<int>(type: "int", nullable: false),
                    AkcijskiKatalogId = table.Column<int>(type: "int", nullable: false),
                    PopustProcenat = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KatalogStavka", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KatalogStavka_AkcijskiKatalog_AkcijskiKatalogId",
                        column: x => x.AkcijskiKatalogId,
                        principalTable: "AkcijskiKatalog",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KatalogStavka_Proizvod_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FakturaStavka",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProizvodId = table.Column<int>(type: "int", nullable: false),
                    FakturaId = table.Column<int>(type: "int", nullable: false),
                    Kolicina = table.Column<float>(type: "real", nullable: false),
                    PopustProcenat = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FakturaStavka", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FakturaStavka_Faktura_FakturaId",
                        column: x => x.FakturaId,
                        principalTable: "Faktura",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FakturaStavka_Proizvod_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ponuda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KlijentId = table.Column<int>(type: "int", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FakturaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ponuda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ponuda_Faktura_FakturaID",
                        column: x => x.FakturaID,
                        principalTable: "Faktura",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ponuda_Klijent_KlijentId",
                        column: x => x.KlijentId,
                        principalTable: "Klijent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PonudaStavka",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProizvodId = table.Column<int>(type: "int", nullable: false),
                    PonudaId = table.Column<int>(type: "int", nullable: false),
                    Kolicina = table.Column<float>(type: "real", nullable: false),
                    PopustProcenat = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PonudaStavka", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PonudaStavka_Ponuda_PonudaId",
                        column: x => x.PonudaId,
                        principalTable: "Ponuda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PonudaStavka_Proizvod_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Faktura_KlijentId",
                table: "Faktura",
                column: "KlijentId");

            migrationBuilder.CreateIndex(
                name: "IX_FakturaStavka_FakturaId",
                table: "FakturaStavka",
                column: "FakturaId");

            migrationBuilder.CreateIndex(
                name: "IX_FakturaStavka_ProizvodId",
                table: "FakturaStavka",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_KatalogStavka_AkcijskiKatalogId",
                table: "KatalogStavka",
                column: "AkcijskiKatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_KatalogStavka_ProizvodId",
                table: "KatalogStavka",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Ponuda_FakturaID",
                table: "Ponuda",
                column: "FakturaID");

            migrationBuilder.CreateIndex(
                name: "IX_Ponuda_KlijentId",
                table: "Ponuda",
                column: "KlijentId");

            migrationBuilder.CreateIndex(
                name: "IX_PonudaStavka_PonudaId",
                table: "PonudaStavka",
                column: "PonudaId");

            migrationBuilder.CreateIndex(
                name: "IX_PonudaStavka_ProizvodId",
                table: "PonudaStavka",
                column: "ProizvodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FakturaStavka");

            migrationBuilder.DropTable(
                name: "KatalogStavka");

            migrationBuilder.DropTable(
                name: "PonudaStavka");

            migrationBuilder.DropTable(
                name: "AkcijskiKatalog");

            migrationBuilder.DropTable(
                name: "Ponuda");

            migrationBuilder.DropTable(
                name: "Proizvod");

            migrationBuilder.DropTable(
                name: "Faktura");

            migrationBuilder.DropTable(
                name: "Klijent");
        }
    }
}
