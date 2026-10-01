using System.ComponentModel.DataAnnotations;

namespace Prova.Models.Validations
{
    public class PosicaoValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string posicao = value as string;

            if (string.IsNullOrEmpty(posicao))
                return new ValidationResult("A posição é obrigatório.");

            if (posicao.Length != 2)
                return new ValidationResult("A posicao deve ter exatamente 2 caracteres.");
        
            if (posicao != "GL" || posicao != "ZA" || posicao != "LD" || posicao != "LE" || posicao != "VO" || posicao != "MD" ||posicao != "AT")
                return new ValidationResult("O jogador deve ter alguma dessa posições 'GL, ZA, LD, LE, VO, MD ou AT'");

            return ValidationResult.Success;
        }
    }
}