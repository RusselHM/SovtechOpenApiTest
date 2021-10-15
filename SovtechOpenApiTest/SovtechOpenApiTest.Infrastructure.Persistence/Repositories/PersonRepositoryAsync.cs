using Microsoft.EntityFrameworkCore;
using SovtechOpenApiTest.Application.Interfaces.Repositories;
using SovtechOpenApiTest.Domain.Entities;
using SovtechOpenApiTest.Infrastructure.Persistence.Contexts;
using SovtechOpenApiTest.Infrastructure.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace SovtechOpenApiTest.Infrastructure.Persistence.Repositories
{
    
    public class PersonRepositoryAsync : GenericRepositoryAsync<Person>, IPersonRepositoryAsync
    {
        private readonly DbSet<Person> _people;

        public PersonRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _people = dbContext.Set<Person>();
        }

        public Task<bool> IsUniquePersonAsync(string name)
        {
            return _people
                .AllAsync(p => p.results.Select(x => x.Name.ToString()).FirstOrDefault() != name);
        }
    }
}
