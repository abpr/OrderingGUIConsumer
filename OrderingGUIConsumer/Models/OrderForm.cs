using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{

    public class OrderForm
    {
        public string lineofbusiness { get; set; }
        public Customerdetails customerdetails { get; set; }
        public Orderdetails orderdetails { get; set; }
        public Contractdetails contractdetails { get; set; }
    }

    public class Customerdetails
    {
        public string customertype { get; set; }
        public int customerid { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public Connectionaddress connectionaddress { get; set; }
        public Billingaddress billingaddress { get; set; }
        public string email { get; set; }
        public long contactnumber { get; set; }
        public string dateofbirth { get; set; }
    }

    public class Connectionaddress
    {
        public string streetname { get; set; }
        public int zipcode { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int stateid { get; set; }
        public string country { get; set; }
    }

    public class Billingaddress
    {
        public string streetname { get; set; }
        public int zipcode { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int stateid { get; set; }
        public string country { get; set; }
    }

    public class Orderdetails
    {
        public string dateofbooking { get; set; }
        public string duedate { get; set; }
        public Service[] services { get; set; }
    }

    public class Service
    {
        public string servicecode { get; set; }
        public string servicename { get; set; }
        public Quantity quantity { get; set; }
    }

    public class Quantity
    {
        public int max { get; set; }
        public int current { get; set; }
    }

    public class Contractdetails
    {
        public string contractid { get; set; }
        public string modeltype { get; set; }
        public string classofservice { get; set; }
        public string fromdate { get; set; }
        public string todate { get; set; }
        public int discountpercentage { get; set; }
        public int change { get; set; }
    }

}