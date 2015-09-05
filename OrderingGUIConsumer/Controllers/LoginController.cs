using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderingGUIConsumer.Models;


namespace OrderingGUIConsumer.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
                
        //Post: /Login Credentials
   
        public string ValidateCredentials(string strUserID, string strPwd)
        {
            LoginModel objLoginModel = new LoginModel();
            ViewBag.Name = strUserID;
            ViewBag.Pwd = strPwd;
            return objLoginModel.isUserValid(strUserID, strPwd);        
        }
    }
}