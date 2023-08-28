using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JoyeríaDALA.Migrations
{
    /// <inheritdoc />
    public partial class init0805_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdAsociado",
                table: "Factura",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TipoAsociado",
                table: "Factura",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "precioTotal",
                table: "Factura",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdAsociado",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "TipoAsociado",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "precioTotal",
                table: "Factura");
        }
    }
}
