﻿using Microsoft.AspNetCore.Mvc;
using SovtechOpenApiTest.Application.Features.Swapi.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovtechOpenApiTest.WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    public class SwapiController : BaseApiController
    {
        // GET: api/<controller>
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] int filter)
        {

            return Ok(await Mediator.Send(new GetAllPeopleQuery() {  PageNumber = filter }));
        }
    }
}
