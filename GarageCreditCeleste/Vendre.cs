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
                txtPrixVenteVoiture.Text = Convert.ToString(Globales.voiture.getPrix());
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
                string.IsNullOrWhiteSpace(txtPrixVenteVoiture.Text))
            {
                // Afficher un message d'erreur si des champs sont vides ou contiennent des messages par défaut
                MessageBox.Show("Veuillez remplir tous les champs correctement avant de continuer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Globales.voiture = new Voiture(txtMarqueVoiture.Text, txtModeleVoiture.Text, Convert.ToInt32(txtAnneeVoiture.Text), Convert.ToInt32(txtKilometrageVoiture.Text), txtCouleurVoiture.Text, Convert.ToInt32(txtPuissanceVoiture.Text), txtImmatVoiture.Text, false, Convert.ToInt32(txtPrixVenteVoiture.Text));
                MessageBox.Show("Les informations ont été enregistrées avec succès.", "Enregistrement", MessageBoxButtons.OK);
                Globales.Type = "Vente";
                Globales.accueil = new Accueil();
                Globales.accueil.Show();
                Globales.vendre.Close();
            }
        }

        
    }
}
