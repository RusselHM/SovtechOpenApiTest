using Microsoft.EntityFrameworkCore;
using SovtechOpenApiTest.Application.Interfaces.Repositories;
using SovtechOpenApiTest.Domain.Entities;
using SovtechOpenApiTest.Infrastructure.Persistence.Contexts;
using SovtechOpenApiTest.Infrastructure.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SovtechOpenApiTest.Infrastructure.Persistence.Repositories
{
  
    public class CategoryRepositoryAsync : GenericRepositoryAsync<Category>, ICategoryRepositoryAsync
    {
        private readonly DbSet<Category> _categories;

        public CategoryRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _categories = dbContext.Set<Category>();
        }

        public Task<bool> IsUniqueNameAsync(string name)
        {
            return _categories
                .AllAsync(p => p.Name != name);
        }
    }
}
