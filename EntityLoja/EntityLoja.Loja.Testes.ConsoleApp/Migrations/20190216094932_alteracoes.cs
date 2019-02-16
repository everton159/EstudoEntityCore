using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityLoja.Loja.Testes.ConsoleApp.Migrations
{
    public partial class alteracoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Produtos",
                newName: "Unidade");

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Produtos",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PrecoUnitario",
                table: "Produtos",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "PrecoUnitario",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "Unidade",
                table: "Produtos",
                newName: "Preco");
        }
    }
}
