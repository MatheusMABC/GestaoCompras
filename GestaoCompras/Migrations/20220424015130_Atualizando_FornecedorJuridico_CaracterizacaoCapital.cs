using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoCompras.Migrations
{
    public partial class Atualizando_FornecedorJuridico_CaracterizacaoCapital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CaracterizacaoCapital",
                table: "FornecedorJuridico",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "CaracterizacaoCapital",
                table: "FornecedorJuridico",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
