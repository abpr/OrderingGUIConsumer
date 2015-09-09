using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderingGUIConsumer.Models;

namespace OrderingGUIConsumer.Controllers
{
    public class PortalController : Controller
    {

        public ActionResult Index()
        {
            PortalModel details = new PortalModel();
            PortalModel getobj = new PortalModel();
            details = getobj.GetUsers();
            return View(details);
        }

        public string Index1(string email,string mobile,string bfname,string blname,string bstr,string bzip, string bcity,string bstate,string bstateid,string bcountry, string bdob, string sfname, string slname, string sstr,string szip,string scity, string sstate,string sstateid, string scountry,string sdob,string duedate)
        {
            PortalModel newmv = new PortalModel();
            PortalModel obj = new PortalModel();
        
            
            newmv.Email = email;
            newmv.Phone = Convert.ToInt64(mobile);
            newmv.Billfname = bfname;
            newmv.Billlname = blname;
            newmv.Billstreet = bstr;
            newmv.Billzipcode = Convert.ToInt32(bzip);
            newmv.Billcity = bcity;
            newmv.Billstate = bstate;
            newmv.Billstateid = Convert.ToInt32(bstateid);
            newmv.Billcountry = bcountry;
            //newmv.Billdob = Convert.ToDateTime(bdob);
            newmv.Billdob = bdob;
            newmv.Shipfname = sfname;
            newmv.Shiplname = slname;
            newmv.Shipstreet = sstr;
            newmv.Shipzipcode = Convert.ToInt32(szip);
            newmv.Shipcity = scity;
            newmv.Shipstate = sstate;
            newmv.Shipstateid = Convert.ToInt32(sstateid);
            newmv.Shipcountry = scountry;
            newmv.Shipdob = Convert.ToDateTime(sdob);
            newmv.Bookdate = DateTime.Today;
            newmv.Duedate = Convert.ToDateTime(duedate);
            return obj.AddUsers(newmv);            
        }
    }
}