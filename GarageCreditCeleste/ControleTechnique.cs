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
    public partial class ControleTechnique : Form
    {
        public ControleTechnique()
        {
            InitializeComponent();
            calControleTechnique.MinDate = DateTime.Today; // Grise automatiquement les dates passées
            calControleTechnique.MaxSelectionCount = 1;   // Permet de sélectionner un seul jour à la fois
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Globales.services = new Services();
            Globales.services.Show();
            Globales.controletechnique.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            //enregistrer les infos du rdv dans un objet Globales
        }

        private void ControleTechnique_Load(object sender, EventArgs e)
        {
            lblMarque.Text += Globales.voiture.getMarque();
            lblModele.Text += Globales.voiture.getModele();
            lblAnnee.Text += Globales.voiture.getAnnee();
            lblKilometrage.Text += Globales.voiture.getKilometrage();
            lblCouleur.Text += Globales.voiture.getCouleur();
            lblPuissance.Text += Globales.voiture.getPuissance();
            lblImmat.Text += Globales.voiture.getImmatriculation();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
