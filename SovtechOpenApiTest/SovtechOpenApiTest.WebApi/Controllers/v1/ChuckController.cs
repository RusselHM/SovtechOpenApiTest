using Microsoft.AspNetCore.Mvc;
using SovtechOpenApiTest.Application.Features.Chuck.Queries.GetAllCategories;
using SovtechOpenApiTest.Application.Features.Chuck.Queries.GetCategoryDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovtechOpenApiTest.WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    public class ChuckController : BaseApiController
    {
        // GET: api/<controller>
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            return Ok(await Mediator.Send(new GetAllCategoriesQuery() {  }));
        }
        // GET: api/<controller>
        [HttpGet]
        public async Task<IActionResult> GetDetails([FromQuery] string searchString)
        {

            return Ok(await Mediator.Send(new GetCategoryDetailsQuery() { SearchString = searchString }));
        }
    }
}
