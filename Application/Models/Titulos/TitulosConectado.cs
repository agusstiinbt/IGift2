using Domain.Contracts;

namespace Application.Models.Titulos
{
    public class TitulosConectado : Entity<int>
    {
        public string Descripcion { get; set; } = string.Empty;
    }
}
