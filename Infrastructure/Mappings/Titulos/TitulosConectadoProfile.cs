using Application.Models.Titulos;
using Application.Responses.Titulos.Conectado;
using AutoMapper;

namespace Infrastructure.Mappings.Titulos
{
    public class TitulosConectadoProfile : Profile
    {
        public TitulosConectadoProfile()
        {
            CreateMap<TitulosConectado, TitulosConectadoResponse>();
        }
    }
}
