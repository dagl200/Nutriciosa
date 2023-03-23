﻿// <auto-generated />
using Asp___Angular_2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Asp___Angular_2.Migrations
{
    [DbContext(typeof(EmpleadoContext))]
    [Migration("20230314023413_test2")]
    partial class test2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("Asp___Angular_2.Model.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Camion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .HasColumnType("TEXT");

                    b.Property<int>("Edad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ruta")
                        .HasColumnType("TEXT");

                    b.Property<int>("TelefonoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TelefonoId");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("Asp___Angular_2.Model.Num_telefono", b =>
                {
                    b.Property<int>("TelefonoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Activo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<int>("Telefono_celular")
                        .HasColumnType("INTEGER");

                    b.HasKey("TelefonoId");

                    b.ToTable("Num_telefonos");
                });

            modelBuilder.Entity("Asp___Angular_2.Model.Empleado", b =>
                {
                    b.HasOne("Asp___Angular_2.Model.Num_telefono", "Num_Telefono")
                        .WithMany()
                        .HasForeignKey("TelefonoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Num_Telefono");
                });
#pragma warning restore 612, 618
        }
    }
}