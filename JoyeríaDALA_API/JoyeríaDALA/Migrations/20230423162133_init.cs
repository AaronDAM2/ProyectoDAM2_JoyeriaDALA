using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JoyeríaDALA.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Encargo",
                columns: table => new
                {
                    IdEncargo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    precio = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encargo", x => x.IdEncargo);
                });

            migrationBuilder.CreateTable(
                name: "Venta",
                columns: table => new
                {
                    IdVenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    precio = table.Column<double>(type: "float", nullable: false),
                    observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaVenta = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venta", x => x.IdVenta);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    idProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoProducto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    precio = table.Column<double>(type: "float", nullable: true),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    material = table.Column<int>(type: "int", nullable: true),
                    tamano = table.Column<int>(type: "int", nullable: true),
                    EncargoIdEncargo = table.Column<int>(type: "int", nullable: true),
                    VentaIdVenta = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.idProducto);
                    table.ForeignKey(
                        name: "FK_Producto_Encargo_EncargoIdEncargo",
                        column: x => x.EncargoIdEncargo,
                        principalTable: "Encargo",
                        principalColumn: "IdEncargo");
                    table.ForeignKey(
                        name: "FK_Producto_Venta_VentaIdVenta",
                        column: x => x.VentaIdVenta,
                        principalTable: "Venta",
                        principalColumn: "IdVenta");
                });

            migrationBuilder.CreateTable(
                name: "Grabado",
                columns: table => new
                {
                    IdGrabado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    contenido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    productoidProducto = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grabado", x => x.IdGrabado);
                    table.ForeignKey(
                        name: "FK_Grabado_Producto_productoidProducto",
                        column: x => x.productoidProducto,
                        principalTable: "Producto",
                        principalColumn: "idProducto");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grabado_productoidProducto",
                table: "Grabado",
                column: "productoidProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_EncargoIdEncargo",
                table: "Producto",
                column: "EncargoIdEncargo");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_VentaIdVenta",
                table: "Producto",
                column: "VentaIdVenta");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grabado");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Encargo");

            migrationBuilder.DropTable(
                name: "Venta");
        }
    }
}
