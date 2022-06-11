using LiveNEntert.Services;
using Microsoft.Extensions.DependencyInjection;

namespace LiveNEntert.Api.Extensions.DependencyInjection
{
    public static class DomainServiceExtensions
    {
        public static void AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped<ISummaryService, SummaryService>();
        }
    }
}
