using AutoMapper;
using MediatR;
using SovtechOpenApiTest.Application.Interfaces.Repositories;
using SovtechOpenApiTest.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SovtechOpenApiTest.Application.Features.Chuck.Queries
{
    
    public class GetAllCategoriesQuery : IRequest<List<GetAllCategoriesViewModel>>
    {
        
    }
    public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, List<GetAllCategoriesViewModel>>
    {
        private readonly ICategoryRepositoryAsync _categoryRepository;
        private readonly IMapper _mapper;
        public GetAllCategoriesQueryHandler(ICategoryRepositoryAsync categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllCategoriesViewModel>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            
            var category = await _categoryRepository.GetReponseApiAsync();
            var categoryViewModel = _mapper.Map<IEnumerable<GetAllCategoriesViewModel>>(category);
            return new List<GetAllCategoriesViewModel>(categoryViewModel);
        }
    }
}
