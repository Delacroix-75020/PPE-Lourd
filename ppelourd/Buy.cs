using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppelourd
{
    class Buy
    {
        private string username;
        public string Username
        {
            get
            {
                return username;
            }
        }

        private int quantite;
        public int Quantite
        {
            get
            {
                return quantite;
            }
        }

        private DateTime date;
        public DateTime Date
        {
            get
            {
                return date;
            }
        }

        public Buy(string username, int quantite, DateTime date)
        {
            this.username = username;
            this.quantite = quantite;
            this.date = date;
        }
    }
}
