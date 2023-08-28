using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JoyeríaDALA.Migrations
{
    /// <inheritdoc />
    public partial class Finale1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "cantidad",
                table: "ProductosVenta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "descuento",
                table: "ProductosVenta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "nombre",
                table: "ProductosVenta",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "precioTotal",
                table: "ProductosVenta",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "precioUnidad",
                table: "ProductosVenta",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cantidad",
                table: "ProductosVenta");

            migrationBuilder.DropColumn(
                name: "descuento",
                table: "ProductosVenta");

            migrationBuilder.DropColumn(
                name: "nombre",
                table: "ProductosVenta");

            migrationBuilder.DropColumn(
                name: "precioTotal",
                table: "ProductosVenta");

            migrationBuilder.DropColumn(
                name: "precioUnidad",
                table: "ProductosVenta");
        }
    }
}
