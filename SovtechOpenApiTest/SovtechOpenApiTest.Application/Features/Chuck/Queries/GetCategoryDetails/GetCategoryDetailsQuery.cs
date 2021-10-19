using AutoMapper;
using MediatR;
using SovtechOpenApiTest.Application.Interfaces.Repositories;
using SovtechOpenApiTest.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SovtechOpenApiTest.Application.Features.Chuck.Queries.GetCategoryDetails
{
    
    public class GetCategoryDetailsQuery : IRequest<GetCategoryDetailsViewModel>
    {
        public string SearchString { get; set; }
      
    }
    public class GetCategoryDetailsQueryHandler : IRequestHandler<GetCategoryDetailsQuery, GetCategoryDetailsViewModel>
    {
        private readonly ICategoryRepositoryAsync _categoryRepository;
        private readonly IMapper _mapper;
        public GetCategoryDetailsQueryHandler(ICategoryRepositoryAsync categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<GetCategoryDetailsViewModel> Handle(GetCategoryDetailsQuery request, CancellationToken cancellationToken)
        {
            
            var validFilter = _mapper.Map<GetCategoryDetailsParameter>(request);
            List<GetCategoryDetailsViewModel> resultList = new List<GetCategoryDetailsViewModel>();
            
            var categoryDetails = await _categoryRepository.GetReponseDetailsApiAsync(validFilter.SearchString);
            //var categoryViewModel = _mapper.Map<IEnumerable<GetCategoryDetailssViewModel>>(categories); // Can't Use mapper due to time

            var category = new GetCategoryDetailsViewModel
            {
                categories = categoryDetails.categories,
                created_at = categoryDetails.created_at,
                icon_url = categoryDetails.icon_url,
                id= categoryDetails.id,
                updated_at = categoryDetails.updated_at,
                url = categoryDetails.url,
                value = categoryDetails.value
                    
            };

            return category;
        }
    }
}
