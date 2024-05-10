using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Weather.Models;
using System;
using System.Diagnostics;
using System.Net;
using System.Reflection;

namespace Weather.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.msg = "";
            return View();
        }
        [HttpPost]
        public IActionResult Index(string id)
        {
            Rootobject response = new Rootobject();

            try
            {

                if (!string.IsNullOrEmpty(id))
                {


                    var url = "https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/";

                    var model = new
                    {
                        key = "3C8TRCWYPKSPU83H6U8CJ5CUR",
                        unitGroup = "us",
                        location = id,
                    };

                    // Ignore certificate validation
                    ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                    // Create the request
                    HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;

                    // Set the request method to POST
                    request.Method = "POST";

                    // Set the content type to JSON
                    request.ContentType = "application/json";

                    // Write the JSON payload to the request stream
                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        string json = JsonConvert.SerializeObject(model);
                        streamWriter.Write(json);
                        streamWriter.Flush();
                    }

                    // Get the response
                    using (HttpWebResponse webResponse = (HttpWebResponse)request.GetResponse())
                    using (StreamReader responseReader = new StreamReader(webResponse.GetResponseStream()))
                    {
                        string respp = responseReader.ReadToEnd();
                        if (!string.IsNullOrEmpty(respp) && respp != null)
                        {
                            response = JsonConvert.DeserializeObject<Rootobject>(respp);
                        }
                        else
                        {
                            ViewBag.msg = "Data Is Not Found..!";
                        }
                    }
                }
                else
                {
                    ViewBag.msg = "Please Fill the Input..!";
                }
            }
            catch (Exception)
            {

                throw;
            }
            return View(response);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
