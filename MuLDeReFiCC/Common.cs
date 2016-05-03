using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MuLDeReFiCC
{
    static class Common
    {
        //Used project > add reference to get the configmanager to work
        //public static string DB_Connection = System.Configuration.ConfigurationManager.ConnectionStrings["MuLDeReFiCC"].ConnectionString;
        
        public static string getFileExtensions()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MuLDeReFiCC.Properties.Settings.db_MuLDConnectionString"].ConnectionString;

            //con.Open();

            //http://stackoverflow.com/questions/1121917/local-database-i-need-some-examples

            return con.ToString();
        }
    }
}
