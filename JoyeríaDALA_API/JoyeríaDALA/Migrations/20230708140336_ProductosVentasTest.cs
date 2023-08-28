using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JoyeríaDALA.Migrations
{
    /// <inheritdoc />
    public partial class ProductosVentasTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Encargo_EncargoIdEncargo",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Producto_EncargoIdEncargo",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "EncargoIdEncargo",
                table: "Producto");

            migrationBuilder.AddColumn<int>(
                name: "ventaIdVenta",
                table: "Encargo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Encargo_ventaIdVenta",
                table: "Encargo",
                column: "ventaIdVenta");

            migrationBuilder.AddForeignKey(
                name: "FK_Encargo_Venta_ventaIdVenta",
                table: "Encargo",
                column: "ventaIdVenta",
                principalTable: "Venta",
                principalColumn: "IdVenta",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Encargo_Venta_ventaIdVenta",
                table: "Encargo");

            migrationBuilder.DropIndex(
                name: "IX_Encargo_ventaIdVenta",
                table: "Encargo");

            migrationBuilder.DropColumn(
                name: "ventaIdVenta",
                table: "Encargo");

            migrationBuilder.AddColumn<int>(
                name: "EncargoIdEncargo",
                table: "Producto",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Producto_EncargoIdEncargo",
                table: "Producto",
                column: "EncargoIdEncargo");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Encargo_EncargoIdEncargo",
                table: "Producto",
                column: "EncargoIdEncargo",
                principalTable: "Encargo",
                principalColumn: "IdEncargo");
        }
    }
}
