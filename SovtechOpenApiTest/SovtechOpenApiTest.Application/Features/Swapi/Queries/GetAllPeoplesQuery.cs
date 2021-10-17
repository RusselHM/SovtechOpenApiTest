using AutoMapper;
using MediatR;
using SovtechOpenApiTest.Application.Interfaces.Repositories;
using SovtechOpenApiTest.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SovtechOpenApiTest.Application.Features.Swapi.Queries
{
    
    public class GetAllPeopleQuery : IRequest<PagedResponse<GetAllPeopleViewModel>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

    }
    public class GetAllPeopleQueryHandler : IRequestHandler<GetAllPeopleQuery, PagedResponse<GetAllPeopleViewModel>>
    {
        private readonly IPersonRepositoryAsync _peopleRepository;
        private readonly IMapper _mapper;
        public GetAllPeopleQueryHandler(IPersonRepositoryAsync peopleRepository, IMapper mapper)
        {
            _peopleRepository = peopleRepository;
            _mapper = mapper;
        }

        public async Task<PagedResponse<GetAllPeopleViewModel>> Handle(GetAllPeopleQuery request, CancellationToken cancellationToken)
        {
            var validFilter = _mapper.Map<GetAllPeopleParameter>(request);
            var category = await _peopleRepository.GetSwapiReponseApiAsync(validFilter.PageNumber, validFilter.PageSize);
            
            var categoryViewModel = _mapper.Map<GetAllPeopleViewModel>(category);

            return  new PagedResponse<GetAllPeopleViewModel>(categoryViewModel, validFilter.PageNumber, validFilter.PageSize);
        }
    }
}
