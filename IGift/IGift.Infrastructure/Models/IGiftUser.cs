using IGift.Application.Models.SQL.MySQL;
using IGift.Domain.Contracts;
using IGift.Domain.Entities;
using IGift.Domain.Entities.SQLServer;
using Microsoft.AspNetCore.Identity;

namespace IGift.Infrastructure.Models
{
    public class IGiftUser : IdentityUser<string>, IAuditableEntity<string>
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }

        public string? RefreshToken { get; set; }

        public DateTime RefreshTokenExpiryTime { get; set; }

        public string? CreatedBy { get; set; }
        public string? LastModifiedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? LastModifiedOn { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<Petitions> Pedidos { get; set; }
        public virtual ICollection<Contract> Contratos { get; set; }
        public virtual ICollection<ExchangeOperations> OperacionesIntercambios { get; set; }

    }
}
