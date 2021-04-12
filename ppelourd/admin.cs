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
    public partial class admin : Form
    {

        public admin()
        {
            InitializeComponent();
        }

        List<Produit> lesproduits = new List<Produit>();
        List<Client> lesclients = new List<Client>();
        List<User> lesusers = new List<User>();
        MySqlConnection conn = null;

       /* private Salon querySalon(int id_salon)
        {
            MySqlConnection conn1 = DataBaseInfo.openConnection();
            string sql = "SELECT * FROM salon WHERE id = " + id_salon;
            MySqlCommand cmd = new MySqlCommand(sql, conn1);
            MySqlDataReader rdr = cmd.ExecuteReader();
            Salon salon = null;
            while (rdr.Read())
            {
               salon = new Salon(int.Parse(rdr[0].ToString()), rdr[1].ToString(), DateTime.Parse(rdr[2].ToString()), DateTime.Parse(rdr[3].ToString()), rdr[4].ToString());

            }
            rdr.Close();
            conn1.Close();
            return salon;
        }*/

       /* private List<Salon> querySalons(int idparticipant)
        {
            List<Salon> lessalons = new List<Salon>(); 
            string sql = "SELECT id_salon FROM participer WHERE id_participant = " + idparticipant;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                int id_salon = int.Parse(rdr[0].ToString());
                Salon s = querySalon(id_salon);
                if (s != null)
                {
                    lessalons.Add(s);
                }
            }
            rdr.Close();
            return lessalons;
        }*/
        /*private void updateParticipantSalon()
        {
            foreach (Participant p in lesparticipants)
            {
                List<Salon> lessalons = querySalons(p.Id);
                p.setSalons(lessalons);
            }
        }*/

       /* private Participant queryParticipant(int id_participant)
        {
            MySqlConnection conn1 = DataBaseInfo.openConnection();
            string sql = "SELECT * FROM participant WHERE id = " + id_participant;
            MySqlCommand cmd = new MySqlCommand(sql, conn1);
            MySqlDataReader rdr = cmd.ExecuteReader();
            Participant participant = null;
            while (rdr.Read())
            {
                participant = new Participant(int.Parse(rdr[0].ToString()), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString());

            }
            rdr.Close();
            conn1.Close();
            return participant;
        }*/

        /*private List<Participant> queryParticipants(int idsalon)
        {
            List<Participant> lesParticipants = new List<Participant>();
            string sql = "SELECT id_participant FROM participer WHERE id_salon = " + idsalon;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                int id_participant = int.Parse(rdr[0].ToString());
                Participant p = queryParticipant(id_participant);
                if (p != null)
                {
                    lesParticipants.Add(p);
                }
            }
            rdr.Close();
            return lesParticipants;
        }*/

        /*private void updateSalonParticipant()
        {
            foreach (Salon s in lessalon)
            {
                List<Participant> lesparticipants = queryParticipants(s.Id);
                s.setParticipants(lesparticipants);
            }
        }*/
        private void load_client()
        {
            lesclients.Clear();
            string sql = "Select * from users ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Client ClientView = new Client(int.Parse(rdr[0].ToString()), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString());
                lesclients.Add(ClientView);

            }
            rdr.Close();
            //updateParticipantSalon();
            DGVClient.DataSource = null;
            DGVClient.DataSource = lesclients;
        }
        private void load_produit()
        {
            lesproduits.Clear();
            string sql = "Select id_produit, nom_produit, p_motscles, description, qteProduit, prix from produit ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Produit ProduitView = new Produit(int.Parse(rdr[0].ToString()), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), int.Parse(rdr[4].ToString()), float.Parse(rdr[5].ToString()));
                lesproduits.Add(ProduitView);
            }
            rdr.Close();
            //updateSalonParticipant();
            DGVSalon.DataSource = null;
            DGVSalon.DataSource = lesproduits;
        }

        private void load_admin()
        {
        }

        private void admin_Load(object sender, EventArgs e)
        {
            conn = DataBaseInfo.openConnection();
            load_client();
            load_produit();
            
        }

        private void btnUpdateParticipant_Click(object sender, EventArgs e)
        {
            UpdateParticipant update = new UpdateParticipant();
            update.Show();

        }

        private void btnDeleteParticipant_Click(object sender, EventArgs e)
        {
            List<Client> selected = new List<Client>();
            foreach (DataGridViewRow row in DGVClient.SelectedRows)
            {
                selected.Add(lesclients[row.Index]);
                //DGVParticipant.Rows.RemoveAt(row.Index);
            }
            foreach (Client p in selected)
            {
                string sql = "DELETE FROM participant WHERE email = '" + p.Email + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            load_client();

        }

        private void btnAddParticipant_Click(object sender, EventArgs e)
        {
            inscriptionClient inscription = new inscriptionClient();
            inscription.Show();
        }

        private void btnUpdateSalon_Click(object sender, EventArgs e)
        {
         

        }

        private void btnAddSalon_Click(object sender, EventArgs e)
        {
            InsertProduit insertionProduit = new InsertProduit();
            insertionProduit.Show();
        }

        private void btnDeleteSalon_Click(object sender, EventArgs e)
        {
            List<Produit> selected = new List<Produit>();
            foreach (DataGridViewRow row in DGVSalon.SelectedRows)
            {
                selected.Add(lesproduits[row.Index]);
                //DGVParticipant.Rows.RemoveAt(row.Index);
            }
            foreach (Produit s in selected)
            {
                string sql = "DELETE FROM produit WHERE id_produit = " + s.Id;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            load_produit();
        }

        private void insertoperator_Click(object sender, EventArgs e)
        {
            insertAdmin insertionOperator = new insertAdmin();
            insertionOperator.ShowDialog();
        }

        private void DGVParticipant_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (0 <= e.RowIndex && e.RowIndex < lesclients.Count)
            {
                Client client = lesclients[e.RowIndex];
                string modifiedColumn = null;
                if (e.ColumnIndex == 1)
                {
                    modifiedColumn = "username";
                    client.Pseudo = DGVClient.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                else if (e.ColumnIndex == 2)
                {
                    modifiedColumn = "tel";
                    client.Tel = DGVClient.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                else if (e.ColumnIndex == 3)
                {
                    modifiedColumn = "adresse";
                    client.Adresse = DGVClient.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                else if (e.ColumnIndex == 4)
                {
                    modifiedColumn = "email";
                    client.Email = DGVClient.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                if (modifiedColumn != null)
                {
                    MySqlConnection conn = DataBaseInfo.openConnection();
                    string sql = $"UPDATE users SET {modifiedColumn} = '{DGVClient.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()}' WHERE id = {client.Id} ";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Failed to Update User");
                    }
                    finally
                    {
                        conn.Close();
                    }

                }
                
            }


        }

        private void DGVSalon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
