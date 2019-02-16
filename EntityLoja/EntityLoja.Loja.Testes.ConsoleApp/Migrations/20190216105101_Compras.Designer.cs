﻿// <auto-generated />
using EntityLoja.Loja.Testes.ConsoleApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityLoja.Loja.Testes.ConsoleApp.Migrations
{
    [DbContext(typeof(LojaContext))]
    [Migration("20190216105101_Compras")]
    partial class Compras
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Alura.Loja.Testes.ConsoleApp.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProdutoID");

                    b.Property<double>("preco");

                    b.Property<int>("quantidade");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoID");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("Alura.Loja.Testes.ConsoleApp.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Categoria");

                    b.Property<string>("Descricao");

                    b.Property<string>("Nome");

                    b.Property<double>("PrecoUnitario");

                    b.Property<double>("Unidade");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Alura.Loja.Testes.ConsoleApp.Compra", b =>
                {
                    b.HasOne("Alura.Loja.Testes.ConsoleApp.Produto", "produto")
                        .WithMany()
                        .HasForeignKey("ProdutoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
