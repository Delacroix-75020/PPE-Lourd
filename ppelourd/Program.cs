using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppelourd
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login MonFormLogin = new Login();
            admin FormAdmin = null;
            Employe FormEmployee = null;

            MonFormLogin.ShowDialog();
            if (MonFormLogin.DialogResult == DialogResult.OK)
            {
                String NiveauUtilisateur = MonFormLogin.StrLevel;
                MonFormLogin.Close();
                MessageBox.Show("Vous vous êtes connecté avec succès");
                if (MonFormLogin.role == 1)
                {
                    FormAdmin = new admin();
                    FormAdmin.ShowDialog();

                }
                else if (MonFormLogin.role == 0)
                {
                    FormEmployee = new Employe();
                    FormEmployee.nomoperateur = MonFormLogin.nomoperateur;
                    FormEmployee.ShowDialog();
                }

            }
            else
            {
                MonFormLogin.Close();
                MessageBox.Show("Vous quittez l'application");
            }
        }
    }
}
