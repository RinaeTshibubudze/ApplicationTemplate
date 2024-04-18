using SawsAppTemplate.Application.Interfaces.Services;
using System;

namespace SawsAppTemplate.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}