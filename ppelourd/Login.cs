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
        Dictionary<string, int> dictUserConnexion = new Dictionary<string, int>();

        public string StrLevel = "Inconnu";
        public Login()
        {
            InitializeComponent();
        }
        private void AjouterJournalConnexion(int id_admin, DateTime t, bool etat)
        {

            string dt = t.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = $"INSERT INTO journal (dateconnect, etat, PersonID) VALUES ('{dt}', {etat}, {id_admin})";
            if (DataBaseUtil.executeNonQuery(sql) == -1)
            {
                MessageBox.Show("Erreur lors de l'insertion dans le journal");
            }
        }
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

                if (User.checkUserLocked(username))
                {
                    MessageBox.Show("Votre compte a été verouillé suite à 5 tentatives échouées");
                    this.DialogResult = DialogResult.Cancel;
                    return ;
                }

                string sql = $"Select id, username, pass, Role from admin where username='{username}'";
                MySqlDataReader rdr = DataBaseUtil.executeSelect(sql);
                if (rdr.Read())
                {
                    labelError.Visible = false;
                    int id = int.Parse(rdr[0].ToString());
                    string password = rdr[2].ToString();
                    bool etat = password.Equals(pass.ToLower());
                    role = int.Parse(rdr[3].ToString());
                    nomoperateur = rdr[1].ToString();
                    if (etat)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        int nbr = -1;
                        if(!dictUserConnexion.TryGetValue(username, out nbr))
                        {
                            dictUserConnexion.Add(username, 0);
                        }
                        dictUserConnexion[username]++;
                        nbr = dictUserConnexion[username];
                        

                        if (dictUserConnexion[username] == 5)
                        {
                            User.lockUnlockUser(username, true);
                        }
                        
                        labelError.Visible = true;
                    }
                    rdr.Close();
                    AjouterJournalConnexion(id, DateTime.Now, etat);


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
