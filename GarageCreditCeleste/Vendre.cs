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
            if (Globales.voiture != null)
            {
                txtMarqueVoiture.Text = Globales.voiture.getMarque();
                txtModeleVoiture.Text = Globales.voiture.getModele();
                txtAnneeVoiture.Text = Convert.ToString(Globales.voiture.getAnnee());
                txtKilometrageVoiture.Text = Convert.ToString(Globales.voiture.getKilometrage());
                txtCouleurVoiture.Text = Globales.voiture.getCouleur();
                txtPuissanceVoiture.Text = Convert.ToString(Globales.voiture.getPuissance());
                txtImmatVoiture.Text = Globales.voiture.getImmatriculation();
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
                Globales.Type.Add("Vente");

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

        private void btnCalculPrix_Click(object sender, EventArgs e)
        {
            // Vérifier que les champs nécessaires ne sont pas vides
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

                if(prixFinalVoiture < 500)
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
    }
}
