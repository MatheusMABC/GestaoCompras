using System.ComponentModel.DataAnnotations;

namespace GestaoCompras.Models
{
    public enum TipoPessoa
    {
        Juridica = 1
    }
    public enum Situacao
    {
        Desativar,
        Ativo,
        Elaboração
    }
    public enum TipoEmpresa
    {
        MEI,
        EIRELI
    }
    public enum Nacional
    {
        Não,
        Sim
    }
    public enum Porte
    {
        MEI,
        ME,
        EPP,
        EMP
    }
    public class FornecedorJuridico
    {

        [Key]
        public int Id { get; set; }
        [Display(Name = "Data Ultima Atualização")]

        public DateTime DataUltimaAtualizacao { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório")]

        [Display(Name = "CNPJ ")]
        public string Cnpj { get; set; }
        //[Required(ErrorMessage = "O {0} é obrigatório")]
        //[Display(Name = "CPF ")]
        //public string Cpf { get; set; }
        [Required(ErrorMessage = "O {0} é obrigatório")]
        [StringLength(200)]

        [Display(Name = "Razão Social ")]
        public string RazaoSocial { get; set; }

        [Display(Name = "Nome Fantasia")]
        [StringLength(200)]

        public string? NomeFantasia { get; set; }
        [Required(ErrorMessage = "O {0} é obrigatório")]
        [Display(Name = "Tipo de Pessoa")]
        public TipoPessoa TipoPessoa { get; set; }
        [Display(Name = "Situação")]
        public Situacao Situacao { get; set; }
        [Required(ErrorMessage = "O {0} é obrigatório")]
        [Display(Name = "Tipo Empresa")]
        public TipoEmpresa TipoEmpresa { get; set; }
        public DateTime DataConstituicao { get; set; }
        [Required(ErrorMessage = "O {0} é obrigatório")]
        [Display(Name = "Porte")]
        public Porte Porte { get; set; }
        [Display(Name = "Telefone 1")]
        [StringLength(50)]

        public string Telefone1 { get; set; }
        [Display(Name = "Telefone 2")]
        [StringLength(50)]

        public string? Telefone2 { get; set; }
        [Display(Name = "Telefone 3")]
        [StringLength(50)]

        public string? Telefone3 { get; set; }
        [StringLength(500)]

        public string? WebSite { get; set; }
        [Required(ErrorMessage = "O {0} é obrigatório")]
        [Display(Name = "Email Principal")]
        [StringLength(50)]

        public string EmailPrincipal { get; set; }
        [Display(Name = "Caracterização do Capital ")]

        public decimal CaracterizacaoCapital { get; set; }


        [Display(Name = "Quantidade Quota")]
        public decimal QuantidadeQuota { get; set; }


        [Display(Name = "Valor Cota")]
        public decimal ValorCota { get; set; }


        [Required(ErrorMessage = "O {0} é obrigatório")]
        [Display(Name = "Capital Social")]
        public decimal CapitalSocial { get; set; }
        [Required(ErrorMessage = "O {0} é obrigatório")]
        [Display(Name = "Nacional")]
        public Nacional Nacional { get; set; }

        public DateTime DataCadastro { get; set; }

    }
}
