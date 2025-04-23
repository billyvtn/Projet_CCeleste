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

        private void Services_Load(object sender, EventArgs e)
        {
            if(Globales.listeVoituresDuClient.Count() == 1 && Globales.voiture == null)
            {
                groupBox1.Visible = false;
                gpbDescription.Visible = true;

                lblMarque.Text = Globales.listeVoituresDuClient[0].getMarque();
                lblModele.Text = Globales.listeVoituresDuClient[0].getModele();
                lblAnnee.Text = Globales.listeVoituresDuClient[0].getAnnee().ToString();
                lblKilometrage.Text = Globales.listeVoituresDuClient[0].getKilometrage().ToString();
                lblCouleur.Text = Globales.listeVoituresDuClient[0].getCouleur();
                lblImmat.Text = Globales.listeVoituresDuClient[0].getImmatriculation();
                lblPuissance.Text = Globales.listeVoituresDuClient[0].getPuissance().ToString();

                if (Globales.Type.Contains("ControleTechnique"))
                {
                    btnControleTechnique.Enabled = false;
                }
                if (Globales.Type.Contains("Entretien"))
                {
                    btnEntretien.Enabled = false;
                }
            }
            else if (Globales.listeVoituresDuClient.Count() > 1 && Globales.voiture == null)
            {
                groupBox1.Visible = false;
                gpbSelection.Visible = true;
                lsbVoituresClient.Items.Clear();
                foreach (Voiture uneVoit in Globales.listeVoituresDuClient)
                {
                    lsbVoituresClient.Items.Add($" {uneVoit.getMarque()}, {uneVoit.getModele()}, {uneVoit.getAnnee()}");
                }
                btnControleTechnique.Enabled = false;
                btnReparation.Enabled = false;
                btnEntretien.Enabled = false;
            }
            else if(Globales.listeVoituresDuClient.Count() == 0)
            {
                btnControleTechnique.Enabled = false;
                btnReparation.Enabled = false;
                btnEntretien.Enabled = false;
            }
            if(Globales.voiture != null)
            {
                groupBox1.Visible = false;
                gpbDescription.Visible = true;

                lblMarque.Text = Globales.voiture.getMarque();
                lblModele.Text = Globales.voiture.getModele();
                lblAnnee.Text = Globales.voiture.getAnnee().ToString();
                lblKilometrage.Text = Globales.voiture.getKilometrage().ToString();
                lblCouleur.Text = Globales.voiture.getCouleur();
                lblImmat.Text = Globales.voiture.getImmatriculation();
                lblPuissance.Text = Globales.voiture.getPuissance().ToString();

                if (Globales.Type.Contains("ControleTechnique"))
                {
                    btnControleTechnique.Enabled = false;
                }
                if (Globales.Type.Contains("Entretien"))
                {
                    btnEntretien.Enabled = false;
                }
            }

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
            if (string.IsNullOrWhiteSpace(txtMarqueVoiture.Text) ||
                string.IsNullOrWhiteSpace(txtModeleVoiture.Text) ||
                string.IsNullOrWhiteSpace(txtAnneeVoiture.Text) ||
                string.IsNullOrWhiteSpace(txtKilometrageVoiture.Text) ||
                string.IsNullOrWhiteSpace(txtCouleurVoiture.Text) ||
                string.IsNullOrWhiteSpace(txtPuissanceVoiture.Text) ||
                string.IsNullOrWhiteSpace(txtImmatVoiture.Text))
            {
                // Afficher un message d'erreur si des champs sont vides ou contiennent des messages par défaut
                MessageBox.Show("Veuillez remplir tous les champs correctement avant de continuer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Globales.voiture = new Voiture(txtMarqueVoiture.Text, txtModeleVoiture.Text, Convert.ToInt32(txtAnneeVoiture.Text), Convert.ToInt32(txtKilometrageVoiture.Text), txtCouleurVoiture.Text, Convert.ToInt32(txtPuissanceVoiture.Text), txtImmatVoiture.Text, false);
                MessageBox.Show("Les informations ont été enregistrées avec succès.", "Enregistrement", MessageBoxButtons.OK);
                btnControleTechnique.Enabled = true;
                btnReparation.Enabled = true;
                btnEntretien.Enabled = true;
            }
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

        private void txtMarqueVoiture_TextChanged(object sender, EventArgs e)
        {
            btnControleTechnique.Enabled = false;
            btnReparation.Enabled = false;
            btnEntretien.Enabled = false;
        }
        private void txtModeleVoiture_TextChanged(object sender, EventArgs e)
        {
            btnControleTechnique.Enabled = false;
            btnReparation.Enabled = false;
            btnEntretien.Enabled = false;
        }
        private void txtAnneeVoiture_TextChanged(object sender, EventArgs e)
        {
            btnControleTechnique.Enabled = false;
            btnReparation.Enabled = false;
            btnEntretien.Enabled = false;
        }
        private void txtKilometrageVoiture_TextChanged(object sender, EventArgs e)
        {
            btnControleTechnique.Enabled = false;
            btnReparation.Enabled = false;
            btnEntretien.Enabled = false;
        }
        private void txtCouleurVoiture_TextChanged(object sender, EventArgs e)
        {
            btnControleTechnique.Enabled = false;
            btnReparation.Enabled = false;
            btnEntretien.Enabled = false;
        }
        private void txtPuissanceVoiture_TextChanged(object sender, EventArgs e)
        {
            btnControleTechnique.Enabled = false;
            btnReparation.Enabled = false;
            btnEntretien.Enabled = false;
        }
        private void txtImmatVoiture_TextChanged(object sender, EventArgs e)
        {
            btnControleTechnique.Enabled = false;
            btnReparation.Enabled = false;
            btnEntretien.Enabled = false;
        }

        private void lsbVoituresClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (lsbVoituresClient.SelectedIndex  != -1)
            {
                Globales.voiture = Globales.listeVoituresDuClient[lsbVoituresClient.SelectedIndex];
                gpbSelection.Visible = false;
                gpbDescription.Visible = true;

                lblMarque.Text = Globales.voiture.getMarque();
                lblModele.Text = Globales.voiture.getModele();
                lblAnnee.Text = Globales.voiture.getAnnee().ToString();
                lblKilometrage.Text = Globales.voiture.getKilometrage().ToString();
                lblCouleur.Text = Globales.voiture.getCouleur();
                lblImmat.Text = Globales.voiture.getImmatriculation();
                lblPuissance.Text = Globales.voiture.getPuissance().ToString();

                btnControleTechnique.Enabled = true;
                btnReparation.Enabled = true;
                btnEntretien.Enabled = true;
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une de vos voitures.");
            }
            
        }
    }
}
