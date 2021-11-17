using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTOs.Municipio
{
    public class MunicipioUpdateDTO
    {
        [Required(ErrorMessage = "ID do município é obrigatório")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome do município é obrigatório")]
        [StringLength(60, ErrorMessage = "Nome do município deve ter no máximo {1} caracteres")]
        public string Name { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Cod IBGE inválido")]
        public int CodIBGE { get; set; }

        [Required(ErrorMessage = "Código da UF é obrigatório")]
        public Guid UfId { get; set; }
    }
}
