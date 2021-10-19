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
        /// gets all categories of jokes
        /// from chuck
        /// Hlayiseka 2021-10-19
        /// returns list of categories
        // GET: api/<controller>
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            return Ok(await Mediator.Send(new GetAllCategoriesQuery() {  }));
        }
        /// gets details about a category
        /// from chuck
        /// Hlayiseka 2021-10-19
        /// returns the details
        //GET: api/<controller>/5
        [HttpGet("{searchString}")]
        public async Task<IActionResult> GetDetails(string searchString)
        {

            return Ok(await Mediator.Send(new GetCategoryDetailsQuery() { SearchString = searchString }));
        }
    }
}
