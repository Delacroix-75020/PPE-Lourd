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
    public partial class InsertProduit : Form
    {
        public InsertProduit()
        {
            InitializeComponent();
        }
        string chainedeconnexion = "server=localhost;user id=root;database=ppe";

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            labelVerif.Visible = false;


            MySqlConnection conn = new MySqlConnection(chainedeconnexion);
            try
            {
                conn.Open();
                string Libelle = txtLibelle.Text;
                string MotsCles = txtMots.Text;
                string Description = txtdesc.Text;
                string Quantite = nudQuantite.Value.ToString();
                string Prix = nudprix.Value.ToString();
                string sql = $"insert into produit (nom_produit, p_motscles, description, qteProduit, prix) Values ('{Libelle}', '{MotsCles}', '{Description}', '{Quantite}', '{Prix}') ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    labelVerif.ForeColor = Color.Green;
                    labelVerif.Visible = true;
                    labelVerif.Text = " Les informations ont bien été enregistrées ";
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
            finally
            {
                conn.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLibelle.Clear();
            txtdesc.Clear();
            txtMots.Clear();
            nudQuantite.ResetText();
            nudprix.ResetText();
        }
    }
}
