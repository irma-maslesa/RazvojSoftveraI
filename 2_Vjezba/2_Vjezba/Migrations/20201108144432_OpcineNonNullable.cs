using Microsoft.EntityFrameworkCore.Migrations;

namespace _2_Vjezba.Migrations
{
    public partial class OpcineNonNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Opcina_OpcinaPrebivalistaID",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Opcina_OpcinaRodjenjaID",
                table: "Student");

            migrationBuilder.AlterColumn<int>(
                name: "OpcinaRodjenjaID",
                table: "Student",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OpcinaPrebivalistaID",
                table: "Student",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Opcina_OpcinaPrebivalistaID",
                table: "Student",
                column: "OpcinaPrebivalistaID",
                principalTable: "Opcina",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Opcina_OpcinaRodjenjaID",
                table: "Student",
                column: "OpcinaRodjenjaID",
                principalTable: "Opcina",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Opcina_OpcinaPrebivalistaID",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Opcina_OpcinaRodjenjaID",
                table: "Student");

            migrationBuilder.AlterColumn<int>(
                name: "OpcinaRodjenjaID",
                table: "Student",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "OpcinaPrebivalistaID",
                table: "Student",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Opcina_OpcinaPrebivalistaID",
                table: "Student",
                column: "OpcinaPrebivalistaID",
                principalTable: "Opcina",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Opcina_OpcinaRodjenjaID",
                table: "Student",
                column: "OpcinaRodjenjaID",
                principalTable: "Opcina",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
