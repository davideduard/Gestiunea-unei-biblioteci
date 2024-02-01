using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Gestiune_Biblioteca
{
    class DbManagement
    {
        private static SqlConnection dbConn = null;

        private static void GetConnection()
        {
            dbConn = new SqlConnection(Properties.Settings.Default.dbConn);
        }

        public static SqlConnection DbConn
        {
            get 
            {
                if (dbConn == null)
                    GetConnection();
                return dbConn;
            }
        }

        public static void OpenIfNotOpen()
        {
            if (dbConn == null)
                GetConnection();
            if (dbConn.State != ConnectionState.Open)
                dbConn.Open();
        }

        public static void NonQuery(string query)
        {
            OpenIfNotOpen();
            SqlCommand cmd = new SqlCommand(query, dbConn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            dbConn.Close();
        }

        public static List<List<string>> Query(string query)
        {
            List<List<string>> returnList = new List<List<string>>();

            OpenIfNotOpen();
            SqlCommand cmd = new SqlCommand(query, dbConn);
            SqlDataReader reader = cmd.ExecuteReader();

            int row = 0;
            while (reader.Read())
            {
                returnList.Add(new List<string>());
                for (int i = 0; i < reader.FieldCount; ++i)
                {
                    returnList[row].Add(reader[i].ToString());
                }
                row++;
            }
            reader.Close();
            cmd.Dispose();

            return returnList;
        }
    }
}
