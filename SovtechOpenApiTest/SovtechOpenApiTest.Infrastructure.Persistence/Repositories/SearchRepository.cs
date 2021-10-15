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
    public class SearchRepositoryAsync : GenericRepositoryAsync<SearchInfo>, ISearchRepositoryAsync
    {

        private readonly DbSet<SearchInfo> _results;

        public SearchRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _results = dbContext.Set<SearchInfo>();
        }

        public Task<bool> IsUniqueResultsAsync(string name)
        {
            return _results
                .AllAsync(p => p.Name != name);
        }
    }
}
