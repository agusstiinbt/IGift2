using IGift.Domain.Contracts;

namespace IGift.Application.Models.SQL.MySQL
{
    public class Category : Entity<int>
    {
        public string Descripcion { get; set; } = string.Empty;
        public int? IdPadre { get; set; }
    }
}
