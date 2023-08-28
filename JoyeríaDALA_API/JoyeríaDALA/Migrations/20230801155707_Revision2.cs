using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JoyeríaDALA.Migrations
{
    /// <inheritdoc />
    public partial class Revision2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "tipoUsuario",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "IdAsociado",
                table: "Notificacion",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tipoUsuario",
                table: "Usuario");

            migrationBuilder.AlterColumn<string>(
                name: "IdAsociado",
                table: "Notificacion",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
