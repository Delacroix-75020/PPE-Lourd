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
        
        List<Categorie> lescategories = null;
        List<Image> lesimages = null;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            labelVerif.Visible = false;
            string Libelle = txtLibelle.Text;
            string MotsCles = txtMots.Text;
            string Description = txtdesc.Text;
            decimal Quantite = nudQuantite.Value;
            float Prix = float.Parse(txtPrix.Text);
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            string strprix = Prix.ToString(nfi);
            int idcategorie = (cbCategorie.SelectedItem as Categorie).Id;
            int idimage = (cbImage.SelectedItem as Image).Id;
            string sql = $"insert into produit (nom_produit, p_motscles, description, qteProduit, prix, id_categorie, id_image) Values ('{Libelle}', '{MotsCles}', '{Description}', {Quantite}, {strprix}, {idcategorie}, {idimage}) ";
            if (DataBaseUtil.executeNonQuery(sql) > 0)
            {
                labelVerif.ForeColor = Color.Green;
                labelVerif.Visible = true;
                labelVerif.Text = " Les informations ont bien été enregistrées ";
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Echec d'ajout du produit");
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
            lescategories = Categorie.getAllCategories();

            cbCategorie.DataSource = lescategories;
            cbCategorie.DisplayMember = "Nom";
            cbCategorie.ValueMember = "Id";


            string sql = "SELECT * from image";
            try
            {
                MySqlDataReader rdr = DataBaseUtil.executeSelect(sql);
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
        }
    }
}
