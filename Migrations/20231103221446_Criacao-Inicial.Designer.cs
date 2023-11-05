﻿// <auto-generated />
using Link_Estudo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Link_Estudo.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20231103221446_Criacao-Inicial")]
    partial class CriacaoInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Link_Estudo.Models.Estudo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<string>("Assunto")
                        .HasColumnType("longtext")
                        .HasColumnName("Assunto");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext")
                        .HasColumnName("Descrição");

                    b.Property<string>("Link")
                        .HasColumnType("longtext")
                        .HasColumnName("Link");

                    b.HasKey("Id");

                    b.ToTable("LinkEstudo");
                });
#pragma warning restore 612, 618
        }
    }
}
