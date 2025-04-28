using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
                Globales.voiture = Globales.listeVoituresDuClient[0];
                groupBox1.Visible = false;
                gpbDescription.Visible = true;
                btnEnregistrer.Visible = false;

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
                btnEnregistrer.Visible = false;
                lsbVoituresClient.Items.Clear();
                foreach (Voiture uneVoit in Globales.listeVoituresDuClient)
                {
                    lsbVoituresClient.Items.Add($" {uneVoit.getMarque()}, {uneVoit.getModele()}, {uneVoit.getAnnee()}");
                }
                btnControleTechnique.Enabled = false;
                btnEntretien.Enabled = false;
            }
            else if(Globales.voiture == null)
            {
                btnControleTechnique.Enabled = false;
                btnEntretien.Enabled = false;
            }
            if(Globales.voiture != null)
            {
                groupBox1.Visible = false;
                gpbDescription.Visible = true;
                btnEnregistrer.Visible = false;

                lblMarque.Text = Globales.voiture.getMarque();
                lblModele.Text = Globales.voiture.getModele();
                lblAnnee.Text = Globales.voiture.getAnnee().ToString();
                lblKilometrage.Text = Globales.voiture.getKilometrage().ToString();
                lblCouleur.Text = Globales.voiture.getCouleur();
                lblImmat.Text = Globales.voiture.getImmatriculation();
                lblPuissance.Text = Globales.voiture.getPuissance().ToString();
                lblPrixNeuf.Text = Globales.voiture.getPrix().ToString("C");

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
                string.IsNullOrWhiteSpace(txtAnneeVoiture.Text) || (txtAnneeVoiture.TextLength != 4) || (Convert.ToInt32(txtAnneeVoiture.Text) > 2025) || (Convert.ToInt32(txtAnneeVoiture.Text) < 1950) ||
                string.IsNullOrWhiteSpace(txtKilometrageVoiture.Text) ||
                string.IsNullOrWhiteSpace(txtCouleurVoiture.Text) ||
                string.IsNullOrWhiteSpace(txtPuissanceVoiture.Text) ||
                string.IsNullOrWhiteSpace(txtImmatVoiture.Text) || (txtImmatVoiture.TextLength != 7) ||
                string.IsNullOrWhiteSpace(txtPrixNeuf.Text))
            {
                // Afficher un message d'erreur si des champs sont vides ou contiennent des messages par défaut
                MessageBox.Show("Veuillez remplir tous les champs correctement avant de continuer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Globales.voiture = new Voiture(txtMarqueVoiture.Text, txtModeleVoiture.Text, Convert.ToInt32(txtAnneeVoiture.Text), Convert.ToInt32(txtKilometrageVoiture.Text), txtCouleurVoiture.Text, Convert.ToInt32(txtPuissanceVoiture.Text), txtImmatVoiture.Text, Convert.ToInt32(txtPrixNeuf.Text), false);
                MessageBox.Show("Les informations ont été enregistrées avec succès.", "Enregistrement", MessageBoxButtons.OK);
                btnControleTechnique.Enabled = true;
                btnEntretien.Enabled = true;
            }
        }

        private void btnReparation_Click(object sender, EventArgs e){} //pas touche

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
            if (!Regex.IsMatch(txtMarqueVoiture.Text, @"^[a-zA-Z]+$"))
            {
                txtMarqueVoiture.Text = "";
            }
            btnControleTechnique.Enabled = false;
            btnEntretien.Enabled = false;
        }
        private void txtModeleVoiture_TextChanged(object sender, EventArgs e)
        {
            btnControleTechnique.Enabled = false;
            btnEntretien.Enabled = false;
        }
        private void txtAnneeVoiture_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtAnneeVoiture.Text, @"^\d*$"))
            {
                txtAnneeVoiture.Text = "";
            }
            btnControleTechnique.Enabled = false;
            btnEntretien.Enabled = false;
        }
        private void txtKilometrageVoiture_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtKilometrageVoiture.Text, @"^\d*$"))
            {
                txtKilometrageVoiture.Text = "";
            }
            btnControleTechnique.Enabled = false;
            btnEntretien.Enabled = false;
        }
        private void txtCouleurVoiture_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtCouleurVoiture.Text, @"^[a-zA-Z]+$"))
            {
                txtCouleurVoiture.Text = "";
            }
            btnControleTechnique.Enabled = false;
            btnEntretien.Enabled = false;
        }
        private void txtPuissanceVoiture_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtPuissanceVoiture.Text, @"^\d*$"))
            {
                txtPuissanceVoiture.Text = "";
            }
            btnControleTechnique.Enabled = false;
            btnEntretien.Enabled = false;
        }
        private void txtImmatVoiture_TextChanged(object sender, EventArgs e)
        {
            btnControleTechnique.Enabled = false;
            btnEntretien.Enabled = false;
        }

        private void lsbVoituresClient_SelectedIndexChanged(object sender, EventArgs e){} //pas touche

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
                lblPrixNeuf.Text = Globales.voiture.getPrix().ToString();

                btnControleTechnique.Enabled = true;
                btnEntretien.Enabled = true;
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une de vos voitures.");
            }
            
        }

        private void gpbDescription_Enter(object sender, EventArgs e){} //pas touche

        private void txtPrixNeuf_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtPrixNeuf.Text, @"^\d*$"))
            {
                txtPrixNeuf.Text = "";
            }
            btnControleTechnique.Enabled = false;
            btnEntretien.Enabled = false;
        }
    }
}
