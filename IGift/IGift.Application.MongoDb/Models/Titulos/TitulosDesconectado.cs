using IGift.Domain.Contracts;

namespace IGift.Application.MongoDb.Models.Titulos
{
    public class TitulosDesconectado : Entity<int>
    {
        public string Descripcion { get; set; } = string.Empty;
    }
}
