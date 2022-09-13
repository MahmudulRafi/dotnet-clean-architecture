using EMS.Application.Common.Interfaces;

namespace EMS.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
