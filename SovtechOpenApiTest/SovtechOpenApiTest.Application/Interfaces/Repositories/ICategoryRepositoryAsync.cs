using SovtechOpenApiTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SovtechOpenApiTest.Application.Interfaces.Repositories
{
  
    public interface ICategoryRepositoryAsync : IGenericRepositoryAsync<Category>
    {
        Task<bool> IsUniqueNameAsync(string namee);
    }
}
