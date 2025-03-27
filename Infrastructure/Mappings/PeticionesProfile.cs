using Application.Responses.Peticiones;
using AutoMapper;
using Domain.Entities;

namespace Infrastructure.Mappings
{
    public class PeticionesProfile : Profile
    {
        public PeticionesProfile()
        {
            CreateMap<Peticiones, PeticionesResponse>();
        }
    }
}
