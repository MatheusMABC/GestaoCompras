using System.ComponentModel.DataAnnotations;

namespace GestaoCompras.Models
{
    public enum EstadoCivil
    {
        Casado,
        Solteiro,
        Viúvo
    }
    public enum TipoPessoaFisica
    {
        Fisica = 1
    }

    public enum TipoDeEmpresa
    {
        A,
        B,
        C
    }
    public enum Genero
    {
        Masculino,
        Feiminino,
        Outros
    }
    public enum NacionalFisico
    {
        Sim,
        Não
    }
    public enum SituacaoFisico
    {
        Ativo,
        Desativar,
        Elaboração
    }
    public enum Profissao
    {
        ProfissãoA,
        ProfissãoB,
    }
    public class FornecedorFisico
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O {0} é obrigatório")]
        [StringLength(14, ErrorMessage = "The {0} valor não pode ultrapassar  11 digitos. ")]

        [Display(Name = "CPF")]
        public string Cpf { get; set; }
        [Display(Name = "Tipo Pessoa")]

        public TipoPessoaFisica TipoPessoaFisica { get; set; }
        [Display(Name = "Nacional")]

        public NacionalFisico NacionalFisico { get; set; }
        [Display(Name = "Situação")]

        public SituacaoFisico SituacaoFisico { get; set; }
        public Genero Genero { get; set; }
        [Required(ErrorMessage = "O {0} é obrigatório")]
        [StringLength(200)]

        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O {0} é obrigatório")]
        [StringLength(200)]

        [Display(Name = "Email")]
        public string EmailPrincipal { get; set; }
        [Display(Name = "Estado Civil")]
        public EstadoCivil? EstadoCivil { get; set; }
        [Required(ErrorMessage = "O {0} é obrigatório")]

        [Display(Name = "Profissão")]
        public Profissao Profissao { get; set; }
        [Required(ErrorMessage = "O {0} é obrigatório")]

        [Display(Name = "Telefone 1")]
        [StringLength(50)]
        public string? Telefone1 { get; set; }
        [Display(Name = "Telefone 2")]
        [StringLength(50)]

        public string? Telefone2 { get; set; }
        [StringLength(50)]

        [Display(Name = "Telefone 3")]
        public string? Telefone3 { get; set; }
        [Required(ErrorMessage = "O {0} é obrigatório")]

        [Display(Name = "Data Nascimento")]
        public DateTime DataNascimento { get; set; }
        [Display(Name = "Nacionalidade")]
        [StringLength(50)]
        public string? Nacionalidade { get; set; }

        public DateTime DataCadastro { get; set; }
        [Display(Name = "Data Ultima Atualização")]
        public DateTime? DataUltimaAtualizacao { get; set; }

    }
}
