using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppelourd
{
    class DataBaseInfo
    {
        private static string chainedeconnexion = "server=localhost;user id=root;database=ppe";
        public static string ConnectionString
        {
            get
            {
                return chainedeconnexion;
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
