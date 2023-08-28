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
    [Migration("20230423163145_init3")]
    partial class init3
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

                    b.Property<double?>("precio")
                        .HasColumnType("float");

                    b.HasKey("IdEncargo");

                    b.ToTable("Encargo");
                });

            modelBuilder.Entity("JoyeríaDALA.Models.Grabado", b =>
                {
                    b.Property<int>("IdGrabado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdGrabado"));

                    b.Property<string>("contenido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("productoidProducto")
                        .HasColumnType("int");

                    b.HasKey("IdGrabado");

                    b.HasIndex("productoidProducto");

                    b.ToTable("Grabado");
                });

            modelBuilder.Entity("JoyeríaDALA.Models.Producto", b =>
                {
                    b.Property<int>("idProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idProducto"));

                    b.Property<int?>("EncargoIdEncargo")
                        .HasColumnType("int");

                    b.Property<int?>("VentaIdVenta")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("material")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("precio")
                        .HasColumnType("float");

                    b.Property<int?>("tamano")
                        .HasColumnType("int");

                    b.Property<string>("tipoProducto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idProducto");

                    b.HasIndex("EncargoIdEncargo");

                    b.HasIndex("VentaIdVenta");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("JoyeríaDALA.Models.Venta", b =>
                {
                    b.Property<int>("IdVenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVenta"));

                    b.Property<DateTime>("FechaVenta")
                        .HasColumnType("datetime2");

                    b.Property<string>("observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("precio")
                        .HasColumnType("float");

                    b.HasKey("IdVenta");

                    b.ToTable("Venta");
                });

            modelBuilder.Entity("JoyeríaDALA.Models.Grabado", b =>
                {
                    b.HasOne("JoyeríaDALA.Models.Producto", "producto")
                        .WithMany()
                        .HasForeignKey("productoidProducto");

                    b.Navigation("producto");
                });

            modelBuilder.Entity("JoyeríaDALA.Models.Producto", b =>
                {
                    b.HasOne("JoyeríaDALA.Models.Encargo", null)
                        .WithMany("productos")
                        .HasForeignKey("EncargoIdEncargo");

                    b.HasOne("JoyeríaDALA.Models.Venta", null)
                        .WithMany("productos")
                        .HasForeignKey("VentaIdVenta");
                });

            modelBuilder.Entity("JoyeríaDALA.Models.Encargo", b =>
                {
                    b.Navigation("productos");
                });

            modelBuilder.Entity("JoyeríaDALA.Models.Venta", b =>
                {
                    b.Navigation("productos");
                });
#pragma warning restore 612, 618
        }
    }
}
