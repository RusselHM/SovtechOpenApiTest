using AutoMapper;
using SovtechOpenApiTest.Application.Features.Chuck.Queries;
using SovtechOpenApiTest.Application.Features.Chuck.Queries.GetAllCategories;
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
            CreateMap<Person, GetAllPeopleViewModel>()
                .ForMember(d => d.Results, opt => opt.MapFrom(src => src.results)).ReverseMap();
                //.ForMember(d => d.count, opt => opt.MapFrom(src => src.results))
                //.ForMember(d => d.previous, opt => opt.MapFrom(src => src.results))
                //.ForMember(d => d.next, opt => opt.MapFrom(src => src.results)).ReverseMap();
            CreateMap<Category, GetAllCategoriesViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<GetAllPeopleQuery, Person>();
            CreateMap<GetAllProductsQuery, GetAllProductsParameter>();
            CreateMap<GetAllCategoriesQuery, GetAllCategoriesParameter>();
            CreateMap<GetAllPeopleQuery, GetAllPeopleParameter>();
        }
    }
}
