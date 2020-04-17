using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using MySql.Data.MySqlClient;

namespace WebTreugolnik
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            string host = "remotemysql.com";
            int port = 3306;
            string database = "TiA61L4ZgI";
            string username = "TiA61L4ZgI";
            string password = "wvaQF6dpoM";
            string Connect = "Database=" + database + ";Datasource=" + host + ";User=" + username + ";Password=" + password;
            MySqlConnection mysql_connection = new MySqlConnection(Connect);
            MySqlCommand mysql_query = mysql_connection.CreateCommand();

            mysql_query.CommandText = "SELECT user FROM Users";
            var mysql_result = mysql_query.ExecuteReader();
        }
    }
}