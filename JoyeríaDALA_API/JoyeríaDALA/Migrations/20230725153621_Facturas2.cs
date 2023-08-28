using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JoyeríaDALA.Migrations
{
    /// <inheritdoc />
    public partial class Facturas2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ventaIdVenta",
                table: "Factura",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Factura_ventaIdVenta",
                table: "Factura",
                column: "ventaIdVenta");

            migrationBuilder.AddForeignKey(
                name: "FK_Factura_Venta_ventaIdVenta",
                table: "Factura",
                column: "ventaIdVenta",
                principalTable: "Venta",
                principalColumn: "IdVenta",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Factura_Venta_ventaIdVenta",
                table: "Factura");

            migrationBuilder.DropIndex(
                name: "IX_Factura_ventaIdVenta",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "ventaIdVenta",
                table: "Factura");
        }
    }
}
