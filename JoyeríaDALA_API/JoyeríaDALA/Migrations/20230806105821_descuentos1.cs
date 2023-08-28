using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JoyeríaDALA.Migrations
{
    /// <inheritdoc />
    public partial class descuentos1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "precioTotal",
                table: "Factura",
                newName: "Total");

            migrationBuilder.AddColumn<string>(
                name: "FacturaNIF",
                table: "Factura",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Subtotal",
                table: "Factura",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "dirFactura",
                table: "Factura",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "domicilioPago",
                table: "Factura",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "formaPago",
                table: "Factura",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ItemFactura",
                columns: table => new
                {
                    IdItem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdFactura = table.Column<int>(type: "int", nullable: false),
                    IdObjeto = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecioUnitario = table.Column<double>(type: "float", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Importe = table.Column<double>(type: "float", nullable: false),
                    Descuento = table.Column<int>(type: "int", nullable: false),
                    FacturaidFactura = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemFactura", x => x.IdItem);
                    table.ForeignKey(
                        name: "FK_ItemFactura_Factura_FacturaidFactura",
                        column: x => x.FacturaidFactura,
                        principalTable: "Factura",
                        principalColumn: "idFactura");
                });

            migrationBuilder.CreateTable(
                name: "Preferencia",
                columns: table => new
                {
                    IdAjuste = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreAjuste = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    valor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    otrosDatos = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preferencia", x => x.IdAjuste);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemFactura_FacturaidFactura",
                table: "ItemFactura",
                column: "FacturaidFactura");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemFactura");

            migrationBuilder.DropTable(
                name: "Preferencia");

            migrationBuilder.DropColumn(
                name: "FacturaNIF",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "Subtotal",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "dirFactura",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "domicilioPago",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "formaPago",
                table: "Factura");

            migrationBuilder.RenameColumn(
                name: "Total",
                table: "Factura",
                newName: "precioTotal");
        }
    }
}
