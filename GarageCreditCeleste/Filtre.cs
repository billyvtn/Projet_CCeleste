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
using System.Text.RegularExpressions;

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
            Globales.Filtres.Clear();
            bool erreur = false;

            if (txtPrixMini.Text != "Minimum" && txtPrixMini.Text != "")
            {
                if (!int.TryParse(txtPrixMini.Text, out int prixMin))
                {
                    MessageBox.Show("Le prix minimum doit être un nombre.");
                    txtPrixMini.Text = "";
                    erreur = true;
                }
                else if (txtPrixMaxi.Text != "Maximum" && txtPrixMaxi.Text != "")
                {
                    if (!int.TryParse(txtPrixMaxi.Text, out int prixMax))
                    {
                        MessageBox.Show("Le prix maximum doit être un nombre.");
                        txtPrixMaxi.Text = "";
                        erreur = true;
                    }
                    else if (prixMin > prixMax)
                    {
                        MessageBox.Show("Le prix minimum ne peut pas être supérieur au prix maximum.");
                        erreur = true;
                    }
                    else
                    {
                        Globales.Filtres.Add("PrixMin", prixMin.ToString());
                        Globales.Filtres.Add("PrixMax", prixMax.ToString());
                    }
                }
                else
                {
                    Globales.Filtres.Add("PrixMin", prixMin.ToString());
                }
            }
            else if (txtPrixMaxi.Text != "Maximum" && txtPrixMaxi.Text != "")
            {
                if (int.TryParse(txtPrixMaxi.Text, out int prixMax))
                    Globales.Filtres.Add("PrixMax", prixMax.ToString());
                else
                {
                    MessageBox.Show("Le prix maximum doit être un nombre.");
                    txtPrixMaxi.Text = "";
                    erreur = true;
                }
            }

            if (txtAnneeMini.Text != "Minimum" && txtAnneeMini.Text != "")
            {
                if (txtAnneeMini.TextLength == 4 &&
                    int.TryParse(txtAnneeMini.Text, out int anneeMin) &&
                    anneeMin >= 1950 && anneeMin <= 2025)
                {
                    if (txtAnneeMaxi.Text != "Maximum" && txtAnneeMaxi.Text != "")
                    {
                        if (txtAnneeMaxi.TextLength == 4 &&
                            int.TryParse(txtAnneeMaxi.Text, out int anneeMax) &&
                            anneeMax >= 1950 && anneeMax <= 2025)
                        {
                            if (anneeMin > anneeMax)
                            {
                                MessageBox.Show("L'année minimum ne peut pas être supérieure à l'année maximum.");
                                erreur = true;
                            }
                            else
                            {
                                Globales.Filtres.Add("AnneeMin", anneeMin.ToString());
                                Globales.Filtres.Add("AnneeMax", anneeMax.ToString());
                            }
                        }
                        else
                        {
                            MessageBox.Show("L'année maximum doit être un nombre de 4 chiffres entre 1950 et 2025.");
                            txtAnneeMaxi.Text = "";
                            erreur = true;
                        }
                    }
                    else
                    {
                        Globales.Filtres.Add("AnneeMin", anneeMin.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("L'année minimum doit être un nombre de 4 chiffres entre 1950 et 2025.");
                    txtAnneeMini.Text = "";
                    erreur = true;
                }
            }
            else if (txtAnneeMaxi.Text != "Maximum" && txtAnneeMaxi.Text != "")
            {
                if (txtAnneeMaxi.TextLength == 4 &&
                    int.TryParse(txtAnneeMaxi.Text, out int anneeMax) &&
                    anneeMax >= 1950 && anneeMax <= 2025)
                {
                    Globales.Filtres.Add("AnneeMax", anneeMax.ToString());
                }
                else
                {
                    MessageBox.Show("L'année maximum doit être un nombre de 4 chiffres entre 1950 et 2025.");
                    txtAnneeMaxi.Text = "";
                    erreur = true;
                }
            }

            if (txtKilometrageMini.Text != "Minimum" && txtKilometrageMini.Text != "")
            {
                if (!int.TryParse(txtKilometrageMini.Text, out int kiloMin))
                {
                    MessageBox.Show("Le kilométrage minimum doit être un nombre.");
                    txtKilometrageMini.Text = "";
                    erreur = true;
                }
                else if (txtKilometrageMaxi.Text != "Maximum" && txtKilometrageMaxi.Text != "")
                {
                    if (!int.TryParse(txtKilometrageMaxi.Text, out int kiloMax))
                    {
                        MessageBox.Show("Le kilométrage maximum doit être un nombre.");
                        txtKilometrageMaxi.Text = "";
                        erreur = true;
                    }
                    else if (kiloMin > kiloMax)
                    {
                        MessageBox.Show("Le kilométrage minimum ne peut pas être supérieur au kilométrage maximum.");
                        erreur = true;
                    }
                    else
                    {
                        Globales.Filtres.Add("KilometrageMin", kiloMin.ToString());
                        Globales.Filtres.Add("KilometrageMax", kiloMax.ToString());
                    }
                }
                else
                {
                    Globales.Filtres.Add("KilometrageMin", kiloMin.ToString());
                }
            }
            else if (txtKilometrageMaxi.Text != "Maximum" && txtKilometrageMaxi.Text != "")
            {
                if (int.TryParse(txtKilometrageMaxi.Text, out int kiloMax))
                    Globales.Filtres.Add("KilometrageMax", kiloMax.ToString());
                else
                {
                    MessageBox.Show("Le kilométrage maximum doit être un nombre.");
                    txtKilometrageMaxi.Text = "";
                    erreur = true;
                }
            }

            if (txtPuissanceMini.Text != "Minimum" && txtPuissanceMini.Text != "")
            {
                if (!int.TryParse(txtPuissanceMini.Text, out int puissMin))
                {
                    MessageBox.Show("La puissance minimum doit être un nombre.");
                    txtPuissanceMini.Text = "";
                    erreur = true;
                }
                else if (txtPuissanceMaxi.Text != "Maximum" && txtPuissanceMaxi.Text != "")
                {
                    if (!int.TryParse(txtPuissanceMaxi.Text, out int puissMax))
                    {
                        MessageBox.Show("La puissance maximum doit être un nombre.");
                        txtPuissanceMaxi.Text = "";
                        erreur = true;
                    }
                    else if (puissMin > puissMax)
                    {
                        MessageBox.Show("La puissance minimum ne peut pas être supérieure à la puissance maximum.");
                        erreur = true;
                    }
                    else
                    {
                        Globales.Filtres.Add("PuissanceMin", puissMin.ToString());
                        Globales.Filtres.Add("PuissanceMax", puissMax.ToString());
                    }
                }
                else
                {
                    Globales.Filtres.Add("PuissanceMin", puissMin.ToString());
                }
            }
            else if (txtPuissanceMaxi.Text != "Maximum" && txtPuissanceMaxi.Text != "")
            {
                if (int.TryParse(txtPuissanceMaxi.Text, out int puissMax))
                    Globales.Filtres.Add("PuissanceMax", puissMax.ToString());
                else
                {
                    MessageBox.Show("La puissance maximum doit être un nombre.");
                    txtPuissanceMaxi.Text = "";
                    erreur = true;
                }
            }

            if (txtCouleur.Text != "ex. rouge, bleu, noire..." && txtCouleur.Text != "")
            {
                Globales.Filtres.Add("Couleur", txtCouleur.Text);
            }

            if (cboMarque.SelectedIndex != -1)
            {
                Globales.Filtres.Add("Marque", cboMarque.Text);
            }

            if (!erreur)
            {
                Globales.acheter = new Acheter();
                Globales.acheter.Show();
                Globales.filtre.Close();
            }
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

        private void txtPrixMini_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtPrixMini.Text, @"^\d*$"))
            {
                txtPrixMini.Text = "";
            }
        }
        private void txtPrixMaxi_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtPrixMaxi.Text, @"^\d*$"))
            {
                txtPrixMaxi.Text = "";
            }
        }

        private void txtAnneeMini_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtAnneeMini.Text, @"^\d*$"))
            {
                txtAnneeMini.Text = "";
            }
        }

        private void txtAnneeMaxi_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtAnneeMaxi.Text, @"^\d*$"))
            {
                txtAnneeMaxi.Text = "";
            }
        }

        private void txtKilometrageMini_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtKilometrageMini.Text, @"^\d*$"))
            {
                txtKilometrageMini.Text = "";
            }
        }

        private void txtKilometrageMaxi_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtKilometrageMaxi.Text, @"^\d*$"))
            {
                txtKilometrageMaxi.Text = "";
            }
        }

        private void txtPuissanceMini_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtPuissanceMini.Text, @"^\d*$"))
            {
                txtPuissanceMini.Text = "";
            }
        }

        private void txtPuissanceMaxi_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtPuissanceMaxi.Text, @"^\d*$"))
            {
                txtPuissanceMaxi.Text = "";
            }
        }

        private void txtCouleur_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtCouleur.Text, @"^[a-zA-Z]+$"))
            {
                txtCouleur.Text = "";
            }
        }
    }
}
