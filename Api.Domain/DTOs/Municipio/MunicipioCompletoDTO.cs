using System;
using Api.Domain.DTOs.Uf;

namespace Api.Domain.DTOs.Municipio
{
    public class MunicipioCompletoDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int CodIBGE { get; set; }
        public Guid UfId { get; set; }
        public UfDTO Uf { get; set; }
    }
}
