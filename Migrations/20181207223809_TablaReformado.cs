using Microsoft.EntityFrameworkCore.Migrations;

namespace PREPARAES.Migrations
{
    public partial class TablaReformado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "password",
                table: "Usuarios",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "Pregunta",
                table: "Preguntas",
                newName: "PreguntaString");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Usuarios",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "PreguntaString",
                table: "Preguntas",
                newName: "Pregunta");
        }
    }
}
