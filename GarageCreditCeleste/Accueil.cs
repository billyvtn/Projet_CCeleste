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
        DateTime dateActuelle = DateTime.Now;
        public Accueil()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            if (Globales.client != null)
            {
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
                btnAcheter.Enabled = true;
                btnVendre.Enabled = true;
                btnServices.Enabled = true;
            }

            if (Globales.Type.Count() > 1)
            {
                btnAcheter.Visible = false;
                btnVendre.Visible = false;
                btnServices.Visible = false;
                gpbResume.Visible = true;
                gpbPaiement.Visible = true;

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

                if (Globales.Type.Contains("Vente"))
                {
                    gpbVente.Visible = true;

                    lblMarqueVente.Text = Globales.voitureRachat.getMarque();
                    lblModeleVente.Text = Globales.voitureRachat.getModele();
                    lblAnneeVente.Text = Globales.voitureRachat.getAnnee().ToString();
                    lblKilometrageVente.Text = Globales.voitureRachat.getKilometrage().ToString() + "km";
                    lblCouleurVente.Text = Globales.voitureRachat.getCouleur();
                    lblPuissanceVente.Text = Globales.voitureRachat.getPuissance().ToString() + " cv";
                    lblImmatVente.Text = Globales.voitureRachat.getImmatriculation();
                    lblPrixVente.Text = Globales.voitureRachat.getPrix().ToString() + "€";
                }

                if (Globales.Type.Contains("Achat"))
                {
                    gpbAchat.Visible = true;

                    lblMarqueAchat.Text = Globales.voiture.getMarque();
                    lblModeleAchat.Text = Globales.voiture.getModele();
                    lblAnneeAchat.Text = Globales.voiture.getAnnee().ToString();
                    lblKilometrageAchat.Text = Globales.voiture.getKilometrage().ToString() + "km";
                    lblCouleurAchat.Text = Globales.voiture.getCouleur();
                    lblPuissanceAchat.Text = Globales.voiture.getPuissance().ToString() + " cv";
                    lblImmatAchat.Text = Globales.voiture.getImmatriculation();
                    lblPrixAchat.Text = Globales.voiture.getPrix().ToString() + "€";
                }

                if(Globales.Type.Contains("Assurance"))
                {
                    gpbAssurance.Visible = true;

                    lblTypeAssurance.Text = Globales.assurance.getTypeAssurance();
                    lblMensualiteAssurance.Text = Globales.assurance.getMensualite().ToString();
                    lblDateDebutAssurance.Text = Globales.assurance.getDateDebutAssurance();
                }

                if (Globales.Type.Contains("Credit"))
                {
                    gpbCredit.Visible = true;

                    lblMensualiteCredit.Text = Globales.credit.getMensualiteCredit().ToString();
                    lblDureeCredit.Text = Globales.credit.getDureeCredit().ToString();
                    lblMontantCredit.Text = Globales.credit.getMontantCredit().ToString();
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

        private void lblPrix_Click(object sender, EventArgs e){} // pas touche

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (Globales.Type.Contains("Vente"))
            {
                ConfirmerVente();
            }
            if (Globales.Type.Contains("Achat"))
            {
                if(Globales.Type.Contains("ClientExistant"))
                {
                    ConfirmerAchat();
                }
                else
                {
                    InsererClient();
                    ConfirmerAchat();
                }
            }
        }

        private void InsererClient()
        {
            //connexion au lycée : 
            //string connectionString = "Data Source=10.129.184.106;User Id=connEleveSio;password=mdpEleveSi0;Initial Catalog=PROJETCC_K";
            //connexion à la maison :
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=PROJETCC_K;User Id=connEleveSio;Password=mdpEleveSi0;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("InsClient", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        command.Parameters.AddWithValue("@Civ", Globales.client.getCivilite());
                        command.Parameters.AddWithValue("@Nom", Globales.client.getNom());
                        command.Parameters.AddWithValue("@Prenom", Globales.client.getPrenom());
                        command.Parameters.AddWithValue("@Email", Globales.client.getEmail());
                        command.Parameters.AddWithValue("@NumeroTel", Globales.client.getNumeroTelephone());
                        command.Parameters.AddWithValue("@AdresseNum", Globales.client.getAdresseNum());
                        command.Parameters.AddWithValue("@AdresseVoie", Globales.client.getAdresseVoie());
                        command.Parameters.AddWithValue("@AdresseVille", Globales.client.getVille());
                        command.Parameters.AddWithValue("@AdresseCP", Globales.client.getCodePostal());

                        // Ouvrir la connexion et exécuter la procédure stockée
                        connection.Open();
                        command.ExecuteNonQuery();

                        MessageBox.Show("Client inséré avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Erreur SQL : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ConfirmerAchat()
        {
            //connexion au lycée : 
            //string connectionString = "Data Source=10.129.184.106;User Id=connEleveSio;password=mdpEleveSi0;Initial Catalog=PROJETCC_K";
            //connexion à la maison :
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=PROJETCC_K;User Id=connEleveSio;Password=mdpEleveSi0;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("ConfirmerAchatVoiture", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Paramètres obligatoires
                    cmd.Parameters.AddWithValue("@Email", Globales.client.getEmail());
                    cmd.Parameters.AddWithValue("@Immat", Globales.voiture.getImmatriculation());
                    cmd.Parameters.AddWithValue("@DateAchat", DateTime.Now.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@ModePaiement", cboModePaiement.SelectedItem.ToString());

                    // Détection credit et assurance
                    bool avecCredit = Globales.Type.Contains("Credit");
                    bool avecAssurance = Globales.Type.Contains("Assurance");

                    cmd.Parameters.AddWithValue("@AvecCredit", avecCredit);
                    cmd.Parameters.AddWithValue("@AvecAssurance", avecAssurance);

                    // Paramètres crédit (si applicable)
                    if (avecCredit)
                    {
                        cmd.Parameters.AddWithValue("@MontantTotal", Convert.ToInt32(Globales.credit.getMontantCredit()));
                        cmd.Parameters.AddWithValue("@Mensualite", Convert.ToInt32(Globales.credit.getMensualiteCredit()));
                        cmd.Parameters.AddWithValue("@Duree", Convert.ToInt32(Globales.credit.getDureeCredit()));
                        cmd.Parameters.AddWithValue("@Taux", Convert.ToInt32(Globales.credit.getTauxCredit()));
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@MontantTotal", DBNull.Value);
                        cmd.Parameters.AddWithValue("@Mensualite", DBNull.Value);
                        cmd.Parameters.AddWithValue("@Duree", DBNull.Value);
                        cmd.Parameters.AddWithValue("@Taux", DBNull.Value);
                    }

                    // Paramètres assurance (si applicable)
                    if (avecAssurance)
                    {
                        cmd.Parameters.AddWithValue("@TypeAssurance", Globales.assurance.getTypeAssurance());
                        cmd.Parameters.AddWithValue("@MensualiteAssurance", Globales.assurance.getMensualite());
                        cmd.Parameters.AddWithValue("@DateDebutAssurance", Globales.assurance.getDateDebutAssurance());
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@TypeAssurance", DBNull.Value);
                        cmd.Parameters.AddWithValue("@MensualiteAssurance", DBNull.Value);
                        cmd.Parameters.AddWithValue("@DateDebutAssurance", DBNull.Value);
                    }

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Achat confirmé avec succès !");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la confirmation de l'achat : " + ex.Message);
                    }
                }
            }
        }

        private void ConfirmerVente()
        {
            //connexion au lycée : 
            //string connectionString = "Data Source=10.129.184.106;User Id=connEleveSio;password=mdpEleveSi0;Initial Catalog=PROJETCC_K";
            //connexion à la maison :
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=PROJETCC_K;User Id=connEleveSio;Password=mdpEleveSi0;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("InsVoitureEtVente", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        // Ajout des paramètres sécurisés
                        command.Parameters.AddWithValue("@Marque", Globales.voitureRachat.getMarque());
                        command.Parameters.AddWithValue("@Modele", Globales.voitureRachat.getModele());
                        command.Parameters.AddWithValue("@Annee", Globales.voitureRachat.getAnnee());
                        command.Parameters.AddWithValue("@Valeur", Globales.voitureRachat.getPrix());
                        command.Parameters.AddWithValue("@Kilometrage", Globales.voitureRachat.getKilometrage());
                        command.Parameters.AddWithValue("@Couleur", Globales.voitureRachat.getCouleur());
                        command.Parameters.AddWithValue("@Puissance", Globales.voitureRachat.getPuissance());
                        command.Parameters.AddWithValue("@StatutDisp", Globales.voitureRachat.getStatutDispo());
                        command.Parameters.AddWithValue("@Immat", Globales.voitureRachat.getImmatriculation());
                        command.Parameters.AddWithValue("@EmailUtilisateur", Globales.client.getEmail()); 
                        command.Parameters.AddWithValue("@PrixVente", Globales.voitureRachat.getPrix());
                        command.Parameters.AddWithValue("@DateVente", dateActuelle.ToString("dd/MM/yyyy"));
                        command.Parameters.AddWithValue("@ModePaiement", cboModePaiement.SelectedItem.ToString());

                        // Ouvrir la connexion et exécuter la procédure stockée
                        connection.Open();
                        command.ExecuteNonQuery();

                        MessageBox.Show("Voiture insérée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Globales.Type.Add("ClientExistant");

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
            //autre méthodes de connexion 
            //string connectionString = "Data Source=10.129.184.106; Initial Catalog = PROJETCC_K; Integrated Security = True";
            //string connectionString = "Data Source=10.129.184.106; Integrated Security=SSPI; Initial Catalog = PROJETCC_K";
            //string connectionString = "Data Source=S924P06; Initial Catalog=PROJETCC_K; Integrated Security=SSPI";

            //connexion au lycée : 
            //string connectionString = "Data Source=10.129.184.106;User Id=connEleveSio;password=mdpEleveSi0;Initial Catalog=PROJETCC_K";
            //connexion à la maison :
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=PROJETCC_K;User Id=connEleveSio;Password=mdpEleveSi0;TrustServerCertificate=True;";

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
                        MessageBox.Show($"Erreur SQL : {ex.Message}");
                    }

                }
            }

            return lesClients;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Globales.demarrage.Close();
        }

        private void cboModePaiement_SelectedIndexChanged(object sender, EventArgs e)
        {
                btnConfirmer.Enabled = cboModePaiement.SelectedIndex != -1;
        }

        private void cboClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEnregistrerChoixClient.Enabled = cboClient.SelectedIndex != -1;
        }
    }
}
