﻿// <auto-generated />
using System;
using GestaoCompras.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestaoCompras.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GestaoCompras.Models.FornecedorFisico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataUltimaAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailPrincipal")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("EstadoCivil")
                        .HasColumnType("int");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<int>("NacionalFisico")
                        .HasColumnType("int");

                    b.Property<string>("Nacionalidade")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Profissao")
                        .HasColumnType("int");

                    b.Property<int>("SituacaoFisico")
                        .HasColumnType("int");

                    b.Property<string>("Telefone1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefone2")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefone3")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TipoPessoaFisica")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FornecedorFisico");
                });

            modelBuilder.Entity("GestaoCompras.Models.FornecedorJuridico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("CapitalSocial")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CaracterCap")
                        .HasColumnType("int");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataConstituicao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataUltimaAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailPrincipal")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Nacional")
                        .HasColumnType("int");

                    b.Property<string>("NomeFantasia")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Porte")
                        .HasColumnType("int");

                    b.Property<decimal?>("QuantidadeQuota")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Situacao")
                        .HasColumnType("int");

                    b.Property<string>("Telefone1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefone2")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefone3")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TipoEmpresa")
                        .HasColumnType("int");

                    b.Property<int>("TipoPessoa")
                        .HasColumnType("int");

                    b.Property<decimal?>("ValorCota")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("WebSite")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("FornecedorJuridico");
                });
#pragma warning restore 612, 618
        }
    }
}
