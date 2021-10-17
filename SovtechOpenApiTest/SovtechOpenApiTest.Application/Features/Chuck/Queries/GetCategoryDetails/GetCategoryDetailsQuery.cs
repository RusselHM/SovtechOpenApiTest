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
    
    public class GetCategoryDetailsQuery : IRequest<List<GetCategoryDetailsViewModel>>
    {
        public string SearchString { get; set; }
      
    }
    public class GetCategoryDetailssQueryHandler : IRequestHandler<GetCategoryDetailsQuery, List<GetCategoryDetailsViewModel>>
    {
        private readonly ICategoryRepositoryAsync _categoryRepository;
        private readonly IMapper _mapper;
        public GetCategoryDetailssQueryHandler(ICategoryRepositoryAsync categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<List<GetCategoryDetailsViewModel>> Handle(GetCategoryDetailsQuery request, CancellationToken cancellationToken)
        {
            List<GetCategoryDetailsViewModel> resultList = new List<GetCategoryDetailsViewModel>();
            
            var categories = await _categoryRepository.GetReponseApiAsync();
            //var categoryViewModel = _mapper.Map<IEnumerable<GetCategoryDetailssViewModel>>(categories); // Can't Use mapper due to time
            foreach(var item in categories)
            {
                var vmItem = new GetCategoryDetailsViewModel
                {
                    Name = item.Name
                };
                resultList.Add(vmItem);
            }
            return new List<GetCategoryDetailsViewModel>(resultList);
        }
    }
}
