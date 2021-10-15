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
            List<GetAllCategoriesViewModel> resultList = new List<GetAllCategoriesViewModel>();
            
            var categories = await _categoryRepository.GetReponseApiAsync();
            //var categoryViewModel = _mapper.Map<IEnumerable<GetAllCategoriesViewModel>>(categories); // Can't Use mapper due to time
            foreach(var item in categories)
            {
                var vmItem = new GetAllCategoriesViewModel
                {
                    Name = item.Name
                };
                resultList.Add(vmItem);
            }
            return new List<GetAllCategoriesViewModel>(resultList);
        }
    }
}
