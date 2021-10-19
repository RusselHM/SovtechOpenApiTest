using MediatR;
using Microsoft.AspNetCore.Mvc;
using SovtechOpenApiTest.Application.Features.Search.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovtechOpenApiTest.WebApi.Controllers.v1
{
    public class SearchController : BaseApiController
    {
        // GET api/<controller>/searchTerm
        [HttpGet("{searchTerm}")]
        public async Task<IActionResult> Get(int searchTerm)
        {
            return Ok(await Mediator.Send(new GetInfoByIdQuery { Id = searchTerm }));
        }
    }
}
