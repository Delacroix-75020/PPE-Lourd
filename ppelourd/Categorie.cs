using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ppelourd
{
    class Categorie
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

        public Categorie(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }

        public static List<Categorie> getAllCategories()
        {
            List<Categorie> lescategories = new List<Categorie>();
            string sql = "SELECT * from categorie";
            try
            {
                MySqlDataReader rdr = DataBaseUtil.executeSelect(sql);
                lescategories = new List<Categorie>();
                while (rdr.Read())
                {
                    int id = int.Parse(rdr[0].ToString());
                    string nom = rdr[1].ToString();

                    Categorie cat = new Categorie(id, nom);
                    lescategories.Add(cat);
                }
                rdr.Close();
                return lescategories;
                

            }
            catch 
            {
                return null;
            }

        }

        public static int stringToId(string name)
        {
            name = name.Trim();
            List<Categorie> lescategories = ppelourd.Categorie.getAllCategories();

            foreach (ppelourd.Categorie cat in lescategories)
            {
                if (name.ToLower().Equals(cat.Nom.ToLower()))
                {
                    return cat.id;
                }
            }
            return 0;
        }

    }
}
