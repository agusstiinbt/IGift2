namespace IGift.Application.Models.ElasticSearchModels
{
    public class UserSearches
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Referencia al usuario
        /// </summary>
        public string UserId { get; set; } = string.Empty;
        /// <summary>
        /// Texto de busqueda
        /// </summary>
        public string? Query { get; set; }
        /// <summary>
        /// Terminos extraidos para filtros
        /// </summary>
        public List<string>? Keywords { get; set; }
        public string? Category { get; set; }
        public string? Location { get; set; }
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// "Mobile", "Desktop", etc. (opcional)
        /// </summary>
        public string? Device { get; set; }
        public bool? HadResults { get; set; }
    }
}
