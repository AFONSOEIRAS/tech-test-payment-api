﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tech_test_payment_api.Context;

#nullable disable

namespace tech_test_payment_api.Migrations
{
    [DbContext(typeof(PagamentoContext))]
    partial class PagamentoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("tech_test_payment_api.Entities.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("VendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VendaId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("tech_test_payment_api.Entities.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VendedorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VendedorId");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("tech_test_payment_api.Entities.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vendedores");
                });

            modelBuilder.Entity("tech_test_payment_api.Entities.Produto", b =>
                {
                    b.HasOne("tech_test_payment_api.Entities.Venda", null)
                        .WithMany("Produto")
                        .HasForeignKey("VendaId");
                });

            modelBuilder.Entity("tech_test_payment_api.Entities.Venda", b =>
                {
                    b.HasOne("tech_test_payment_api.Entities.Vendedor", "Vendedor")
                        .WithMany()
                        .HasForeignKey("VendedorId");

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("tech_test_payment_api.Entities.Venda", b =>
                {
                    b.Navigation("Produto");
                });
#pragma warning restore 612, 618
        }
    }
}
