using APICatalogo.Models;
using APICatalogo.Validations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace APICatalogo.DTOs
{
    public class ProdutoDTO
    {
        public int ProdutoId { get; set; }
        [Required(ErrorMessage = "Nome é obrigatorio")]
        [StringLength(20, ErrorMessage = "Nome deve ser entre 5 e 20 caracteres", MinimumLength = 5)]
        [PrimeiraLetraMaiuscula]
        public string? Nome { get; set; }
        [Required]
        [MaxLength(300)]
        public string? Descricao { get; set; }
        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "O preço deve ser maior ou igual a {1}")]
        public decimal Preco { get; set; }
        [Required]
        [MaxLength(300)]
        public string? ImagemUrl { get; set; }
        [Range(1, 1000, ErrorMessage = "estoque deve estar entre {1} e {2}")]
        public int CategoriaId { get; set; }
    }
}
