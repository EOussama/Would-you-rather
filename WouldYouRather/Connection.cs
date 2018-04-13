using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WouldYouRather
{
    class Connection
    {
        private static SqlConnection _con;
        private static SqlCommand _cmd;

        public static SqlConnection Con { get => _con; set => _con = value; }
        public static SqlCommand Cmd { get => _cmd; set => _cmd = value; }

        public static bool Connect(string src)
        {
            try
            {
                Con = new SqlConnection(src);
                Cmd = new SqlCommand();

                Cmd.Connection = Con;

                return true;
            }

            catch(SqlException)
            {
                return false;
            }

            catch (Exception)
            {
                return false;
            }
        }

        public static SqlDataReader getReader(string query)
        {
            SqlDataReader dataReader;

            Cmd.CommandText = query;
            conOpen();
            dataReader = Cmd.ExecuteReader();

            return dataReader;
        }

        public static void sendQuery(string query)
        {
            Cmd.CommandText = query;
            conOpen();
            Cmd.ExecuteNonQuery();
            conClose();
        }

        public static void conOpen()
        {
            if (Con.State != System.Data.ConnectionState.Open)
                Con.Open();
        }

        public static void conClose()
        {
            if (Con.State != System.Data.ConnectionState.Closed)
                Con.Close();
        }
    }
}
