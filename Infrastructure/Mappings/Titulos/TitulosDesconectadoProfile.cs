using Application.Models.Titulos;
using Application.Responses.Titulos.Desconectado;
using AutoMapper;

namespace Infrastructure.Mappings.Titulos
{
    public class TitulosDesconectadoProfile : Profile
    {
        public TitulosDesconectadoProfile()
        {
            CreateMap<TitulosDesconectado, TitulosDesconectadoResponse>();
        }
    }
}
