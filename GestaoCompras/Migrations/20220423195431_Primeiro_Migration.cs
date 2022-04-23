using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoCompras.Migrations
{
    public partial class Primeiro_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FornecedorFisico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cpf = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    TipoPessoaFisica = table.Column<int>(type: "int", nullable: false),
                    NacionalFisico = table.Column<int>(type: "int", nullable: false),
                    SituacaoFisico = table.Column<int>(type: "int", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmailPrincipal = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EstadoCivil = table.Column<int>(type: "int", nullable: true),
                    Profissao = table.Column<int>(type: "int", nullable: false),
                    Telefone1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefone2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Telefone3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nacionalidade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataUltimaAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FornecedorFisico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FornecedorJuridico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataUltimaAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cnpj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RazaoSocial = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NomeFantasia = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TipoPessoa = table.Column<int>(type: "int", nullable: false),
                    Situacao = table.Column<int>(type: "int", nullable: false),
                    TipoEmpresa = table.Column<int>(type: "int", nullable: false),
                    DataConstituicao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Porte = table.Column<int>(type: "int", nullable: false),
                    Telefone1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefone2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Telefone3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    WebSite = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    EmailPrincipal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CaracterizacaoCapital = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuantidadeQuota = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorCota = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CapitalSocial = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Nacional = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FornecedorJuridico", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FornecedorFisico");

            migrationBuilder.DropTable(
                name: "FornecedorJuridico");
        }
    }
}
