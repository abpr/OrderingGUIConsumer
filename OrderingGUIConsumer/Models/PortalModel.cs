using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.ComponentModel.DataAnnotations;

namespace OrderingGUIConsumer.Models
{

    public class PortalModel
    {

        public string Email { get; set; }

        public long Phone { get; set; }
        public string Billfname { get; set; }
        public string Billlname { get; set; }
        public string Billstreet { get; set; }
        public int Billzipcode { get; set; }
        public string Billcity { get; set; }
        public string Billstate { get; set; }
        public int Billstateid { get; set; }
        public string Billcountry { get; set; }
        public DateTime Billdob { get; set; }
        public string Shipfname { get; set; }
        public string Shiplname { get; set; }
        public string Shipstreet { get; set; }
        public int Shipzipcode { get; set; }
        public string Shipcity { get; set; }
        public string Shipstate { get; set; }
        public int Shipstateid { get; set; }
        public string Shipcountry { get; set; }
        public DateTime Shipdob { get; set; }
        public DateTime Bookdate { get; set; }
        public DateTime Duedate { get; set; }

        public PortalModel GetUsers()
        {
            PortalModel obj = new PortalModel();
            OleDbConnection connect = new OleDbConnection();

            connect.ConnectionString = "Provider=OraOLEDB.Oracle;Data Source=TR9001-PC11;User ID=system1;password=123";

            OleDbCommand command = new OleDbCommand("select * from T_CUSTOMER_DETAILS", connect);
            connect.Open();
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                obj.Billfname = reader["strfirstname"].ToString();
                obj.Billlname = reader["strlastname"].ToString();
                obj.Billstreet = reader["STREETNAME"].ToString();
                obj.Billzipcode = Convert.ToInt32(reader["zipcode"]);
                obj.Billcity = reader["strcity"].ToString();
                obj.Billstate = reader["strstate"].ToString();
                obj.Billstateid = Convert.ToInt32(reader["stateid"]);
                obj.Billcountry = reader["strcountry"].ToString();
                obj.Billdob = Convert.ToDateTime(reader["dob"]);
                obj.Email = reader["email"].ToString();
            }
            return obj;
        } 

        public string AddUsers(PortalModel Usersobj)
        {
            OleDbConnection connect = new OleDbConnection();

            connect.ConnectionString = "Provider=OraOLEDB.Oracle;Data Source=TR9001-PC11;User ID=system1;password=123";

            connect.Open();
            OleDbCommand command = new OleDbCommand("insert into Contact values(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,? )", connect);
            command.Parameters.AddWithValue("?", Usersobj.Phone);
            command.Parameters.AddWithValue("?", Usersobj.Billfname);
            command.Parameters.AddWithValue("?", Usersobj.Billlname);
            command.Parameters.AddWithValue("?", Usersobj.Billstreet);
            command.Parameters.AddWithValue("?", Usersobj.Billzipcode);
            command.Parameters.AddWithValue("?", Usersobj.Billcity);
            command.Parameters.AddWithValue("?", Usersobj.Billstate);
            command.Parameters.AddWithValue("?", Usersobj.Billstateid);
            command.Parameters.AddWithValue("?", Usersobj.Billcountry);
            command.Parameters.AddWithValue("?", Usersobj.Billdob);
            command.Parameters.AddWithValue("?", Usersobj.Shipfname);
            command.Parameters.AddWithValue("?", Usersobj.Shiplname);
            command.Parameters.AddWithValue("?", Usersobj.Shipstreet);
            command.Parameters.AddWithValue("?", Usersobj.Shipzipcode);
            command.Parameters.AddWithValue("?", Usersobj.Shipcity);
            command.Parameters.AddWithValue("?", Usersobj.Shipstate);
            command.Parameters.AddWithValue("?", Usersobj.Shipstateid);
            command.Parameters.AddWithValue("?", Usersobj.Shipcountry);
            command.Parameters.AddWithValue("?", Usersobj.Bookdate);
            command.Parameters.AddWithValue("?", Usersobj.Duedate);
            command.Parameters.AddWithValue("?", Usersobj.Email);
            command.Parameters.AddWithValue("?", Usersobj.Shipdob);
            
            int count = command.ExecuteNonQuery();
            connect.Close();
            if (count > 0)
            {
                return "Custumer contact stored!";
            }
            else
            {
                return "Customer contact could not be stored!";
            }


        }
        public void A(string x,string y, string z)
        {
       

            OleDbConnection connect = new OleDbConnection("Provider=OraOLEDB.Oracle;Data Source=TR9001-PC11;User ID=system1;password=123");

            OleDbCommand command = new OleDbCommand("insert into newdata values('" + x + "','" + y + "','" + z + "')", connect);

            connect.Open();

            command.ExecuteNonQuery();


        }
    }
}
