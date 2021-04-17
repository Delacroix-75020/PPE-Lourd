using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppelourd
{
    class Produit
    {
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
        private string mots_cles;
        public string Most_Cles
        {
            get
            {
                return mots_cles;
            }
        }
        private string description;
        public string Description
        {
            get
            {
                return description;
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

        private float prix;
        public float Prix
        {
            get
            {
                return prix;
            }
        }

        private string categorie;
        public string Categorie
        {
            get
            {
                return categorie;
            }
        }

        public Produit()
        {

        }

        public Produit(int id, string nom, string mots_cles, string description, int quantite, float prix, string categorie)
        {
            this.id = id;
            this.nom = nom;
            this.mots_cles = mots_cles;
            this.description = description;
            this.quantite = quantite;
            this.prix = prix;
            this.categorie = categorie; 
        }
    }
}
