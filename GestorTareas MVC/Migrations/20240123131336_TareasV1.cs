using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestorTareas_MVC.Migrations
{
    /// <inheritdoc />
    public partial class TareasV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Completada",
                table: "Tareas",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Completada",
                table: "Tareas");
        }
    }
}
