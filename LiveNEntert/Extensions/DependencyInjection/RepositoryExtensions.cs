using LiveNEntert.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace LiveNEntert.Api.Extensions.DependencyInjection
{
    public static class RepositoryExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
        }
    }
}
