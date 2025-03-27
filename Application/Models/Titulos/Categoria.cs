using Domain.Contracts;
namespace Application.Models.Titulos
{
    public class Categoria : Entity<int>
    {
        public string Descripcion { get; set; } = string.Empty;
        public int? IdPadre { get; set; }
    }
}
