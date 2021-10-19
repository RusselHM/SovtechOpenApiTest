using MediatR;
using SovtechOpenApiTest.Application.Exceptions;
using SovtechOpenApiTest.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;
using SovtechOpenApiTest.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using SovtechOpenApiTest.Application.Interfaces.Repositories;

namespace SovtechOpenApiTest.Application.Features.Search.Queries
{
  
    public class GetInfoByIdQuery : IRequest<Response<SearchInfo>>
    {
        public string searchTerm { get; set; }
        public class GetInfoByIdQueryHandler : IRequestHandler<GetInfoByIdQuery, Response<SearchInfo>>
        {
            private readonly ISearchRepositoryAsync _searchRepository;
            public GetInfoByIdQueryHandler(ISearchRepositoryAsync searchRepository)
            {
                _searchRepository = searchRepository;
            }
            public async Task<Response<SearchInfo>> Handle(GetInfoByIdQuery query, CancellationToken cancellationToken)
            {
                var Search = await _searchRepository.Search(query.searchTerm);
                if (Search == null) throw new ApiException($"Search Not Found.");
                return new Response<SearchInfo>(Search);
            }
        }
    }
}
