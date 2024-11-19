using BookStream.Application.Common.Interfaces.Repositories;
using BookStream.Infrastructure.Books;
using BookStream.Infrastructure.Categories.Persistence;
using BookStream.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace BookStream.Infrastructure.Common
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            /// Add the StatisticsDbContext to the services
            services.AddDbContextFactory<BookStreamDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("PostgreSqlConnection")));


            // Register repositories
            services.AddSingleton<IBookRepository, BookRepository>();
            services.AddSingleton<ICategoryRepository, CategoryRepository>();   

             return services;   
        } 
    }
}