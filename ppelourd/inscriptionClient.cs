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
    public partial class inscriptionClient : Form
    {
        public inscriptionClient()
        {
            InitializeComponent();
        }
        string chainedeconnexion = "server=localhost;user id = root; database=lourdppe";

        private void inscriptionParticipant_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            labelVerif.Visible = false;


            MySqlConnection conn = new MySqlConnection(chainedeconnexion);
            try
            {
                conn.Open();
                string nom = txtusername.Text;
                string tel = txttel.Text;
                string departement = txtadresse.Text;
                string email = txtemail.Text;
                string sql = $"insert into users (username, tel, adresse, email) Values ('{nom}', '{tel}', '{departement}', '{email}') ";
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txttel.Clear();
            txtadresse.Clear();
            txtemail.Clear();
        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
