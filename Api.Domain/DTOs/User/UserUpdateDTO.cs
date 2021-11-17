using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTOs.User
{
    public class UserUpdateDTO
    {

        [Required(ErrorMessage = "ID é obrigatório")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(60, ErrorMessage = "Tamanho máximo {1} caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "E-mail é obrigatório")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        [StringLength(100, ErrorMessage = "Tamanho máximo de {1} caracteres")]
        public string Email { get; set; }

    }
}
