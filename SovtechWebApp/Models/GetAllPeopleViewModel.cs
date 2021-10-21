using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovtechWebApp.Models
{
    //public class ResultsItem
    //{
    //    public string Name { get; set; }
    //    public string Height { get; set; }
    //    public string Mass { get; set; }
    //    public string HairColor { get; set; }
    //    public string SkinColor { get; set; }
    //    public string EyeColor { get; set; }
    //    public string BirthYear { get; set; }
    //    public string Gender { get; set; }
    //    public string Homeworld { get; set; }
    //    public List<string> Films { get; set; }
    //    public List<string> Species { get; set; }
    //    public List<string> Vehicles { get; set; }
    //    public List<string> Starships { get; set; }
    //    public string Created { get; set; }
    //    public string Edited { get; set; }
    //    public string Url { get; set; }
    //}

    //public class GetAllPeopleViewModel
    //{
    //    //public int count { get; set; }
    //    //public string next { get; set; }
    //    //public string previous { get; set; }
    //    public List<ResultsItem> results { get; set; }
    //}
    public partial class GetAllPeopleViewModel
    {
        [JsonProperty("pageNumber")]
        public long PageNumber { get; set; }

        [JsonProperty("pageSize")]
        public long PageSize { get; set; }

        [JsonProperty("succeeded")]
        public bool Succeeded { get; set; }

        [JsonProperty("message")]
        public object Message { get; set; }

        [JsonProperty("errors")]
        public object Errors { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }
    public partial class Data
    {
        [JsonProperty("results")]
        public Result[] Results { get; set; }
    }
    public partial class Result
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("height")]
     
        public string Height { get; set; }

        [JsonProperty("mass")]
 
        public string Mass { get; set; }

        [JsonProperty("hairColor")]
        public string HairColor { get; set; }

        [JsonProperty("skinColor")]
        public string SkinColor { get; set; }

        [JsonProperty("eyeColor")]
        public string EyeColor { get; set; }

        [JsonProperty("birthYear")]
        public string BirthYear { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("homeworld")]
        public Uri Homeworld { get; set; }

        [JsonProperty("films")]
        public Uri[] Films { get; set; }

        [JsonProperty("species")]
        public Uri[] Species { get; set; }

        [JsonProperty("vehicles")]
        public Uri[] Vehicles { get; set; }

        [JsonProperty("starships")]
        public Uri[] Starships { get; set; }

        [JsonProperty("created")]
        public DateTimeOffset Created { get; set; }

        [JsonProperty("edited")]
        public DateTimeOffset Edited { get; set; }

        [JsonProperty("url")]
        public DateTimeOffset Url { get; set; }
    }

}
