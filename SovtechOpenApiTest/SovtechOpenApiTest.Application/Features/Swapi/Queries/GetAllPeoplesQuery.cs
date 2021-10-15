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
    
    public class GetAllPeopleQuery : IRequest<List<GetAllPeopleViewModel>>
    {
        
    }
    public class GetAllPeopleQueryHandler : IRequestHandler<GetAllPeopleQuery, List<GetAllPeopleViewModel>>
    {
        private readonly IPersonRepositoryAsync _peopleRepository;
        private readonly IMapper _mapper;
        public GetAllPeopleQueryHandler(IPersonRepositoryAsync peopleRepository, IMapper mapper)
        {
            _peopleRepository = peopleRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllPeopleViewModel>> Handle(GetAllPeopleQuery request, CancellationToken cancellationToken)
        {
            var validFilter = _mapper.Map<GetAllPeopleParameter>(request);
            var category = await _peopleRepository.GetReponseApiAsync();
            var categoryViewModel = _mapper.Map<IEnumerable<GetAllPeopleViewModel>>(category);
            return new List<GetAllPeopleViewModel>(categoryViewModel);
        }
    }
}
