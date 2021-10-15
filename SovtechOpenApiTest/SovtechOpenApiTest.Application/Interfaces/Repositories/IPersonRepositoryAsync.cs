using SovtechOpenApiTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SovtechOpenApiTest.Application.Interfaces.Repositories
{
  
    public interface IPersonRepositoryAsync : IGenericRepositoryAsync<Person>
    {
        Task<bool> IsUniquePersonAsync(string namee);
    }
}
