using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class osoba : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Osoba",
                columns: table => new
                {
                    Id_osoba = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Plec = table.Column<int>(type: "int", nullable: false),
                    Id_ojca = table.Column<int>(type: "int", nullable: true),
                    Id_matki = table.Column<int>(type: "int", nullable: true),
                    Rok_urodzenia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osoba", x => x.Id_osoba);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Osoba");
        }
    }
}
