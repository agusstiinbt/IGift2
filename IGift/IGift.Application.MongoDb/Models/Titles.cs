namespace IGift.Application.MongoDb.Models
{
    public class Titles : MongoDbEntity<string>
    {
        public string Descripcion { get; set; } = string.Empty;
        public bool Online { get; set; }
    }
}
