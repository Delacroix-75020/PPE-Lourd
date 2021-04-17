using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ppelourd
{
    public partial class Employe : Form
    {
        public string nomoperateur;
        public Employe()
        {
            InitializeComponent();
        }
  
        List<Produit> lesproduits = new List<Produit>();
        List<Buy> byuser = new List<Buy>();

        private void load_Produits()
        {
            lesproduits.Clear();
            MySqlConnection conn = null;
            try
            {
                conn = DataBaseInfo.openConnection();
                string sql = "SELECT * FROM produit";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Produit ProduitView = new Produit(int.Parse(rdr[0].ToString()), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), int.Parse(rdr[4].ToString()), float.Parse(rdr[5].ToString()), null);
                    lesproduits.Add(ProduitView);
                }
                rdr.Close();

                cbProduit.DataSource = null;
                cbProduit.DataSource = lesproduits;
                cbProduit.DisplayMember = "Nom";
                cbProduit.ValueMember = "Id";
            }
            catch
            {
                MessageBox.Show("Impossible de charger les produits");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            }
            
            

        private void Operateur_Load(object sender, EventArgs e)
        {
            load_Produits();
            labelDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            labelnom.Text = nomoperateur;


        }

        private void cbProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Produit produit = cbProduit.SelectedItem as Produit;
            MySqlConnection conn = null;
            try
            {
                byuser.Clear();
                conn = DataBaseInfo.openConnection();
                string sql = $"SELECT users.username, panier.qte, commande.date_commande FROM panier, commande, users WHERE panier.ref_com = commande.ref_com AND panier.id_produit = {produit.Id} AND commande.id_u = users.id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Buy b = new Buy(rdr[0].ToString(), int.Parse(rdr[1].ToString()), DateTime.Parse(rdr[2].ToString()));
                    byuser.Add(b);

                }
                rdr.Close();
                DGVBuy.DataSource = null;
                DGVBuy.DataSource = byuser;
            }

            catch
            {
                MessageBox.Show("La Liste n'a pas pu etre récuperer");
            }

            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
