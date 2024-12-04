using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageCreditCeleste
{
    public partial class Demarrage : Form
    {
        public Demarrage()
        {
            InitializeComponent();
        }

        private void Demarrage_Load(object sender, EventArgs e)
        {
            Globales.demarrage = this;
        }

        private void btnDemarrer_Click(object sender, EventArgs e)
        {
            Globales.accueil = new Accueil();
            Globales.accueil.Show();
            Globales.demarrage.Hide();
        }
    }
}
