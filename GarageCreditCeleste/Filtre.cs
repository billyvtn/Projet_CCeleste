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
    public partial class Filtre : Form
    {
        List<Voiture> lesMarques = new List<Voiture>();
        public Filtre()
        {
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Globales.acheter = new Acheter();
            Globales.acheter.Show();
            Globales.filtre.Close();
        }

        private void btnAppliquer_Click(object sender, EventArgs e)
        {
            //ajouter les filtres dans un objet Globales pour les appliquer sur la recherche
            if (txtPrixMini.Text != "Minimum" && txtPrixMini.Text != "")
            {
                Globales.Filtres.Add("PrixMin", txtPrixMini.Text);
            }
            if (txtPrixMaxi.Text != "Maximum" && txtPrixMini.Text != "")
            {
                Globales.Filtres.Add("PrixMax", txtPrixMaxi.Text);
            }


            if (txtAnneeMini.Text != "Minimum" && txtAnneeMini.Text != "")
            {
                Globales.Filtres.Add("AnneeMin", txtAnneeMini.Text);
            }
            if (txtAnneeMaxi.Text != "Maximum" && txtAnneeMaxi.Text != "")
            {
                Globales.Filtres.Add("AnneeMax", txtAnneeMaxi.Text);
            }


            if (txtKilometrageMini.Text != "Minimum" && txtKilometrageMini.Text != "")
            {
                Globales.Filtres.Add("KilometrageMin", txtKilometrageMini.Text);
            }
            if (txtKilometrageMaxi.Text != "Maximum" && txtKilometrageMaxi.Text != "")
            {
                Globales.Filtres.Add("KilometrageMax", txtKilometrageMaxi.Text);
            }


            if (txtPuissanceMini.Text != "Minimum" && txtPuissanceMini.Text != "")
            {
                Globales.Filtres.Add("PuissanceMin", txtPuissanceMini.Text);
            }
            if (txtPuissanceMaxi.Text != "Maximum" && txtPuissanceMaxi.Text != "")
            {
                Globales.Filtres.Add("PuissanceMax", txtPuissanceMaxi.Text);
            }


            if (txtCouleur.Text != "ex. rouge, bleu, noire..." && txtPuissanceMaxi.Text != "")
            {
                Globales.Filtres.Add("Couleur", txtCouleur.Text);
            }

            if (cboMarque.SelectedIndex != -1)
            {
                Globales.Filtres.Add("Marque", cboMarque.Text);
            }

            Globales.acheter = new Acheter();
            Globales.acheter.Show();
            Globales.filtre.Close();
        }

        private void Filtre_Load(object sender, EventArgs e)
        {
            List<Voiture> lesVoitures = RecupererMarques();

            cboMarque.Items.Clear();

            foreach (Voiture uneVoit in lesVoitures)
            {
                string marque = uneVoit.getMarque();
                if (!cboMarque.Items.Contains(marque))
                {
                    cboMarque.Items.Add(marque);
                }
            }

            Globales.Filtres.Clear();
        }

        public List<Voiture> RecupererMarques()
        {
            //connexion au lycée : 
            //string connectionString = "Data Source=10.129.184.106;User Id=connEleveSio;password=mdpEleveSi0;Initial Catalog=PROJETCC_K";
            //connexion à la maison :
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=PROJETCC_K;User Id=connEleveSio;Password=mdpEleveSi0;TrustServerCertificate=True;";

            string strRequete = "SELECT Marque FROM VEHICULE WHERE StatutDisp = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(strRequete, connection))
                {
                    try
                    {
                        //Ouvrir la connexion
                        connection.Open();

                        using (SqlDataReader oReader = command.ExecuteReader())
                        {
                            // Parcourir les résultats
                            while (oReader.Read())
                            {
                                Voiture uneMarque = new Voiture(Convert.ToString(oReader[0]));
                                lesMarques.Add(uneMarque);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Erreur SQL : {ex.Message}");
                    }
                }
            }
            return lesMarques;
        }

        private void txtPrixMini_TextChanged(object sender, EventArgs e){} //pas touche

        private void txtPrixMini_Click(object sender, EventArgs e)
        {
            if (txtPrixMini.Text == "Minimum")
            {
                txtPrixMini.Text = "";
                txtPrixMini.ForeColor = SystemColors.ControlText;
            }
        }
        private void txtPrixMaxi_Click(object sender, EventArgs e)
        {
            if (txtPrixMaxi.Text == "Maximum")
            {
                txtPrixMaxi.Text = "";
                txtPrixMaxi.ForeColor = SystemColors.ControlText;
            }
        }
        private void txtAnneeMini_Click(object sender, EventArgs e)
        {
            if (txtAnneeMini.Text == "Minimum")
            {
                txtAnneeMini.Text = "";
                txtAnneeMini.ForeColor = SystemColors.ControlText;
            }
        }
        private void txtAnneeMaxi_Click(object sender, EventArgs e)
        {
            if (txtAnneeMaxi.Text == "Maximum")
            {
                txtAnneeMaxi.Text = "";
                txtAnneeMaxi.ForeColor = SystemColors.ControlText;
            }
        }
        private void txtKilometrageMini_Click(object sender, EventArgs e)
        {
            if (txtKilometrageMini.Text == "Minimum")
            {
                txtKilometrageMini.Text = "";
                txtKilometrageMini.ForeColor = SystemColors.ControlText;
            }
        }
        private void txtKilometrageMaxi_Click(object sender, EventArgs e)
        {
            if (txtKilometrageMaxi.Text == "Maximum")
            {
                txtKilometrageMaxi.Text = "";
                txtKilometrageMaxi.ForeColor = SystemColors.ControlText;
            }
        }
        private void txtPuissanceMini_Click(object sender, EventArgs e)
        {
            if (txtPuissanceMini.Text == "Minimum")
            {
                txtPuissanceMini.Text = "";
                txtPuissanceMini.ForeColor = SystemColors.ControlText;
            }
        }
        private void txtPuissanceMaxi_Click(object sender, EventArgs e)
        {
            if (txtPuissanceMaxi.Text == "Maximum")
            {
                txtPuissanceMaxi.Text = "";
                txtPuissanceMaxi.ForeColor = SystemColors.ControlText;
            }
        }
        private void txtCouleur_Click(object sender, EventArgs e)
        {
            if (txtCouleur.Text == "ex. rouge, bleu, noire...")
            {
                txtCouleur.Text = "";
                txtCouleur.ForeColor = SystemColors.ControlText;
            }
        }
    }
}
