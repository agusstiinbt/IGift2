using AutoMapper;
using IGift.Application.CQRS.Peticiones.Command;
using IGift.Domain.Entities.SQLServer;

namespace IGift.Infrastructure.Mappings
{
    public class GiftProfile : Profile
    {

        public GiftProfile()
        {
            CreateMap<Petitions, AddEditPeticionesCommand>();
        }
    }
}
