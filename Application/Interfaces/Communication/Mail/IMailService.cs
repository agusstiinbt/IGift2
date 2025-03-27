namespace Application..Interfaces.Communication.Mail
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}
