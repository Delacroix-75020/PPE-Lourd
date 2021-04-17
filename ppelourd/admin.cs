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
        List<User> lesadmins = new List<User>();
        List<Journal> lesjournaux = new List<Journal>();

        MySqlConnection conn = null;

        private void load_admin()
        {
            lesadmins.Clear();
            string sql = "Select * from admin";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                int roleid = int.Parse(rdr[4].ToString());
                User.RoleType role = User.intToRoleType(roleid);
                User AdminViews = new User(int.Parse(rdr[0].ToString()), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), role);
                lesadmins.Add(AdminViews);
            }
            rdr.Close();
            DGVAdmin.DataSource = null;
            DGVAdmin.DataSource = lesadmins;
        }
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
            string sql = "SELECT produit.*, categorie.nom_categorie from produit, categorie WHERE produit.id_categorie = categorie.id_categorie";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Produit ProduitView = new Produit(int.Parse(rdr[0].ToString()), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), int.Parse(rdr[4].ToString()), float.Parse(rdr[5].ToString()), rdr[8].ToString());
                lesproduits.Add(ProduitView);
            }
            rdr.Close();
            //updateSalonParticipant();
            DGVSalon.DataSource = null;
            DGVSalon.DataSource = lesproduits;
        }

        private void load_journal()
        {
            lesjournaux.Clear();
            string sql = "SELECT username, dateconnect, role from journal, admin WHERE journal.PersonID = admin.id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                DateTime dt = DateTime.Parse(rdr[1].ToString());
                int r = int.Parse(rdr[2].ToString());
                Journal JournalView = new Journal(dt, rdr[0].ToString(),User.intToRoleType(r));
                lesjournaux.Add(JournalView);
            }
            rdr.Close();
            DGVJournal.DataSource = null;
            DGVJournal.DataSource = lesjournaux;
        }






        private void admin_Load(object sender, EventArgs e)
        {
            conn = DataBaseInfo.openConnection();
            load_client();
            load_produit();
            load_admin();
            load_journal();
            
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
                string sql = "DELETE FROM users WHERE id = '" + p.Id + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            load_client();

        }

        private void btnAddParticipant_Click(object sender, EventArgs e)
        {
        }

        private void btnUpdateSalon_Click(object sender, EventArgs e)
        {
         

        }

        private void btnAddSalon_Click(object sender, EventArgs e)
        {
            InsertProduit insertionProduit = new InsertProduit();
            insertionProduit.ShowDialog();
            load_produit();
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
            load_admin();
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
            /*if (0 <= e.RowIndex && e.RowIndex < lesadmins.Count)
            {
                Produit produit = lesproduits[e.RowIndex];
                string modifiedColumn = null;
                if (e.ColumnIndex == 1)
                {
                    modifiedColumn = "nom_produit";
                    produit.Nom = DGVSalon.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                else if (e.ColumnIndex == 2)
                {
                    modifiedColumn = "p_motscles";
                    produit.Most_Cles = DGVSalon.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                else if (e.ColumnIndex == 3)
                {
                    modifiedColumn = "description";
                    produit.Description = DGVSalon.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                else if (e.ColumnIndex == 4)
                {
                    modifiedColumn = "email";
                    produit.Email = DGVSalon.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                if (modifiedColumn != null)
                {
                    MySqlConnection conn = DataBaseInfo.openConnection();
                    string sql = $"UPDATE produit SET {modifiedColumn} = '{DGVClient.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()}' WHERE id = {client.Id} ";
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

            }*/

        }

        private void btndeleteAdmin_Click(object sender, EventArgs e)
        {
            List<User> selected = new List<User>();
            foreach (DataGridViewRow row in DGVAdmin.SelectedRows)
            {
                selected.Add(lesadmins[row.Index]);
                //DGVParticipant.Rows.RemoveAt(row.Index);
            }
            foreach (User s in selected)
            {
                string sql = "DELETE FROM admin WHERE id = " + s.Id;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            load_admin();

        }

        private void DGVAdmin_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            /*if (0 <= e.RowIndex && e.RowIndex < lesadmins.Count)
            {
                User admin = lesadmins[e.RowIndex];
                string modifiedColumn = null;
                if (e.ColumnIndex == 1)
                {
                    modifiedColumn = "username";
                    admin.Nom = DGVAdmin.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                else if (e.ColumnIndex == 2)
                {
                    modifiedColumn = "email";
                    admin.Email = DGVAdmin.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                else if (e.ColumnIndex == 3)
                {
                    modifiedColumn = "adresse";
                    admin.Adresse = DGVAdmin.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                else if (e.ColumnIndex == 4)
                {
                    modifiedColumn = "email";
                    admin.Email = DGVAdmin.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                if (modifiedColumn != null)
                {
                    MySqlConnection conn = DataBaseInfo.openConnection();
                    string sql = $"UPDATE admin SET {modifiedColumn} = '{DGVClient.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()}' WHERE id = {client.Id} ";
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

            }*/

        }
    }
}
