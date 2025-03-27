using Application.Models.Titulos;
using Application.Responses.Titulos.Categoria;
using AutoMapper;

namespace Infrastructure.Mappings.Titulos
{
    public class CategoriaProfile : Profile
    {
        public CategoriaProfile()
        {
            CreateMap<Categoria, CategoriaResponse>();
        }
    }
}
