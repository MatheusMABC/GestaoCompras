using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoCompras.Migrations
{
    public partial class Atualizando_FornecedorJuridico_CaracterCap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CaracterCap",
                table: "FornecedorJuridico",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CaracterCap",
                table: "FornecedorJuridico");
        }
    }
}
