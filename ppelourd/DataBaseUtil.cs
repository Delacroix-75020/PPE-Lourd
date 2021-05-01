using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppelourd
{
    class DataBaseUtil
    {
        private static string chainedeconnexion = "server=localhost;user id=root;database=ppe";
        public static string ConnectionString
        {
            get
            {
                return chainedeconnexion;
            }
        }
        
        private static MySqlConnection conn = openConnection();
        public static MySqlDataReader executeSelect(string sql)
        {
            
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                return rdr;
            }
            catch
            {
                return null;
            }          
        }
        public static int executeNonQuery(string sql)
        {

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                return cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                
                return -1;
            }
        }



        public static MySqlConnection openConnection()
        {
            MySqlConnection conn = new MySqlConnection(chainedeconnexion);
            conn.Open();
            return conn;
        }
    }
}
