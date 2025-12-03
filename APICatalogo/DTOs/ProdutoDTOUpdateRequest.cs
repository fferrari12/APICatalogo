using System.ComponentModel.DataAnnotations;

namespace APICatalogo.DTOs
{
    public class ProdutoDTOUpdateRequest : IValidatableObject
    {
        [Range(1,9999, ErrorMessage = "O id deve ser estar entre 1 e 9999")]
        public int Estoque { get; set; }

        public DateTime DataCadastro { get; set; } = DateTime.Now;

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (DataCadastro > DateTime.Now)
            {
                yield return new ValidationResult(
                    "A data de cadastro não pode ser futura.",
                    new[] { nameof(DataCadastro) });
            }
        }
    }
}
