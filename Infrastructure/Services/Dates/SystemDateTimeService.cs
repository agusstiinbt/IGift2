using Application.Interfaces.Dates;

namespace Infrastructure.Services.Dates
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}
