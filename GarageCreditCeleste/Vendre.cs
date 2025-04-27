using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GarageCreditCeleste
{
    public partial class Vendre : Form
    {
        private double prixFinalVoiture;

        public Vendre()
        {
            InitializeComponent();
        }

        private void Vendre_Load(object sender, EventArgs e)
        {
            btnCalculPrix.Enabled = false;

            if (Globales.listeVoituresDuClient.Count() == 1 && Globales.voiture == null)
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
            }
            if (Globales.voiture != null)
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
            }
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
            if(Globales.voiture == null)
            {
                if (string.IsNullOrWhiteSpace(txtMarqueVoiture.Text) ||
                string.IsNullOrWhiteSpace(txtModeleVoiture.Text) ||
                string.IsNullOrWhiteSpace(txtAnneeVoiture.Text) ||
                string.IsNullOrWhiteSpace(txtKilometrageVoiture.Text) ||
                string.IsNullOrWhiteSpace(txtCouleurVoiture.Text) ||
                string.IsNullOrWhiteSpace(txtPuissanceVoiture.Text) ||
                string.IsNullOrWhiteSpace(txtImmatVoiture.Text) ||
                string.IsNullOrWhiteSpace(txtPrixNeuf.Text))
                {
                    // Afficher un message d'erreur si des champs sont vides ou contiennent des messages par défaut
                    MessageBox.Show("Veuillez remplir tous les champs correctement avant de continuer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Globales.Type.Add("Vente1");

                    Globales.voitureRachat = new Voiture(txtMarqueVoiture.Text, txtModeleVoiture.Text, Convert.ToInt32(txtAnneeVoiture.Text), Convert.ToInt32(txtKilometrageVoiture.Text), txtCouleurVoiture.Text, Convert.ToInt32(txtPuissanceVoiture.Text), txtImmatVoiture.Text, prixFinalVoiture);

                    MessageBox.Show("Les informations ont été enregistrées avec succès.", "Enregistrement", MessageBoxButtons.OK);

                    // Afficher un message avec deux choix
                    DialogResult choix = MessageBox.Show(
                        "Voulez-vous acheter une nouvelle voiture ?",
                        "Finalisation de la vente",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (choix == DialogResult.Yes)
                    {
                        Globales.acheter = new Acheter();
                        Globales.acheter.Show();
                        Globales.vendre.Close();
                    }
                    else if (choix == DialogResult.No)
                    {
                        Globales.accueil = new Accueil();
                        Globales.accueil.Show();
                        Globales.vendre.Close();
                    }
                }
            }
            else
            {
                Globales.Type.Add("Vente2");

                Globales.voitureRachat = new Voiture(Globales.voiture.getMarque(), Globales.voiture.getModele(), Globales.voiture.getAnnee(), Globales.voiture.getKilometrage(), Globales.voiture.getCouleur(), Globales.voiture.getPuissance(), Globales.voiture.getImmatriculation(), prixFinalVoiture);

                MessageBox.Show("Les informations ont été enregistrées avec succès.", "Enregistrement", MessageBoxButtons.OK);

                // Afficher un message avec deux choix
                DialogResult choix = MessageBox.Show(
                    "Voulez-vous acheter une nouvelle voiture ?",
                    "Finalisation de la vente",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (choix == DialogResult.Yes)
                {
                    Globales.acheter = new Acheter();
                    Globales.acheter.Show();
                    Globales.vendre.Close();
                }
                else if (choix == DialogResult.No)
                {
                    Globales.accueil = new Accueil();
                    Globales.accueil.Show();
                    Globales.vendre.Close();
                }
            }
        }

        private void btnCalculPrix_Click(object sender, EventArgs e)
        {
            // Vérifier que les champs nécessaires ne sont pas vides
            if(Globales.voiture == null)
            {
                if (string.IsNullOrWhiteSpace(txtMarqueVoiture.Text) ||
                string.IsNullOrWhiteSpace(txtModeleVoiture.Text) ||
                string.IsNullOrWhiteSpace(txtAnneeVoiture.Text) ||
                string.IsNullOrWhiteSpace(txtKilometrageVoiture.Text) ||
                string.IsNullOrWhiteSpace(txtCouleurVoiture.Text) ||
                string.IsNullOrWhiteSpace(txtPuissanceVoiture.Text) ||
                string.IsNullOrWhiteSpace(txtImmatVoiture.Text) ||
                string.IsNullOrWhiteSpace(txtAnneeVoiture.Text) ||
                string.IsNullOrWhiteSpace(txtPrixNeuf.Text) ||
                string.IsNullOrWhiteSpace(txtKilometrageVoiture.Text))
                {
                    // Afficher un message d'erreur si des champs sont vides ou contiennent des messages par défaut
                    MessageBox.Show("Veuillez remplir tous les champs correctement avant de continuer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    btnEnregistrer.Enabled = true;
                    // Déclaration des variables
                    int anneeActuelle = DateTime.Now.Year;
                    int anneeVoiture = Convert.ToInt32(txtAnneeVoiture.Text);
                    int ageVoiture = anneeActuelle - anneeVoiture;
                    int kilometrage = Convert.ToInt32(txtKilometrageVoiture.Text);
                    int prixNeuf = Convert.ToInt32(txtPrixNeuf.Text);

                    // Calcul de la dépréciation
                    double depreciationAge = 0.04 * ageVoiture; // Perte de 4% par an
                    double depreciationKilometrage = (kilometrage / 30000) * 0.02; // Perte de 2% tous les 30 000 km

                    // Prix final après dépréciation
                    prixFinalVoiture = prixNeuf * (1 - (depreciationAge + depreciationKilometrage));

                    if (prixFinalVoiture < 500)
                    {
                        prixFinalVoiture = 500;
                        lblPrixVente.Text = prixFinalVoiture.ToString("C2");
                    }
                    else
                    {
                        // Affichage du résultat
                        lblPrixVente.Text = prixFinalVoiture.ToString("C2");
                    }

                }
            }
            else
            {
                btnEnregistrer.Enabled = true;
                // Déclaration des variables
                int anneeActuelle = DateTime.Now.Year;
                int anneeVoiture = Globales.voiture.getAnnee();
                int ageVoiture = anneeActuelle - anneeVoiture;
                int kilometrage = Globales.voiture.getKilometrage();
                int prixNeuf = Convert.ToInt32(Globales.voiture.getPrix());

                // Calcul de la dépréciation
                double depreciationAge = 0.04 * ageVoiture; // Perte de 4% par an
                double depreciationKilometrage = (kilometrage / 30000) * 0.02; // Perte de 2% tous les 30 000 km

                // Prix final après dépréciation
                prixFinalVoiture = prixNeuf * (1 - (depreciationAge + depreciationKilometrage));

                if (prixFinalVoiture < 500)
                {
                    prixFinalVoiture = 500;
                    lblPrixVente.Text = prixFinalVoiture.ToString("C2");
                }
                else
                {
                    // Affichage du résultat
                    lblPrixVente.Text = prixFinalVoiture.ToString("C2");
                }
            }
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (lsbVoituresClient.SelectedIndex != -1)
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
                lblPrixNeuf.Text += Convert.ToString(Globales.voiture.getPrix());

                btnCalculPrix.Enabled = true;
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une de vos voitures.");
            }
        }
    }
}
