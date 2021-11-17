using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTOs.Cep
{
    public class CepCreateDTO
    {
        [Required(ErrorMessage = "CEP é obrigatório")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Logradouro é obrigatório")]
        public string Logradouro { get; set; }

        public string Numero { get; set; }

        [Required(ErrorMessage = "Município é obrigatório")]
        public Guid MunicipioId { get; set; }

    }
}
