using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb; 

namespace OrderingGUIConsumer.Models
{
    public class DetailsModel
    {
        public string insertDetails(string email,string strFirstName,string strLastName,string streetName,int zipcode,string strCity,string strState,int stateId,DateTime dob)
        {
            OleDbConnection connect = new OleDbConnection();

            connect.ConnectionString = "Provider=OraOLEDB.Oracle;Data Source=TR9001-PC11;User ID=system1;password=123";

            connect.Open();

            OleDbCommand command = new OleDbCommand("insert into t_Customer_Details values(?,?,?,?,?,?,?,'USA',?,?)", connect);

            command.Parameters.AddWithValue("?", strFirstName);
            command.Parameters.AddWithValue("?", strLastName);
            command.Parameters.AddWithValue("?", streetName);
            command.Parameters.AddWithValue("?", zipcode);
            command.Parameters.AddWithValue("?", strCity);
            command.Parameters.AddWithValue("?", strState);
            command.Parameters.AddWithValue("?", stateId);
            command.Parameters.AddWithValue("?", dob);
            command.Parameters.AddWithValue("?", email);
            int count = command.ExecuteNonQuery();
            
            if (count > 0)
            {
                return "INFUSED";
            }
            else
            {
                return "NOT INSERTED";
            }            
        }
    }
}