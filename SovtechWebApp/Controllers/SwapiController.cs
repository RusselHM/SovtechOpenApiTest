using Microsoft.AspNetCore.Mvc;
using SovtechWebApp.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace SovtechWebApp.Controllers
{
    public class SwapiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> GetSwapi()
        {
            GetAllPeopleViewModel model = new GetAllPeopleViewModel();
            List<Result> tempRes = new List<Result>();
            int pageNumber = 1, pageSize = 10;
            try
            {
                string sub = "?PageNumber=" + pageNumber.ToString() + "&PageSize=" + pageSize.ToString();

                string apiUrl = "http://localhost:57712/api/v1.0/Swapi" + sub;

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        var data = await response.Content.ReadAsStringAsync();
                        model = Newtonsoft.Json.JsonConvert.DeserializeObject<GetAllPeopleViewModel>(data);
                        var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);


                    }


                }
            }
            catch (Exception ex)
            {

            }
            //var data = DB.tblStuds.ToList();
            return Json(model);
        }
    }
}
