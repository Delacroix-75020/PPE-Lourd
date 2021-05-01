using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppelourd
{
    class Client
    {
        

        private int id;
        public int Id
        {
            get
            {
                return id;
            }
        }

        private string pseudo;
        public string Pseudo
        {
            get
            {
                return pseudo;
            }
            set
            {
                pseudo = value;
            }
        }

        private string tel;
        public string Tel
        {
            get
            {
                return tel;
            }
            set
            {
                tel = value;
            }
        }

        private string adresse;
        public string Adresse
        {
            get
            {
                return adresse;
            }
            set
            {
                adresse = value;
            }
        }

        private string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public Client(int id, string pseudo, string tel, string adresse, string email)
        {
            this.id = id;
            this.pseudo = pseudo;
            this.tel = tel;
            this.adresse = adresse;
            this.email = email;
        }

        /*public void participer(Salon s)
        {
            salons.Add(s);
        }*/

        /*public void setSalons(List<Salon> lessalons)
        {
            this.salons = lessalons; 
        }*/
    }
}
