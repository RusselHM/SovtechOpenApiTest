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
            GetAllPeopleViewModel results =new  GetAllPeopleViewModel();
            List<ResultsItem> tempRes = new List<ResultsItem>();
            var validFilter = _mapper.Map<GetAllPeopleParameter>(request);
            var category = await _peopleRepository.GetSwapiReponseApiAsync(validFilter.PageNumber, validFilter.PageSize);
            foreach (var item in category.results)
            {
                var person = new ResultsItem
                {
                    Name = item.name,
                    Height = item.height,
                    Mass = item.mass,
                    HairColor = item.hair_color,
                    SkinColor =item.skin_color,
                    EyeColor = item.eye_color,
                    BirthYear =item.birth_year,
                    Gender = item.gender,
                    Homeworld =item.homeworld,
                    Created =item.created,
                    Edited=item.edited,
                    Url =item.created,
                    Films = item.films,
                    Species = item.species,
                    Vehicles = item.vehicles,
                    Starships = item.starships

                };
                tempRes.Add(person);
            }
            //var categoryViewModel = _mapper.Map<GetAllPeopleViewModel>(category);

            var viewModel = new GetAllPeopleViewModel
            {
                Results = tempRes
            };
            return  new PagedResponse<GetAllPeopleViewModel>(viewModel, validFilter.PageNumber, validFilter.PageSize);
        }
    }
}
