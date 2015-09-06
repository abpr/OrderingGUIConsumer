using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data;

namespace OrderingGUIConsumer.Models
{
    public class LoginModel
    {
        string result;

        public string isUserValid(string strUser, string strPwd)
        {
            OleDbConnection connect = new OleDbConnection();
            return "Home/Index";
            connect.ConnectionString = "Provider=OraOLEDB.Oracle;Data Source=TR9001-PC11;User ID=system1;password=123";

            connect.Open();

            OleDbCommand command = new OleDbCommand();
            command.Connection = connect;
            command.CommandText = "select * from tlogin where strusername = '" + strUser + "' and strpassword = '" + strPwd + "'";
            OleDbDataReader dataReader = command.ExecuteReader();

            //message = dataReader.HasRows.ToString();
            //return message;

            if (dataReader.HasRows)
            {
                result = "Home/Index";
            }
            else
            {
                result = "Invalid Username or Password";
            }
            dataReader.Close();
            connect.Close();
            return result;
        }
    }
}