using System;

namespace Api.Domain.DTOs.Municipio
{
    public class MunicipioCreateResultDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int CodIBGE { get; set; }
        public Guid UfId { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
