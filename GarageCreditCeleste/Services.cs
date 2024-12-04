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
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Globales.accueil = new Accueil();
            Globales.accueil.Show();
            Globales.services.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            //enregistre les infos de la voiture dans un objet Globales pour réafficher dans les fenetres de services
        }

        private void btnReparation_Click(object sender, EventArgs e)
        {
            Globales.reparation = new Reparation();
            Globales.reparation.Show();
            Globales.services.Close();
        }

        private void btnControleTechnique_Click(object sender, EventArgs e)
        {
            Globales.controletechnique = new ControleTechnique();
            Globales.controletechnique.Show();
            Globales.services.Close();
        }

        private void btnEntretien_Click(object sender, EventArgs e)
        {
            Globales.entretien = new Entretien();
            Globales.entretien .Show();
            Globales.services.Close();
        }
    }
}
