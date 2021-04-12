using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppelourd
{
    public partial class Employe : Form
    {
        public string nomoperateur;
        public Employe()
        {
            InitializeComponent();
        }

        private void Operateur_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            labelnom.Text = nomoperateur;
        }
    }
}
