using BookStream.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookStream.Infrastructure.Configurations
{
    public static class ServiceCollectionExtensions
    {
       public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            /// Add the StatisticsDbContext to the services
            services.AddDbContextFactory<BookStreamDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("PostgreSqlConnection")));

             return services;   
        } 
    }
}