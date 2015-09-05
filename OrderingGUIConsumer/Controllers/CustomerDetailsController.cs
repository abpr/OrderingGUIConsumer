using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderingGUIConsumer.Models;

namespace OrderingGUIConsumer.Controllers
{
    public class CustomerDetailsController : Controller
    {

        // GET: CustomerDetails
        public ActionResult Details()
        {
            return View();
        }

        public string ToState(string email,string strFirstName, string strLastName,string streetName, string numZipcode, string strCity, string strState, string numStateId, string dobirth)
        {
            int zipcode = Convert.ToInt32(numZipcode);
            int stateId = Convert.ToInt16(numStateId);
            DateTime dob = Convert.ToDateTime(dobirth);
            DetailsModel objDetailsModel = new DetailsModel();
            return objDetailsModel.insertDetails(email, strFirstName, strLastName, streetName, zipcode, strCity, strState, stateId, dob);            
        }
    }
}