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
        /// <summary>
        /// For getting all the chuck jokes 
        /// </summary>
        /// 
        /// <returns>Jokes</returns>
        // GET api/<controller>/searchTerm
        // GET: api/<controller>
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            return Ok(await Mediator.Send(new GetAllCategoriesQuery() {  }));
        }
        /// <summary>
        /// Gets details about a Chuck joke
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <returns></returns>
        // GET api/<controller>/searchTerm
        [HttpGet("{searchString}")]
        public async Task<IActionResult> GetDetails(string searchString)
        {

            return Ok(await Mediator.Send(new GetCategoryDetailsQuery() { SearchString = searchString }));
        }
    }
}
