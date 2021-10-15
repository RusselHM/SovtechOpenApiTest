using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SovtechOpenApiTest.Application.Interfaces;
using SovtechOpenApiTest.Domain.Settings;
using SovtechOpenApiTest.Infrastructure.Shared.Services;

namespace SovtechOpenApiTest.Infrastructure.Shared
{
    public static class ServiceRegistration
    {
        public static void AddSharedInfrastructure(this IServiceCollection services, IConfiguration _config)
        {
            services.Configure<MailSettings>(_config.GetSection("MailSettings"));
            services.AddTransient<IDateTimeService, DateTimeService>();
            services.AddTransient<IEmailService, EmailService>();
        }
    }
}
