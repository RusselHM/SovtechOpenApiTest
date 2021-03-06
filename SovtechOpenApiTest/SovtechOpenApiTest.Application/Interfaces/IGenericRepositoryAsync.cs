using SovtechOpenApiTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SovtechOpenApiTest.Application.Interfaces
{
    public interface IGenericRepositoryAsync<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<IReadOnlyList<T>> GetPagedReponseAsync(int pageNumber, int pageSize);
        Task<SearchInfo> Search(string searchString);
        Task<List<Category>> GetReponseApiAsync();
        Task<Person> GetSwapiReponseApiAsync(int pageNumber, int pageSize);
        Task<CategoryDetails> GetReponseDetailsApiAsync(string searchString);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
