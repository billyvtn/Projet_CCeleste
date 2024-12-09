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
    public partial class Vendre : Form
    {
        public Vendre()
        {
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Globales.accueil = new Accueil();
            Globales.accueil.Show();
            Globales.vendre.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            //enregistre les infos du véhicule et le prix de vente dans l'objet
        }

        private void Vendre_Load(object sender, EventArgs e)
        {

        }
    }
}
