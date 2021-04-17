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
using System.Globalization;


namespace ppelourd
{
    public partial class InsertProduit : Form
    {
        public InsertProduit()
        {
            InitializeComponent();
        }
        string chainedeconnexion = "server=localhost;user id=root;database=ppe";
        List<Categorie> lescategories = null;
        List<Image> lesimages = null;

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
                decimal Quantite = nudQuantite.Value;
                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberDecimalSeparator = ".";
                float Prix = float.Parse(txtPrix.Text);
                string strprix = Prix.ToString(nfi);
                int idcategorie = (cbCategorie.SelectedItem as Categorie).Id;
                int idimage = (cbImage.SelectedItem as Image).Id;
                string sql = $"insert into produit (nom_produit, p_motscles, description, qteProduit, prix, id_categorie, id_image) Values ('{Libelle}', '{MotsCles}', '{Description}', {Quantite}, {strprix}, {idcategorie}, {idimage}) ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    labelVerif.ForeColor = Color.Green;
                    labelVerif.Visible = true;
                    labelVerif.Text = " Les informations ont bien été enregistrées ";
                    this.DialogResult = DialogResult.OK;
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
            txtPrix.ResetText();
        }

        private void InsertProduit_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = DataBaseInfo.openConnection();
            string sql = "SELECT * from categorie";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                lescategories = new List<Categorie>();
                while (rdr.Read())
                {
                    int id = int.Parse(rdr[0].ToString());
                    string nom = rdr[1].ToString();

                    Categorie cat = new Categorie(id, nom);
                    lescategories.Add(cat);
                }
                rdr.Close();
                cbCategorie.DataSource = lescategories;
                cbCategorie.DisplayMember = "Nom";
                cbCategorie.ValueMember = "Id";

            }
            catch
            {
                MessageBox.Show("Erreur de chargement de la liste des categories");
            }
            finally
            {
                conn.Close();
            }

            conn = DataBaseInfo.openConnection();
            sql = "SELECT * from image";
            cmd = new MySqlCommand(sql, conn);
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                lesimages = new List<Image>();
                while (rdr.Read())
                {
                    int id = int.Parse(rdr[0].ToString());
                    string nom = rdr[1].ToString();

                    Image img = new Image(id, nom);
                    lesimages.Add(img);
                }
                rdr.Close();
                cbImage.DataSource = lesimages;
                cbImage.DisplayMember = "Nom";
                cbImage.ValueMember = "Id";

            }
            catch
            {
                MessageBox.Show("Erreur de chargement de la liste des Images");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
