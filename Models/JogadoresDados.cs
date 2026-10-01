using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Prova.Models.Validations;

namespace Prova.Models
{
    public class JogadorDados
    {
        [Required(ErrorMessage = "O nome do jogadore é obrigatorio.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O nome do jogador deve ter entre 3 a 50 caracteres.")]
        public string nome { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatorio.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF deve ter exatamente 11 digitos.")]
        public string cpf { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatoria.")]
        [MaxLength(500, ErrorMessage = "A descrição deve ter no maximo 500 caracteres.")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "A posição é obrigatoria.")]
        [PosicaoValidation(ErrorMessage = "O jogador deve ter alguma dessa posições 'GL, ZA, LD, LE, VO, MD ou AT'")]
        public string posicao { get; set; }
    }
}
