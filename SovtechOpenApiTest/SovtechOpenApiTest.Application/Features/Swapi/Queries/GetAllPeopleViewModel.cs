using System;
using System.Collections.Generic;
using System.Text;

namespace SovtechOpenApiTest.Application.Features.Swapi.Queries
{

    public class Results
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string Mass { get; set; }
        public string HairColor { get; set; }
        public string SkinColor { get; set; }
        public string EyeColor { get; set; }
        public string BirthYear { get; set; }
        public string Gender { get; set; }
        public string Homeworld { get; set; }
        public List<string> Films { get; set; }
        public List<string> Species { get; set; }
        public List<string> Vehicles { get; set; }
        public List<string> Starships { get; set; }
        public string Created { get; set; }
        public string Edited { get; set; }
        public string Url { get; set; }
    }

    public class GetAllPeopleViewModel
    {
        //public int count { get; set; }
        //public string next { get; set; }
        //public string previous { get; set; }
        public List<Results> Results { get; set; }
    }
}
