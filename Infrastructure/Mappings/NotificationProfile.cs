using Application.Models;
using Application.Responses.Notification;
using AutoMapper;

namespace Infrastructure.Mappings
{
    public class NotificationProfile : Profile
    {
        public NotificationProfile()
        {
            CreateMap<Notification, NotificationResponse>();
        }
    }
}
