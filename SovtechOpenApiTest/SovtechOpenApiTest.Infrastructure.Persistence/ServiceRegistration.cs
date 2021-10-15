using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SovtechOpenApiTest.Application.Interfaces;
using SovtechOpenApiTest.Application.Interfaces.Repositories;
using SovtechOpenApiTest.Infrastructure.Persistence.Contexts;
using SovtechOpenApiTest.Infrastructure.Persistence.Repositories;
using SovtechOpenApiTest.Infrastructure.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SovtechOpenApiTest.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseInMemoryDatabase("ApplicationDb"));
            }
            else
            {
                services.AddDbContext<ApplicationDbContext>(options =>
               options.UseSqlServer(
                   configuration.GetConnectionString("DefaultConnection"),
                   b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
            }
            #region Repositories
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            services.AddTransient<IProductRepositoryAsync, ProductRepositoryAsync>();
            services.AddTransient<ICategoryRepositoryAsync, CategoryRepositoryAsync>();
            services.AddTransient<IPersonRepositoryAsync, PersonRepositoryAsync>();
            services.AddTransient<ISearchRepositoryAsync, SearchRepositoryAsync>();
            #endregion
        }
    }
}
