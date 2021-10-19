using System;
using System.Collections.Generic;
using System.Text;

namespace SovtechOpenApiTest.Domain.Entities
{
    public class SearchInfo
    {
        public ChuckResult Chuck{ get; set; }
        public SwapiResult Swapi { get; set; }
    }
    public class SwapiItem
    {

        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mass { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string hair_color { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string skin_color { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string eye_color { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string birth_year { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string gender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string homeworld { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> films { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> species { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> vehicles { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> starships { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string created { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string edited { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
    }

    public class SwapiResult
    {

        /// <summary>
        /// 
        /// </summary>
        public int count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string next { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string previous { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<SwapiItem> results { get; set; }
    }


    public class ChuckItem
    {

        /// <summary>
        /// 
        /// </summary>
        public List<string> categories { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string created_at { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string icon_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string updated_at { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string value { get; set; }
    }

    public class ChuckResult
    {

        /// <summary>
        /// 
        /// </summary>
        public int total { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ChuckItem> result { get; set; }
    }


}
