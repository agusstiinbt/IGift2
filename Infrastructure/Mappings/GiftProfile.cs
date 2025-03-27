using Application.CQRS.Peticiones.Command;
using AutoMapper;
using Domain.Entities;

namespace Infrastructure.Mappings
{
    public class GiftProfile : Profile
    {

        public GiftProfile()
        {
            CreateMap<Peticiones, AddEditPeticionesCommand>();
        }
    }
}
