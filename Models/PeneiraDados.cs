using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Prova.Models.Validations;

namespace Prova.Models
{
    public class Peneira
    {
        [Required(ErrorMessage = "O CPF é obrigatorio.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF deve ter exatamente 11 caracteres.")]
        public string cpf { get; set; }

        public bool aprovado { get; set; }

    }
}
