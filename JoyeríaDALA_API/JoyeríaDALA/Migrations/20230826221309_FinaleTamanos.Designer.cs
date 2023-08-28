﻿// <auto-generated />
using System;
using JoyeríaDALA.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JoyeríaDALA.Migrations
{
    [DbContext(typeof(JoyeriaContext))]
    [Migration("20230826221309_FinaleTamanos")]
    partial class FinaleTamanos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JoyeríaDALA.Models.Encargo", b =>
                {
                    b.Property<int>("IdEncargo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEncargo"));

                    b.Property<DateTime?>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("cliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idProducto")
                        .HasColumnType("int");

                    b.Property<double?>("precio")
                        .HasColumnType("float");

                    b.Property<bool>("terminada")
                        .HasColumnType("bit");

                    b.Property<int>("ventaIdVenta")
                        .HasColumnType("int");

                    b.HasKey("IdEncargo");

                    b.HasIndex("ventaIdVenta");

                    b.ToTable("Encargo");
                });

            modelBuilder.Entity("JoyeríaDALA.Models.Factura", b =>
                {
                    b.Property<int>("idFactura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idFactura"));

                    b.Property<string>("FacturaNIF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdAsociado")
                        .HasColumnType("int");

                    b.Property<double>("Subtotal")
                        .HasColumnType("float");

                    b.Property<string>("TipoAsociado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<string>("cliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dirFactura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("domicilioPago")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaFactura")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechaVencimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("formaPago")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idFactura");

                    b.ToTable("Factura");
                });

            modelBuilder.Entity("JoyeríaDALA.Models.Grabado", b =>
                {
                    b.Property<int>("IdGrabado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdGrabado"));

                    b.Property<DateTime?>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("contenido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idProducto")
                        .HasColumnType("int");

                    b.Property<string>("nombreCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("precio")
                        .HasColumnType("float");

                    b.Property<bool>("terminado")
                        .HasColumnType("bit");

                    b.Property<int>("ventaIdVenta")
                        .HasColumnType("int");

                    b.HasKey("IdGrabado");

                    b.HasIndex("ventaIdVenta");

                    b.ToTable("Grabado");
                });

            modelBuilder.Entity("JoyeríaDALA.Models.ItemFactura", b =>
                {
                    b.Property<int>("IdItem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdItem"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Descuento")
                        .HasColumnType("int");

                    b.Property<int?>("FacturaidFactura")
                        .HasColumnType("int");

                    b.Property<int>("IdFactura")
                        .HasColumnType("int");

                    b.Property<int>("IdObjeto")
                        .HasColumnType("int");

                    b.Property<double>("Importe")
                        .HasColumnType("float");

                    b.Property<double>("PrecioUnitario")
                        .HasColumnType("float");

                    b.Property<string>("tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdItem");

                    b.HasIndex("FacturaidFactura");

                    b.ToTable("ItemFactura");
                });

            modelBuilder.Entity("JoyeríaDALA.Models.MarcasTipo", b =>
                {
                    b.Property<int>("IdMarca")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMarca"));

                    b.Property<int>("IdTipo")
                        .HasColumnType("int");

                    b.Property<string>("NombreMarca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMarca");

                    b.ToTable("MarcasTipo");
                });

            modelBuilder.Entity("JoyeríaDALA.Models.Material", b =>
                {
                    b.Property<int>("MaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaterialId"));

                    b.Property<string>("material")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaterialId");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("JoyeríaDALA.Models.Notificacion", b =>
                {
                    b.Property<int>("NotifId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NotifId"));

                    b.Property<int>("IdAsociado")
                        .HasColumnType("int");

                    b.Property<string>("descripción")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NotifId");

                    b.ToTable("Notificacion");
                });

            modelBuilder.Entity("JoyeríaDALA.Models.Preferencia", b =>
                {
                    b.Property<int>("IdAjuste")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAjuste"));

                    b.Property<string>("nombreAjuste")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("otrosDatos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("valor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAjuste");

                    b.ToTable("Preferencia");
                });

            modelBuilder.Entity("JoyeríaDALA.Models.Producto", b =>
                {
                    b.Property<int>("idProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idProducto"));

                    b.Property<bool?>("activo")
                        .HasColumnType("bit");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("material")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("precio")
                        .HasColumnType("float");

                    b.Property<int>("stock")
                        .HasColumnType("int");

                    b.Property<string>("subtipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tamano")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipoProducto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idProducto");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("JoyeríaDALA.Models.ProductosVenta", b =>
                {
                    b.Property<int>("IdProdVenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProdVenta"));

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<int>("IdVenta")
                        .HasColumnType("int");

                    b.Property<int?>("VentaIdVenta")
                        .HasColumnType("int");

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<int>("descuento")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("precioTotal")
                        .HasColumnType("float");

                    b.Property<double>("precioUnidad")
                        .HasColumnType("float");

                    b.HasKey("IdProdVenta");

                    b.HasIndex("VentaIdVenta");

                    b.ToTable("ProductosVenta");
                });

            modelBuilder.Entity("JoyeríaDALA.Models.SubtiposProducto", b =>
                {
                    b.Property<int>("idSubtipo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idSubtipo"));

                    b.Property<int>("idTipo")
                        .HasColumnType("int");

                    b.Property<string>("subtipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idSubtipo");

                    b.ToTable("SubtiposProducto");
                });

            modelBuilder.Entity("JoyeríaDALA.Models.Tamano", b =>
                {
                    b.Property<int>("IdTamano")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTamano"));

                    b.Property<string>("tamano")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTamano");

                    b.ToTable("tamanos");
                });

            modelBuilder.Entity("JoyeríaDALA.Models.TipoProducto", b =>
                {
                    b.Property<int>("IdTipo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipo"));

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTipo");

                    b.ToTable("TipoProducto");
                });

            modelBuilder.Entity("JoyeríaDALA.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"));

                    b.Property<string>("apikey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipoUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("JoyeríaDALA.Models.Venta", b =>
                {
                    b.Property<int>("IdVenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVenta"));

                    b.Property<DateTime>("FechaVenta")
                        .HasColumnType("datetime2");

                    b.Property<string>("codVenta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("precio")
                        .HasColumnType("float");

                    b.HasKey("IdVenta");

                    b.ToTable("Venta");
                });

            modelBuilder.Entity("JoyeríaDALA.Models.Encargo", b =>
                {
                    b.HasOne("JoyeríaDALA.Models.Venta", "venta")
                        .WithMany()
                        .HasForeignKey("ventaIdVenta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("venta");
                });

            modelBuilder.Entity("JoyeríaDALA.Models.Grabado", b =>
                {
                    b.HasOne("JoyeríaDALA.Models.Venta", "venta")
                        .WithMany()
                        .HasForeignKey("ventaIdVenta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("venta");
                });

            modelBuilder.Entity("JoyeríaDALA.Models.ItemFactura", b =>
                {
                    b.HasOne("JoyeríaDALA.Models.Factura", null)
                        .WithMany("Items")
                        .HasForeignKey("FacturaidFactura");
                });

            modelBuilder.Entity("JoyeríaDALA.Models.ProductosVenta", b =>
                {
                    b.HasOne("JoyeríaDALA.Models.Venta", null)
                        .WithMany("productos")
                        .HasForeignKey("VentaIdVenta");
                });

            modelBuilder.Entity("JoyeríaDALA.Models.Factura", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("JoyeríaDALA.Models.Venta", b =>
                {
                    b.Navigation("productos");
                });
#pragma warning restore 612, 618
        }
    }
}
