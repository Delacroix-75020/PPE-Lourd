using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppelourd
{
    class Journal
    {
        private DateTime date;
        public DateTime Date
        {
            get
            {
                return date;
            }
        }

        private string username;
        public string Username
        {
            get
            {
                return username;
            }
        }

        private User.RoleType role;
        public User.RoleType Role
        {
            get
            {
                return role;
            }
        }

        private bool etat;
        public string Etat
        {
            get
            {
                if (etat)
                {
                    return "Connexion réussi";
                }
                else
                {
                    return "Connexion echoué";
                }
            }
        }

        public Journal(DateTime date, string username, User.RoleType role, bool etat)
        {
            this.date = date;
            this.username = username;
            this.role = role;
            this.etat = etat;
        }

        public static string dateTimeToSQLString(DateTime dt)
        {
            return dt.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }


}
