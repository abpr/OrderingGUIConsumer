using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderingGUIConsumer.Models
{
    public class Rootobject1
    {
        public Product_Details[] Product_Details { get; set; }
    }

    public class Product_Details
    {
        public Product_ID Product_ID { get; set; }
        public Product_Name Product_Name { get; set; }
        public Product_Description Product_Description { get; set; }
        public Discount Discount { get; set; }
        public Cost Cost { get; set; }
    }

    public class Product_ID
    {
        public string value { get; set; }
    }

    public class Product_Name
    {
        public string value { get; set; }
    }

    public class Product_Description
    {
        public string value { get; set; }
    }

    public class Discount
    {
        public string value { get; set; }
    }

    public class Cost
    {
        public string value { get; set; }
    }

}