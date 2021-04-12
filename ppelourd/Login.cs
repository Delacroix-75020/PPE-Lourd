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
                string sql = $"Select username, pass, Role from admin where username='{username}' and pass='{pass}'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    labelError.Visible = false;
                    role = int.Parse(rdr[2].ToString());
                    nomoperateur = rdr[0].ToString();
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
