using Application.CQRS.Identity.Email;

namespace Application.Interfaces.Communication.Mail
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}
