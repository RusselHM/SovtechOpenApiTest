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
    
    public class GetAllPeopleQuery : IRequest<GetAllPeopleViewModel>
    {
        public int PageNumber { get; set; }
     
    }
    public class GetAllPeopleQueryHandler : IRequestHandler<GetAllPeopleQuery, GetAllPeopleViewModel>
    {
        private readonly IPersonRepositoryAsync _peopleRepository;
        private readonly IMapper _mapper;
        public GetAllPeopleQueryHandler(IPersonRepositoryAsync peopleRepository, IMapper mapper)
        {
            _peopleRepository = peopleRepository;
            _mapper = mapper;
        }

        public async Task<GetAllPeopleViewModel> Handle(GetAllPeopleQuery request, CancellationToken cancellationToken)
        {
            //var validFilter = _mapper.Map<GetAllPeopleParameter>(request);
            var category = await _peopleRepository.GetSwapiReponseApiAsync(request.PageNumber);
            
            var categoryViewModel = _mapper.Map<GetAllPeopleViewModel>(category);
            return  categoryViewModel;
        }
    }
}
