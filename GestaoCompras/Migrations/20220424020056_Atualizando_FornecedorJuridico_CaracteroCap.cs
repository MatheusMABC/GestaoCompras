using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoCompras.Migrations
{
    public partial class Atualizando_FornecedorJuridico_CaracteroCap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CaracterizacaoCapital",
                table: "FornecedorJuridico");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CaracterizacaoCapital",
                table: "FornecedorJuridico",
                type: "int",
                nullable: true);
        }
    }
}
