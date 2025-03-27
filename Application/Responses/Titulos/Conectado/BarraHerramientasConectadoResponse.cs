using Application.Responses.Titulos.Categoria;

namespace Application.Responses.Titulos.Conectado
{
    public class BarraHerramientasConectadoResponse
    {
        public BarraHerramientasConectadoResponse()
        {
            Categorias = new List<CategoriaResponse>();
            Titulos = new List<TitulosConectadoResponse>();
        }

        public List<CategoriaResponse> Categorias { get; set; }
        public List<TitulosConectadoResponse> Titulos { get; set; }
    }
}
