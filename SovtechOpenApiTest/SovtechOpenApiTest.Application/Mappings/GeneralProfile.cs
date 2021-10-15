using AutoMapper;
using SovtechOpenApiTest.Application.Features.Chuck.Queries;
using SovtechOpenApiTest.Application.Features.Products.Commands.CreateProduct;
using SovtechOpenApiTest.Application.Features.Products.Queries.GetAllProducts;
using SovtechOpenApiTest.Application.Features.Swapi.Queries;
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
            CreateMap<Person, GetAllPeopleViewModel>().ReverseMap();
            CreateMap<Category, GetAllCategoriesViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<GetAllProductsQuery, GetAllProductsParameter>();
            CreateMap<GetAllCategoriesQuery, GetAllCategoriesParameter>();
        }
    }
}
