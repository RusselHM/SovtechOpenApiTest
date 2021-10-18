using System;
using System.Collections.Generic;
using System.Text;

namespace SovtechOpenApiTest.Application.Features.Chuck.Queries.GetCategoryDetails
{
    public class GetCategoryDetailsViewModel
    {
        public string  Name { get; set; }
    }
    public class DogItem
    {
        public string name { get; set; }
        public string breed { get; set; }
        public int count { get; set; }
        public string twoFeet { get; set; }
    }

    public class Cat
    {
        public string name { get; set; }
    }

    public class Animals
    {
        public List<DogItem> dog { get; set; }
        public Cat cat { get; set; }
    }

    public class Root
    {
        public Animals animals { get; set; }
    }
}
