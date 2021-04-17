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
    public partial class Login : Form
    {
        public int role = 0;
        public string nomoperateur;

        public string StrLevel = "Inconnu";
        public Login()
        {
            InitializeComponent();
        }
        private void AjouterJournalConnexion(int id_admin, DateTime t)
        {
            MySqlConnection conn = null;
            try
            {
                string dt = t.ToString("yyyy-MM-dd HH:mm:ss");
                conn = DataBaseInfo.openConnection();
                string sql = $"INSERT INTO journal (dateconnect, PersonID) VALUES ('{dt}', {id_admin})";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int res = cmd.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("Erreur lors de l'insertion dans le journal");
            }
            finally
            {
               if(conn != null)
                {
                    conn.Close();
                } 
            }
            
        }
        string chainedeconnexion = "server=localhost;user id=root;database=ppe";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Remplissez tous les champs");
                return;
            }
            try
            {
                string username = txtusername.Text;
                string pass = txtpassword.Text;
                pass = SHA.petitsha(pass);

                
                MySqlConnection conn = new MySqlConnection(chainedeconnexion);
                conn.Open();
                string sql = $"Select id, username, pass, Role from admin where username='{username}' and pass='{pass}'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    labelError.Visible = false;
                    int id = int.Parse(rdr[0].ToString());
                    role = int.Parse(rdr[3].ToString());
                    nomoperateur = rdr[1].ToString();
                    AjouterJournalConnexion(id, DateTime.Now);
                    this.DialogResult = DialogResult.OK;

                }
                else
                {
                    labelError.Visible = true;

                }
            }
            catch
            {
                
            }
            
            ///this.StrLevel = "Administrateur";

            
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void labelError_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
