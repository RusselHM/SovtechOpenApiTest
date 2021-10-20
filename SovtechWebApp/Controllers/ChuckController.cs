using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SovtechWebApp.Controllers
{
    public class ChuckController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> GetCategories()
        {
            try
            {
                string apiUrl = "http://localhost:58764/api/values";

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        var data = await response.Content.ReadAsStringAsync();
                        var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);

                    }


                }
            }
            catch (Exception ex)
            {

            }
            //var data = DB.tblStuds.ToList();
            return PartialView();
        }
        public async Task<ActionResult> GetCategoryDetails(string category)
        {

            try
            {
                string apiUrl = "http://localhost:58764/api/values";

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        var data = await response.Content.ReadAsStringAsync();
                        var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);

                    }


                }
            }
            catch (Exception ex)
            {

            }
            //var data = DB.tblStuds.ToList();
            return PartialView();
        }
    }
}
