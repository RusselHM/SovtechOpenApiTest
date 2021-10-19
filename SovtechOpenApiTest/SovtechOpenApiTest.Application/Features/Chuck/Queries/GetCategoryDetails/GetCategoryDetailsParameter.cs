using SovtechOpenApiTest.Application.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace SovtechOpenApiTest.Application.Features.Chuck.Queries.GetCategoryDetails
{
    
    public class GetCategoryDetailsParameter : RequestParameter
    {
        public string SearchString { get; set; }
    }
}
