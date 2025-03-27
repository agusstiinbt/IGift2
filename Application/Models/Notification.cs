using Application.Enums;
using Domain.Contracts;

namespace Application.Models
{
    public class Notification : Entity<int>
    {
        public string IdUser { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public DateTime DateTime { get; set; }
        public TypeNotification Type { get; set; }
    }
}
