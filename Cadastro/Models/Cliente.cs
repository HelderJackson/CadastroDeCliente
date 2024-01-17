using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cadastro.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        [Column("ID")]
        [Display(Name ="Código")]
        public int ID { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo NOME é obrigatório.")]
        public string Nome { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        public string Email { get; set; }

        [Column("Data")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        [Required(ErrorMessage = "O campo Data é obrigatório.")]
        public DateTime DataDeNascimento { get; set; }

        [Column("CEP")]
        [Display(Name = "CEP")]
        [Required(ErrorMessage = "O campo CEP é obrigatório.")]
        public string CEP { get; set; }

        [Column("Rua")]
        [Display(Name = "Rua")]
        [Required(ErrorMessage = "O campo Rua é obrigatório.")]
        public string Rua { get; set; }

        [Column("Bairro")]
        [Display(Name = "Bairro")]
        [Required(ErrorMessage = "O campo Bairro é obrigatório.")]
        public string Bairro { get; set; }

        [Column("Cidade")]
        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "O campo Cidade é obrigatório.")]
        public string Cidade { get; set; }

        [Column("UF")]
        [Display(Name = "UF")]
        [Required(ErrorMessage = "O campo UF é obrigatório.")]
        public string UF { get; set; }

        [Column("IBGE")]
        [Display(Name = "IBGE")]
        [Required(ErrorMessage = "O campo IBGE é obrigatório.")]
        public string IBGE { get; set; }
    }
}
