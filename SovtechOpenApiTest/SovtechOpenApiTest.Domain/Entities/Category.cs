using System;
using System.Collections.Generic;
using System.Text;

namespace SovtechOpenApiTest.Domain.Entities
{
    public class Category
    {
       
        public string Name { get; set; }
    }
    public class CategoryVM
    {
        public List<Category> Categories { get; set; }
    }
}
