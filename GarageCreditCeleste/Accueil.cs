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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void btnVendre_Click(object sender, EventArgs e)
        {
            Globales.vendre = new Vendre();
            Globales.vendre.Show();
            this.Close();
        }

        private void btnAcheter_Click(object sender, EventArgs e)
        {
            Globales.acheter = new Acheter();
            Globales.acheter.Show();
            this.Close();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            Globales.services = new Services();
            Globales.services.Show();
            this.Close();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Globales.demarrage.Close();
        }
    }
}
