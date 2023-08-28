using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JoyeríaDALA.Migrations
{
    /// <inheritdoc />
    public partial class GrabadosYEncargos1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grabado_Producto_productoidProducto",
                table: "Grabado");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Venta_VentaIdVenta",
                table: "Producto");

            migrationBuilder.DropForeignKey(
                name: "FK_TipoProducto_MarcasTipo_MarcasTipoIdMarca",
                table: "TipoProducto");

            migrationBuilder.DropIndex(
                name: "IX_TipoProducto_MarcasTipoIdMarca",
                table: "TipoProducto");

            migrationBuilder.DropIndex(
                name: "IX_Producto_VentaIdVenta",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Grabado_productoidProducto",
                table: "Grabado");

            migrationBuilder.DropColumn(
                name: "MarcasTipoIdMarca",
                table: "TipoProducto");

            migrationBuilder.DropColumn(
                name: "VentaIdVenta",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "productoidProducto",
                table: "Grabado");

            migrationBuilder.AddColumn<int>(
                name: "IdTipo",
                table: "MarcasTipo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idProducto",
                table: "Grabado",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ventaIdVenta",
                table: "Grabado",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idProducto",
                table: "Encargo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ProductosVenta",
                columns: table => new
                {
                    IdProdVenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdVenta = table.Column<int>(type: "int", nullable: false),
                    IdProducto = table.Column<int>(type: "int", nullable: false),
                    VentaIdVenta = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductosVenta", x => x.IdProdVenta);
                    table.ForeignKey(
                        name: "FK_ProductosVenta_Venta_VentaIdVenta",
                        column: x => x.VentaIdVenta,
                        principalTable: "Venta",
                        principalColumn: "IdVenta");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grabado_ventaIdVenta",
                table: "Grabado",
                column: "ventaIdVenta");

            migrationBuilder.CreateIndex(
                name: "IX_ProductosVenta_VentaIdVenta",
                table: "ProductosVenta",
                column: "VentaIdVenta");

            migrationBuilder.AddForeignKey(
                name: "FK_Grabado_Venta_ventaIdVenta",
                table: "Grabado",
                column: "ventaIdVenta",
                principalTable: "Venta",
                principalColumn: "IdVenta",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grabado_Venta_ventaIdVenta",
                table: "Grabado");

            migrationBuilder.DropTable(
                name: "ProductosVenta");

            migrationBuilder.DropIndex(
                name: "IX_Grabado_ventaIdVenta",
                table: "Grabado");

            migrationBuilder.DropColumn(
                name: "IdTipo",
                table: "MarcasTipo");

            migrationBuilder.DropColumn(
                name: "idProducto",
                table: "Grabado");

            migrationBuilder.DropColumn(
                name: "ventaIdVenta",
                table: "Grabado");

            migrationBuilder.DropColumn(
                name: "idProducto",
                table: "Encargo");

            migrationBuilder.AddColumn<int>(
                name: "MarcasTipoIdMarca",
                table: "TipoProducto",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VentaIdVenta",
                table: "Producto",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "productoidProducto",
                table: "Grabado",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TipoProducto_MarcasTipoIdMarca",
                table: "TipoProducto",
                column: "MarcasTipoIdMarca");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_VentaIdVenta",
                table: "Producto",
                column: "VentaIdVenta");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Venta_VentaIdVenta",
                table: "Producto",
                column: "VentaIdVenta",
                principalTable: "Venta",
                principalColumn: "IdVenta");

            migrationBuilder.AddForeignKey(
                name: "FK_TipoProducto_MarcasTipo_MarcasTipoIdMarca",
                table: "TipoProducto",
                column: "MarcasTipoIdMarca",
                principalTable: "MarcasTipo",
                principalColumn: "IdMarca");
        }
    }
}
