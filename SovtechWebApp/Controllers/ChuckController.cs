using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SovtechOpenApiTest.Application.Features.Chuck.Queries.GetCategoryDetails;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Helpers;

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
            string data = "";
            List<GetAllCategoriesViewModel> model = new List<GetAllCategoriesViewModel>();
            var strings = new List<string>();
            try
            {
                string apiUrl = "http://localhost:57712/api/v1.0/Chuck";

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                          data = await response.Content.ReadAsStringAsync();
                        model = Newtonsoft.Json.JsonConvert.DeserializeObject<List<GetAllCategoriesViewModel>>(data);
                        var table = Newtonsoft.Json.JsonConvert.DeserializeObject<DataTable>(data);

                    }


                }
            }
            catch (Exception ex)
            {

            }
            //var data = DB.tblStuds.ToList();
            return Json(model);
        }
        public async Task<ActionResult> GetCategoryDetails([FromQuery] string category)
        {

            try
            {
                string apiUrl = "http://localhost:57712/api/v1.0/Chuck/" + category;

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
