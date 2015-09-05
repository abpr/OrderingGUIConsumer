using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Rootobject
{
    public Bundle[] Bundle { get; set; }
}

public class Bundle
{
    public Bundle_Id Bundle_Id { get; set; }
    public Bundle_Desc Bundle_Desc { get; set; }
    public Bundle_Discount Bundle_Discount { get; set; }
    public Bundle_Cost Bundle_Cost { get; set; }
}

public class Bundle_Id
{
    public string value { get; set; }
}

public class Bundle_Desc
{
    public string value { get; set; }
}

public class Bundle_Discount
{
    public string value { get; set; }
}

public class Bundle_Cost
{
    public string value { get; set; }
}


}
