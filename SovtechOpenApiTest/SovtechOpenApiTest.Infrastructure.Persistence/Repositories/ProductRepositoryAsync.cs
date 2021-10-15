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
    public class ProductRepositoryAsync : GenericRepositoryAsync<Product>, IProductRepositoryAsync
    {
        private readonly DbSet<Product> _products;

        public ProductRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _products = dbContext.Set<Product>();
        }

        public Task<bool> IsUniqueBarcodeAsync(string barcode)
        {
            return _products
                .AllAsync(p => p.Barcode != barcode);
        }
    }
}
