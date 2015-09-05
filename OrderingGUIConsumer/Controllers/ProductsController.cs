using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace OrderingGUIConsumer.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Json(string state, string choice)
        {
            //getting json from a url
            //WebRequest request = WebRequest.Create("http://api.geonames.org/citiesJSON?north=44.1&south=-9.9&east=-22.4&west=55.2&lang=de&username=demo");

            //WebRequest request1 = WebRequest.Create("http://192.168.1.64:4782/PCatServiceCatalog/api/Consumer/location&package1");
            //WebRequest request2 = WebRequest.Create("http://192.168.1.64:4782/PCatServiceCatalog/api/Consumer/"+state+"&"+choice);
            WebRequest request2 = WebRequest.Create("http://localhost:8080/PCatServiceCatalogue/api/Consumer/" + state + "&" + choice);
            //permanent jenkins url
            //WebRequest request2 = WebRequest.Create("http://192.168.1.240:8080/PCatServiceCatalogue/api/Consumer/" + state + "&" + choice);
            //WebRequest request3 = WebRequest.Create("http://192.168.1.64:4782/PCatServiceCatalog/api/Consumer/location&package1&package2&package3");
            //string s;
           WebResponse response = request2.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string result = reader.ReadToEnd();

            //getting json from local file
            //string result = System.IO.File.ReadAllText(@"C:\Users\Administrator\Documents\Visual Studio 2015\Projects\OrderingGUIConsumerFrostic\OrderingGUIConsumer\jsonfile\Products.json");

            //JavaScriptSerializer serializer = new JavaScriptSerializer();
            //string json = serializer.Serialize<Rootobject2>(result);

            //now revert it back as objects
            //Geoname names = serializer.Deserialize<Geoname>(json);
            //return names;
            return Json(result, JsonRequestBehavior.AllowGet);
        }


    }
}