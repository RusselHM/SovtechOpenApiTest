using System;
using System.Collections.Generic;
using System.Text;

namespace SovtechOpenApiTest.Application.Features.Chuck.Queries.GetCategoryDetails
{
    public class GetCategoryDetailsViewModel
    {
        public List<string> categories { get; set; }
        public string created_at { get; set; }
        public string icon_url { get; set; }
        public string id { get; set; }
        public string updated_at { get; set; }
        public string url { get; set; }
        public string value { get; set; }
    }
    
}
