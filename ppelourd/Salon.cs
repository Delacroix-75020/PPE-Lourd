using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppelourd
{
    class Salon
    {
        List<Client> participants = new List<Client>();
        private int id;
        public int Id
        {
            get
            {
                return id;
            }
        }

        private string nom;
        public string Nom
        {
            get
            {
                return nom;
            }
        }
        private DateTime date_debut;
        public DateTime Date_Debut
        {
            get
            {
                return date_debut;
            }
        }
        private DateTime date_fin;
        public DateTime Date_Fin
        {
            get
            {
                return date_fin;
            }
        }
        private string lieu;
        public string Lieu
        {
            get
            {
                return lieu;
            }
        }

        public Salon()
        {

        }

        public Salon(int id, string nom, DateTime date_debut, DateTime date_fin, string lieu)
        {
            this.id = id;
            this.nom = nom;
            this.date_debut = date_debut;
            this.date_fin = date_fin;
            this.lieu = lieu;
        }

        public void AjouterParticipant(Client p)
        {
            participants.Add(p);
        }

        public void setParticipants(List<Client> lesparticipants)
        {
            this.participants = lesparticipants;
        }
    }
}
