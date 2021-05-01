using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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


        private void load_admin()
        {
            lesadmins.Clear();
            string sql = "Select * from admin";
            MySqlDataReader rdr = DataBaseUtil.executeSelect(sql);
            while (rdr.Read())
            {
                int roleid = int.Parse(rdr[4].ToString());
                User.RoleType role = User.intToRoleType(roleid);
                User AdminViews = new User(int.Parse(rdr[0].ToString()), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), role, bool.Parse(rdr[5].ToString()));
                lesadmins.Add(AdminViews);
            }
            rdr.Close();
            //DGVAdmin.DataSource = null;
            DGVAdmin.DataSource = lesadmins;
        }
        private void load_client()
        {
            lesclients.Clear();
            string sql = "Select * from users ";         
            MySqlDataReader rdr = DataBaseUtil.executeSelect(sql);
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
            MySqlDataReader rdr = DataBaseUtil.executeSelect(sql);
            while (rdr.Read())
            {
                Produit ProduitView = new Produit(int.Parse(rdr[0].ToString()), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), int.Parse(rdr[4].ToString()), float.Parse(rdr[5].ToString()), rdr[8].ToString());
                lesproduits.Add(ProduitView);
            }
            rdr.Close();
            DGVProduit.DataSource = null;
            DGVProduit.DataSource = lesproduits;
        }

        private void load_journal()
        {
            lesjournaux.Clear();
            DateTime dt = DateTime.Now.Subtract(new TimeSpan(3,0,0,0,0));
            string strdate = Journal.dateTimeToSQLString(dt);
            string sql = $"SELECT username, dateconnect, role, etat from journal, admin WHERE journal.PersonID = admin.id AND dateconnect > '{strdate}' ORDER BY dateconnect DESC";
            MySqlDataReader rdr = DataBaseUtil.executeSelect(sql);
            while (rdr.Read())
            {
                dt = DateTime.Parse(rdr[1].ToString());
                int r = int.Parse(rdr[2].ToString());
                bool etat = Boolean.Parse(rdr[3].ToString());
                Journal JournalView = new Journal(dt, rdr[0].ToString(),User.intToRoleType(r), etat);
                lesjournaux.Add(JournalView);
            }
            rdr.Close();
            DGVJournal.DataSource = null;
            DGVJournal.DataSource = lesjournaux;
        }


        private void admin_Load(object sender, EventArgs e)
        {
            load_client();
            load_produit();
            load_admin();
            load_journal();
            
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
                DataBaseUtil.executeNonQuery(sql);
            }
            load_client();

        }

        private void btnAddProduit_Click(object sender, EventArgs e)
        {
            AjouterProduit();
        }

        private void AjouterProduit()
        {
            InsertProduit insertionProduit = new InsertProduit();
            insertionProduit.ShowDialog();
            load_produit();
        }

        private void btnDeleteSalon_Click(object sender, EventArgs e)
        {
            List<Produit> selected = new List<Produit>();
            foreach (DataGridViewRow row in DGVProduit.SelectedRows)
            {
                selected.Add(lesproduits[row.Index]);
                //DGVParticipant.Rows.RemoveAt(row.Index);
            }
            foreach (Produit s in selected)
            {
                string sql = "DELETE FROM produit WHERE id_produit = " + s.Id;
                DataBaseUtil.executeNonQuery(sql);
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
                    string sql = $"UPDATE users SET {modifiedColumn} = '{DGVClient.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()}' WHERE id = {client.Id} ";
                    
                    if(DataBaseUtil.executeNonQuery(sql) == -1)
                    {
                        MessageBox.Show("Failed to Update User");
                    }
                }       
            }


        }

        private void DGVSalon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (0 <= e.RowIndex && e.RowIndex < lesproduits.Count)
            {
                float prix = -1;
                Produit produit = lesproduits[e.RowIndex];
                string strvalue = null;
                int intvalue = 0;
                string modifiedColumn = null;
                if (e.ColumnIndex == 1)
                {
                    modifiedColumn = "nom_produit";
                    strvalue = DGVProduit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                else if (e.ColumnIndex == 2)
                {
                    modifiedColumn = "p_motscles";
                    strvalue = DGVProduit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                else if (e.ColumnIndex == 3)
                {
                    modifiedColumn = "description";
                    strvalue = DGVProduit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                else if (e.ColumnIndex == 4)
                {
                    modifiedColumn = "qteProduit";
                    intvalue = int.Parse(DGVProduit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                }
                else if (e.ColumnIndex == 5)
                {
                    
                    modifiedColumn = "prix";
                    prix = float.Parse(DGVProduit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    
                }
                else if (e.ColumnIndex == 6)
                {
                    modifiedColumn = "id_categorie";
                    string tmp = DGVProduit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    intvalue = Categorie.stringToId(tmp);
                    if (intvalue == 0)
                    {
                        MessageBox.Show("Catégorie introuvable");
                        return;
                    }
                }

                if (modifiedColumn != null)
                {
                    string sql = null;
                    if (strvalue != null)
                    {
                        sql = $"UPDATE produit SET {modifiedColumn} = '{strvalue}' WHERE id_produit = {produit.Id} ";
                    }
                    else if (prix >= 0)
                    {
                        NumberFormatInfo nfi = new NumberFormatInfo();
                        nfi.NumberDecimalSeparator = ".";
                        string strprix = prix.ToString(nfi);
                        sql = $"UPDATE produit SET {modifiedColumn} = {strprix} WHERE id_produit = {produit.Id} ";
                    }
                    else
                    {
                        sql = $"UPDATE produit SET {modifiedColumn} = {intvalue} WHERE id_produit = {produit.Id} ";
                    }
                    if (DataBaseUtil.executeNonQuery(sql) == -1)
                    {
                        MessageBox.Show("Failed to Update User");
                    }
                }
            }
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
                DataBaseUtil.executeNonQuery(sql);
              
            }
            load_admin();

        }

        private void DGVAdmin_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (0 <= e.RowIndex && e.RowIndex < lesadmins.Count)
            {
                User admin = lesadmins[e.RowIndex];
                if(e.ColumnIndex == 5)
                {
                    if(admin.Role == User.RoleType.ADMIN)
                    {
                        MessageBox.Show("Vous ne pouvez pas verrouiller le compte d'un administrateur");
                    }
                    else
                    {
                        User.lockUnlockUser(admin.Username, admin.Locked);
                    }

                }
                load_admin();

            }

        }

        private void DGVClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
