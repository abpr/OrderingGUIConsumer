using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace OrderingGUIConsumer.Controllers
{
    public class SendOrderController : Controller
    {
        // GET: SendOrder
        public string Send(string json)
        {
            string OrderId;
            using (WebClient client = new WebClient())
            {
                OrderId=client.UploadString("http://localhost:8080/OrderManagement/rest/om/submitorder", json);
            }
            //WebRequest request = WebRequest.Create("http://192.168.1.19:8080/OrderManagement/rest/om/submitorder");
            //request.Method = "POST";
            //request.ContentType = "application/json";
            //Stream dataStream = request.GetRequestStream();
            //dataStream.Write(json, 0, json.Length);
            //WebResponse response = request.GetResponse();
            //StreamReader reader = new StreamReader(response.GetResponseStream());
            //string result = reader.ReadToEnd();
            return OrderId;
        }
    }
}