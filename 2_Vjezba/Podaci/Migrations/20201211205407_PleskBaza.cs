using Microsoft.EntityFrameworkCore.Migrations;

namespace _2_Vjezba.Migrations
{
    public partial class PleskBaza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Opcina",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opcina", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojIndeksa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpcinaRodjenjaID = table.Column<int>(type: "int", nullable: false),
                    OpcinaPrebivalistaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Student_Opcina_OpcinaPrebivalistaID",
                        column: x => x.OpcinaPrebivalistaID,
                        principalTable: "Opcina",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Student_Opcina_OpcinaRodjenjaID",
                        column: x => x.OpcinaRodjenjaID,
                        principalTable: "Opcina",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_OpcinaPrebivalistaID",
                table: "Student",
                column: "OpcinaPrebivalistaID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_OpcinaRodjenjaID",
                table: "Student",
                column: "OpcinaRodjenjaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Opcina");
        }
    }
}
