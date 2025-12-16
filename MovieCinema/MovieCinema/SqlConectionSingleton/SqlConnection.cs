using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MovieCinema.SqlConectionSingleton
{
    internal class SqlConnectionSingleton
    {
         static SqlConnection  con;
         static SqlConnectionSingleton _instance;

        private SqlConnectionSingleton()
        {
           
        }
        public static SqlConnectionSingleton GetInstance()
        {
            if (con == null)
            {
                con = new SqlConnection();
            }
             if (_instance == null)
            {
                _instance = new SqlConnectionSingleton();
            }
                 return _instance;
        }
        public static SqlConnection GetSingleConnetion() => con;
        }
}
