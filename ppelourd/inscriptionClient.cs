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
        

        private void inscriptionParticipant_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            labelVerif.Visible = false;

           

                string nom = txtusername.Text;
                string tel = txttel.Text;
                string departement = txtadresse.Text;
                string email = txtemail.Text;
                string sql = $"insert into users (username, tel, adresse, email) Values ('{nom}', '{tel}', '{departement}', '{email}') ";
                if (DataBaseUtil.executeNonQuery(sql) > 0)
                {
                    labelVerif.ForeColor = Color.Green;
                    labelVerif.Visible = true;
                    labelVerif.Text = " Les informations ont bien été enregistrées ";
                }
                else
                {
                    MessageBox.Show("Echec de l'ajout d'un client");
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
