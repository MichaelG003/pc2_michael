﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using appGestionBanco.Data;

#nullable disable

namespace appGestionBanco.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("appGestionBanco.Models.CuentaBanco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("NombreTitular")
                        .HasColumnType("text");

                    b.Property<decimal?>("SaldoInicial")
                        .HasColumnType("numeric");

                    b.Property<string>("TipoCuenta")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CuentaBancos");
                });
#pragma warning restore 612, 618
        }
    }
}
