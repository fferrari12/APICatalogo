using APICatalogo.Validations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mime;
using System.Text.Json.Serialization;

namespace APICatalogo.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        [Required(ErrorMessage = "Nome é obrigatorio")]
        [StringLength(20,ErrorMessage = "Nome deve ser entre 5 e 20 caracteres",MinimumLength = 5)]
        [PrimeiraLetraMaiuscula]
        public string? Nome { get; set; }
        [Required]
        [MaxLength(300)]
        public string? Descricao { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1,double.MaxValue,ErrorMessage ="O preço deve ser maior ou igual a {1}")]
        public decimal Preco { get; set; }
        [Required]
        [MaxLength(300)]
        public string? ImagemUrl { get; set; }
        [Range(1,1000,ErrorMessage = "estoque deve estar entre {1} e {2}")]
        public int Estoque { get; set; }
        public DateTime DataCadastro { get; set; }
        public int CategoriaId { get; set; }
        [JsonIgnore]
        public Categoria? Categoria { get; set; }
    }
}
