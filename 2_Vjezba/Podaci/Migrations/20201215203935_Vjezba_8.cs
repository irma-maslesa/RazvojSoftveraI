using Microsoft.EntityFrameworkCore.Migrations;

namespace _2_Vjezba.Migrations
{
    public partial class Vjezba_8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPrisutan",
                table: "PrisustvoNastavi",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Komentar",
                table: "PrisustvoNastavi",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPrisutan",
                table: "PrisustvoNastavi");

            migrationBuilder.DropColumn(
                name: "Komentar",
                table: "PrisustvoNastavi");
        }
    }
}
