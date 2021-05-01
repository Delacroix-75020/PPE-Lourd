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
    public partial class insertAdmin : Form
    {
        public insertAdmin()
        {
            InitializeComponent();
        }

        private void insertOperateur_Load(object sender, EventArgs e)
        {
            cbrole.Items.Add("Employe");
            cbrole.Items.Add("Admin");
            cbrole.SelectedIndex = 0;
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string email = txtemail.Text;
            string password = SHA.petitsha(txtpass.Text);
            User.RoleType role = User.RoleType.EMPLOYE;
            if(cbrole.Text == "Employe")
            {
                role = User.RoleType.EMPLOYE;
            }
            else if(cbrole.Text == "Admin")
            {
                role = User.RoleType.ADMIN;
            }
 
            string sql = $"insert into admin (username,email ,pass, Role) Values ('{username}', '{email}','{password}', {User.roleTypeToInt(role)})";
            

                if (DataBaseUtil.executeNonQuery(sql) > 0)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("User " + username + " exists already");
                }
      

            
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
