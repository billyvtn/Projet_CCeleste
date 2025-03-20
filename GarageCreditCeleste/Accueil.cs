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
    public partial class Accueil : Form
    {
        List<Client> lesClients = new List<Client>();

        public Accueil()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            if (Globales.client != null)
            {
                if (Globales.client.getCivilite())
                {
                    rdbCivHomme.Checked = true;
                }
                else
                {
                    rdbCivFemme.Checked = false;
                }
                txtNom.Text = Globales.client.getNom();
                txtPrenom.Text = Globales.client.getPrenom();
                txtEmail.Text = Globales.client.getEmail();
                txtNumeroTelephone.Text = Globales.client.getNumeroTelephone();
                txtAdresseNum.Text = Globales.client.getAdresseNum();
                txtAdresseVoie.Text = Globales.client.getAdresseVoie();
                txtAdresseVille.Text = Globales.client.getVille();
                txtAdresseCP.Text = Globales.client.getCodePostal();
                btnAcheter.Enabled = true;
                btnVendre.Enabled = true;
                btnServices.Enabled = true;
            }

            if (Globales.Type != null)
            {
                btnAcheter.Visible = false;
                btnVendre.Visible = false;
                btnServices.Visible = false;
                gpbResume.Visible = true;

                string civi;
                if (Globales.client.getCivilite())
                {
                    //rdbCivHomme.Checked = true;
                    civi = "Mr. ";
                }
                else
                {
                    //rdbCivFemme.Checked = false;
                    civi = "Mme. ";
                }
                gpbInfoClient.Visible = false;
                gpbInfoFixe.Visible = true;
                lblCivNomPrenom.Text = civi + Globales.client.getNom() + " " + Globales.client.getPrenom();
                lblEmail.Text = Globales.client.getEmail();
                lblNumero.Text = Globales.client.getNumeroTelephone();
                lblAdresse.Text = Globales.client.getAdresseNum() + " " + Globales.client.getAdresseVoie();
                lblVilleCP.Text = Globales.client.getVille() + " " + Globales.client.getCodePostal();

                if (Globales.Type == "Vente")
                {
                    gpbType.Visible = true;
                    gpbType.Text = "Vente";

                    lblMarque.Text = Globales.voiture.getMarque();
                    lblModele.Text = Globales.voiture.getModele();
                    lblAnnee.Text = Globales.voiture.getAnnee().ToString();
                    lblKilometrage.Text = Globales.voiture.getKilometrage().ToString() + "km";
                    lblCouleur.Text = Globales.voiture.getCouleur();
                    lblPuissance.Text = Globales.voiture.getPuissance().ToString() + " cv";
                    lblImmat.Text = Globales.voiture.getImmatriculation();
                    lblPrix.Text = Globales.voiture.getPrix().ToString() + "€";
                }

                if (Globales.Type == "Achat")
                {
                    gpbType.Visible = true;
                    gpbType.Text = "Achat";

                    lblMarque.Text = Globales.voiture.getMarque();
                    lblModele.Text = Globales.voiture.getModele();
                    lblAnnee.Text = Globales.voiture.getAnnee().ToString();
                    lblKilometrage.Text = Globales.voiture.getKilometrage().ToString() + "km";
                    lblCouleur.Text = Globales.voiture.getCouleur();
                    lblPuissance.Text = Globales.voiture.getPuissance().ToString() + " cv";
                    lblImmat.Text = Globales.voiture.getImmatriculation();
                    lblPrix.Text = Globales.voiture.getPrix().ToString() + "€";
                }
            }
        }

        //lien accueil --> vendre
        private void btnVendre_Click(object sender, EventArgs e)
        {
            Globales.vendre = new Vendre();
            Globales.vendre.Show();
            this.Close();
        }
        //lien accueil --> acheter
        private void btnAcheter_Click(object sender, EventArgs e)
        {
            Globales.acheter = new Acheter();
            Globales.acheter.Show();
            this.Close();
        }
        //lien accueil --> services
        private void btnServices_Click(object sender, EventArgs e)
        {
            Globales.services = new Services();
            Globales.services.Show();
            this.Close();
        }
        //bouton éteindre le logiciel
        private void btnFermer_Click(object sender, EventArgs e)
        {
            Globales.demarrage.Close();
        }

        
        // Messages par défaut des champs
        string defaultNom = "ex. Dupont";
        string defaultPrenom = "ex. Jean";
        string defaultEmail = "ex. jean.dupont@email.fr";
        string defaultNumTele = "ex. 06 06 06 06 06";
        string defaultAdresseNum = "ex. 1, 2, 12A...";
        string defaultAdresseVoie = "ex. rue Marechal Foch";
        string defaultAdresseVille = "ex. Lingolsheim";
        string defaultAdresseCP = "ex. 67380";


        private void txtNom_Click(object sender, EventArgs e)
        {
            if(txtNom.Text == defaultNom)
            {
                txtNom.Text = "";
                txtNom.ForeColor = SystemColors.ControlText;
            } 
        }
        private void txtPrenom_Click(object sender, EventArgs e)
        {
            if(txtPrenom.Text == defaultPrenom)
            {
                txtPrenom.Text = ""; 
                txtPrenom.ForeColor = SystemColors.ControlText;
            }
        }
        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == defaultEmail)
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = SystemColors.ControlText;
            }            
        }
        private void txtNumeroTelephone_Click(object sender, EventArgs e)
        {
            if (txtNumeroTelephone.Text == defaultNumTele)
            {
                txtNumeroTelephone.Text = "";
                txtNumeroTelephone.ForeColor = SystemColors.ControlText;
            }    
        }
        private void txtAdresse_Click(object sender, EventArgs e)
        {
            if (txtAdresseNum.Text == defaultAdresseNum)
            {
                txtAdresseNum.Text = "";
                txtAdresseNum.ForeColor = SystemColors.ControlText;
            }  
        }
        private void txtAdresseVoie_Click(object sender, EventArgs e)
        {
            if (txtAdresseVoie.Text == defaultAdresseVoie)
            {
                txtAdresseVoie.Text = "";
                txtAdresseVoie.ForeColor = SystemColors.ControlText;
            }
        }
        private void txtAdresseVille_Click(object sender, EventArgs e)
        {
            if (txtAdresseVille.Text == defaultAdresseVille)
            {
                txtAdresseVille.Text = "";
                txtAdresseVille.ForeColor = SystemColors.ControlText;
            }            
        }
        private void txtAdresseCP_Click(object sender, EventArgs e)
        {
            if (txtAdresseCP.Text == defaultAdresseCP)
            {
                txtAdresseCP.Text = "";
                txtAdresseCP.ForeColor = SystemColors.ControlText;

            }
        }


        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            txtNom.ForeColor = SystemColors.ControlText;
            btnAcheter.Enabled = false;
            btnVendre.Enabled = false;
            btnServices.Enabled = false;
        }
        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {
            txtPrenom.ForeColor = SystemColors.ControlText;
            btnAcheter.Enabled = false;
            btnVendre.Enabled = false;
            btnServices.Enabled = false;
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.ForeColor = SystemColors.ControlText;
            btnAcheter.Enabled = false;
            btnVendre.Enabled = false;
            btnServices.Enabled = false;
        }
        private void txtNumeroTelephone_TextChanged(object sender, EventArgs e)
        {
            txtNumeroTelephone.ForeColor = SystemColors.ControlText;
            btnAcheter.Enabled = false;
            btnVendre.Enabled = false;
            btnServices.Enabled = false;
        }
        private void txtAdresseNum_TextChanged(object sender, EventArgs e)
        {
            txtAdresseNum.ForeColor = SystemColors.ControlText;
            btnAcheter.Enabled = false;
            btnVendre.Enabled = false;
            btnServices.Enabled = false;
        }
        private void txtAdresseVoie_TextChanged(object sender, EventArgs e)
        {
            txtAdresseVoie.ForeColor = SystemColors.ControlText;
            btnAcheter.Enabled = false;
            btnVendre.Enabled = false;
            btnServices.Enabled = false;
        }
        private void txtAdresseVille_TextChanged(object sender, EventArgs e)
        {
            txtAdresseVille.ForeColor = SystemColors.ControlText;
            btnAcheter.Enabled = false;
            btnVendre.Enabled = false;
            btnServices.Enabled = false;
        }
        private void txtAdresseCP_TextChanged(object sender, EventArgs e)
        {
            txtAdresseCP.ForeColor = SystemColors.ControlText;
            btnAcheter.Enabled = false;
            btnVendre.Enabled = false;
            btnServices.Enabled = false;
        }


        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            //enregistrer infos client objet Globales
            // Vérification combinée des champs obligatoires, non vides, et différents des messages par défaut
            if (string.IsNullOrWhiteSpace(txtNom.Text) || txtNom.Text == defaultNom ||
                string.IsNullOrWhiteSpace(txtPrenom.Text) || txtPrenom.Text == defaultPrenom ||
                string.IsNullOrWhiteSpace(txtEmail.Text) || txtEmail.Text == defaultEmail ||
                string.IsNullOrWhiteSpace(txtNumeroTelephone.Text) || txtNumeroTelephone.Text == defaultNumTele ||
                string.IsNullOrWhiteSpace(txtAdresseNum.Text) || txtAdresseNum.Text == defaultAdresseNum ||
                string.IsNullOrWhiteSpace(txtAdresseVoie.Text) || txtAdresseVoie.Text == defaultAdresseVoie ||
                string.IsNullOrWhiteSpace(txtAdresseVille.Text) || txtAdresseVille.Text == defaultAdresseVille ||
                string.IsNullOrWhiteSpace(txtAdresseCP.Text) || txtAdresseCP.Text == defaultAdresseCP ||
                (rdbCivHomme.Checked == false && rdbCivFemme.Checked == false))
            {
                // Afficher un message d'erreur si des champs sont vides ou contiennent des messages par défaut
                MessageBox.Show("Veuillez remplir tous les champs correctement avant de continuer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool GlobalesCiv;
                if(rdbCivHomme.Checked)
                {
                    GlobalesCiv = true;
                }
                else
                {
                    GlobalesCiv = false;
                }

                Globales.client = new Client(GlobalesCiv, txtNom.Text, txtPrenom.Text, txtEmail.Text, txtNumeroTelephone.Text, txtAdresseNum.Text, txtAdresseVoie.Text, txtAdresseVille.Text, txtAdresseCP.Text); ;
                
                btnAcheter.Enabled = true;
                btnVendre.Enabled = true;
                btnServices.Enabled = true;
                btnEnregistrer.Enabled = false;
                btnConnecter.Enabled = false;
                MessageBox.Show("Les informations ont été enregistrées avec succès.", "Enregistrement", MessageBoxButtons.OK);
            }
        }

        private void lblPrix_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            InsererVoiture();
        }

        private void InsererVoiture()
        {
            string connectionString = "Data Source=10.129.184.106;User Id=connEleveSio;password=mdpEleveSi0;Initial Catalog=PROJETCC_K";
            string strRequete = "INSERT INTO VEHICULE (Marque, Modele, Annee, Valeur, Kilometrage, Couleur, Puissance, StatutDisp, Immat, idUtilisateur) " +
                                "VALUES (@Marque, @Modele, @Annee, @Valeur, @Kilometrage, @Couleur, @Puissance, @StatutDisp, @Immat, @idUtilisateur)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(strRequete, connection))
                {
                    try
                    {
                        // Ajout des paramètres sécurisés
                        command.Parameters.AddWithValue("@Marque", Globales.voiture.getMarque());
                        command.Parameters.AddWithValue("@Modele", Globales.voiture.getModele());
                        command.Parameters.AddWithValue("@Annee", Globales.voiture.getAnnee());
                        command.Parameters.AddWithValue("@Valeur", Globales.voiture.getPrix());
                        command.Parameters.AddWithValue("@Kilometrage", Globales.voiture.getKilometrage());
                        command.Parameters.AddWithValue("@Couleur", Globales.voiture.getCouleur());
                        command.Parameters.AddWithValue("@Puissance", Globales.voiture.getPuissance());
                        command.Parameters.AddWithValue("@StatutDisp", Globales.voiture.getStatutDispo());
                        command.Parameters.AddWithValue("@Immat", Globales.voiture.getImmatriculation());
                        command.Parameters.AddWithValue("@idUtilisateur", DBNull.Value); // NULL car c'est un véhicule du garage

                        // Ouvrir la connexion et exécuter la requête
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Erreur SQL : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            gpbInfoClient.Visible = false;
            gpbSeConnecter.Visible = true;
            RecupererClients();

            foreach(Client unClit in lesClients)
            {
                cboClient.Items.Add($" {unClit.getCiviliteString()}. {unClit.getNom()} {unClit.getPrenom()}");
            }
        }

        private void btnEnregistrerChoixClient_Click(object sender, EventArgs e)
        {
            gpbSeConnecter.Visible = false;
            gpbInfoFixe.Visible = true;
            gpbInfoClient.Visible = false;

            Globales.client = lesClients[cboClient.SelectedIndex];

            lblCivNomPrenom.Text = Globales.client.getCiviliteString() + " " + Globales.client.getNom() + " " + Globales.client.getPrenom();
            lblEmail.Text = Globales.client.getEmail();
            lblNumero.Text = Globales.client.getNumeroTelephone();
            lblAdresse.Text = Globales.client.getAdresseNum() + " " + Globales.client.getAdresseVoie();
            lblVilleCP.Text = Globales.client.getVille() + " " + Globales.client.getCodePostal();

            btnServices.Enabled = true;
            btnAcheter.Enabled = true;
            btnVendre.Enabled = true;
        }

        private List<Client> RecupererClients()
        {
            string connectionString = "Data Source=10.129.184.106;User Id=connEleveSio;password=mdpEleveSi0;Initial Catalog=PROJETCC_K";

            string strRequete = "SELECT * FROM UTILISATEUR";

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
                                Client unClient = new Client(Convert.ToBoolean(oReader[1]), Convert.ToString(oReader[2]), Convert.ToString(oReader[3]), Convert.ToString(oReader[4]), Convert.ToString(oReader[5]), Convert.ToString(oReader[6]), Convert.ToString(oReader[7]), Convert.ToString(oReader[8]), Convert.ToString(oReader[9]));
                                
                                lesClients.Add(unClient);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Erreur lors de la récupération des crédits : {ex.Message}");
                    }

                }
            }

            return lesClients;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Globales.demarrage.Close();
        }
    }
}
