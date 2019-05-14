using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//The System.Data.SqlClient reference is needed to access SQL Server database
using System.Data.SqlClient;

namespace MeramecNetFlixProject
{
    public static class AccessDataSQLServer
    {

        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=mc-sluggo.stlcc.edu;Initial Catalog=IS253_Emery;Persist Security Info=True;User ID=emery;Password=emery";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
        //Add static public methods to expose to the outside world
        //Refer to Murach Chapter 20 on page 663 to see how this is coded
        //You need to reference the remote SQL server IP address
    }

   
}
