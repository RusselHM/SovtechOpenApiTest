using AutoMapper;
using SovtechOpenApiTest.Application.Features.Chuck.Queries;
using SovtechOpenApiTest.Application.Features.Products.Commands.CreateProduct;
using SovtechOpenApiTest.Application.Features.Products.Queries.GetAllProducts;
using SovtechOpenApiTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SovtechOpenApiTest.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Product, GetAllProductsViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<GetAllProductsQuery, GetAllProductsParameter>();
            CreateMap<GetAllCategoriesQuery, GetAllCategoriesParameter>();
        }
    }
}
