using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using SovtechOpenApiTest.Application.Interfaces;
using SovtechOpenApiTest.Domain.Entities;
using SovtechOpenApiTest.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SovtechOpenApiTest.Infrastructure.Persistence.Repository
{
    public class GenericRepositoryAsync<T> : IGenericRepositoryAsync<T> where T : class
    {
        private readonly ApplicationDbContext _dbContext;
        private const string URL = "https://api.chucknorris.io/jokes/categories/";
        //private string urlParameters = "?api_key=123";

        public GenericRepositoryAsync(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> GetPagedReponseAsync(int pageNumber, int pageSize)
        {
            return await _dbContext
                .Set<T>()
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .AsNoTracking()
                .ToListAsync();
        }
        public async  Task<List<Category>> GetReponseApiAsync()
        {
            var categories = new List<Category>();
            using (var client = new HttpClient())
            {
                var uri = new Uri("https://api.chucknorris.io/jokes/categories");
                CategoryVM vm = new CategoryVM();
                var response = client.GetAsync(uri).Result;

                if (!response.IsSuccessStatusCode)
                    throw new Exception(response.ToString());

                var responseContent = response.Content;
                var responseString = responseContent.ReadAsStringAsync().Result;
               
                dynamic itemArray = JArray.Parse(responseString) as JArray;
                foreach(var item in itemArray)
                {
                    var data = new Category
                    {
                        Name = item
                    };
                    categories.Add(data);
                }
               
              
            }

            return categories;
        }
        public async Task<Person> GetSwapiReponseApiAsync(int pageNumber)
        {
            var result = new Person();
            using (var client = new HttpClient())
            {
                var uri = new Uri("https://swapi.dev/api/people/");
               
                var response = client.GetAsync(uri).Result;

                if (!response.IsSuccessStatusCode)
                    throw new Exception(response.ToString());

                var responseContent = response.Content;
                var responseString =   responseContent.ReadAsStringAsync().Result;
                 result = JsonConvert.DeserializeObject<Person>(responseString);
                //dynamic itemArray = JArray.Parse(responseString) as JArray;
                

            }

            return result;
        }
        public async Task<List<SearchInfo>> GetSearchByIdAsync(int id)
        {

            List<SearchInfo> categories = new List<SearchInfo>();
            var client = new RestClient($"(https://api.chucknorris.io/jokes/categories)");
            var request = new RestRequest(Method.GET);
            IRestResponse response = await client.ExecuteAsync(request);
            var listResponse = await client.ExecuteAsync<List<SearchInfo>>(request);

            if (response.IsSuccessful)
            {


                foreach (var category in listResponse.Data.ToList<SearchInfo>())
                {
                    var categoryName = new SearchInfo
                    {
                        Name = category.Name
                    };
                    categories.Add(categoryName);
                }


                return categories;

            }
            else
            {
                return null;
            }
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _dbContext
                 .Set<T>()
                 .ToListAsync();
        }
    }
}
