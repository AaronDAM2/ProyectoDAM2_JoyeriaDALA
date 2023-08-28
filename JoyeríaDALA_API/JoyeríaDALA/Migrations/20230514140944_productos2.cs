using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JoyeríaDALA.Migrations
{
    /// <inheritdoc />
    public partial class productos2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grabado_Producto_productoidProducto",
                table: "Grabado");

            migrationBuilder.DropIndex(
                name: "IX_Grabado_productoidProducto",
                table: "Grabado");

            migrationBuilder.RenameColumn(
                name: "productoidProducto",
                table: "Grabado",
                newName: "idProducto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "idProducto",
                table: "Grabado",
                newName: "productoidProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Grabado_productoidProducto",
                table: "Grabado",
                column: "productoidProducto");

            migrationBuilder.AddForeignKey(
                name: "FK_Grabado_Producto_productoidProducto",
                table: "Grabado",
                column: "productoidProducto",
                principalTable: "Producto",
                principalColumn: "idProducto");
        }
    }
}
