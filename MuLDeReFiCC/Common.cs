using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MuLDeReFiCC
{
    static class Common
    {
        //Used project > add reference to get the configmanager to work
        //public static string DB_Connection = System.Configuration.ConfigurationManager.ConnectionStrings["MuLDeReFiCC"].ConnectionString;
        private static List<string> _fileExtensions = new List<string>();
        public static List<string> FileExtensions
        {
            get
            {
                return _fileExtensions;
            }
        }

        public static List<string> getFileExtensions()
        {
            List<string> fileTypes = new List<string>();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MuLDeReFiCC.Properties.Settings.db_MuLDConnectionString"].ConnectionString;

            using (con) {
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("select * from FileType", con);

                DataSet data = new DataSet();

                adapter.Fill(data);

                fileTypes = data.Tables[0].AsEnumerable()
                                .Select(s => s.Field<string>("ExtensionLitteral"))
                                .ToList();
            }

            return fileTypes;
        }

        public static void PopulateFileExtensions()
        {
            _fileExtensions = getFileExtensions();
        }

        public static bool IsMusicFile(string filename)
        {
            filename = filename.ToLower();

            //split this out to only call the db once at initialization
            PopulateFileExtensions();

            foreach (string type in FileExtensions) {
                if (filename.EndsWith(type, StringComparison.Ordinal))
                    return true;
            }

            return false;
        }
    }
}
