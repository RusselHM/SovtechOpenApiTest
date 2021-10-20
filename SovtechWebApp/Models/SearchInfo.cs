using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovtechWebApp.Models
{
    public class SearchInfo
    {
        /// <summary>
        /// Chuck Items
        /// </summary>
        public ChuckResult Chuck { get; set; }
        /// <summary>
        /// Swapi Item
        /// </summary>
        public SwapiResult Swapi { get; set; }
    }
    public class SwapiItem
    {

        /// Returned a field from swapi
        /// Swapi
        /// Swapi Property
        public string name { get; set; }
        /// Returned a field from swapi
        /// Swapi
        /// Swapi Property
        public string height { get; set; }
        /// Returned a field from swapi
        /// Swapi
        /// Swapi Property
        public string mass { get; set; }
        /// Returned a field from swapi
        /// Swapi
        /// Swapi Property
        public string hair_color { get; set; }
        /// Returned a field from swapi
        /// Swapi
        /// Swapi Property
        public string skin_color { get; set; }
        /// Returned a field from swapi
        /// Swapi
        /// Swapi Property
        public string eye_color { get; set; }
        /// Returned a field from swapi
        /// Swapi
        /// Swapi Property
        public string birth_year { get; set; }
        /// Returned a field from swapi
        /// Swapi
        /// Swapi Property
        public string gender { get; set; }
        /// Returned a field from swapi
        /// Swapi
        /// Swapi Property
        public string homeworld { get; set; }
        /// Returned a field from swapi
        /// Swapi
        /// Swapi Property
        public List<string> films { get; set; }
        /// Returned a field from swapi
        /// Swapi
        /// Swapi Property
        public List<string> species { get; set; }
        /// Returned a field from swapi
        /// Swapi
        /// Swapi Property
        public List<string> vehicles { get; set; }
        /// Returned a field from swapi
        /// Swapi
        /// Swapi Property
        public List<string> starships { get; set; }
        /// Returned a field from swapi
        /// Swapi
        /// Swapi Property
        public string created { get; set; }
        /// Returned a field from swapi
        /// Swapi
        /// Swapi Property
        public string edited { get; set; }
        /// Returned a field from swapi
        /// Swapi
        /// Swapi Property
        public string url { get; set; }
    }

    public class SwapiResult
    {

        /// Returned a field from swapi
        /// Swapi
        /// Swapi Property
        public int count { get; set; }
        /// Returned a field from swapi
        /// Swapi
        /// Swapi Property
        public string next { get; set; }
        /// Returned a field from swapi
        /// Swapi
        /// Swapi Property
        public string previous { get; set; }
        /// Returned a field from swapi
        /// Swapi
        /// Swapi Property
        public List<SwapiItem> results { get; set; }
    }


    public class ChuckItem
    {

        /// Returned a field from Chuck
        /// Chuck
        /// Chuck Property
        public List<string> categories { get; set; }
        /// Returned a field from Chuck
        /// Chuck
        /// Chuck Property
        public string created_at { get; set; }
        /// Returned a field from Chuck
        /// Chuck
        /// Chuck Property
        public string icon_url { get; set; }
        /// Returned a field from Chuck
        /// Chuck
        /// Chuck Property
        public string id { get; set; }
        /// Returned a field from Chuck
        /// Chuck
        /// Chuck Property
        public string updated_at { get; set; }
        /// Returned a field from Chuck
        /// Chuck
        /// Chuck Property
        public string url { get; set; }
        /// Returned a field from Chuck
        /// Chuck
        /// Chuck Property
        public string value { get; set; }
    }

    public class ChuckResult
    {

        /// Returned a field from Chuck
        /// Chuck
        /// Chuck Property
        public int total { get; set; }
        /// Returned a field from Chuck
        /// Chuck
        /// Chuck Property
        public List<ChuckItem> result { get; set; }
    }
}
