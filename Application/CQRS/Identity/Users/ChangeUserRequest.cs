namespace Application.CQRS.Identity.Users
{
    public class ChangeUserRequest
    {
        public bool ActivateUser { get; set; }
        public string UserId { get; set; } = string.Empty;
    }
}
