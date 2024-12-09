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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            if (Globales.client != null)
            {
                btnAcheter.Enabled = true;
                btnVendre.Enabled = true;
                btnServices.Enabled = true;

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
        }
        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {
            txtPrenom.ForeColor = SystemColors.ControlText;
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.ForeColor = SystemColors.ControlText;
        }
        private void txtNumeroTelephone_TextChanged(object sender, EventArgs e)
        {
            txtNumeroTelephone.ForeColor = SystemColors.ControlText;
        }
        private void txtAdresseNum_TextChanged(object sender, EventArgs e)
        {
            txtAdresseNum.ForeColor = SystemColors.ControlText;
        }
        private void txtAdresseVoie_TextChanged(object sender, EventArgs e)
        {
            txtAdresseVoie.ForeColor = SystemColors.ControlText;
        }
        private void txtAdresseVille_TextChanged(object sender, EventArgs e)
        {
            txtAdresseVille.ForeColor = SystemColors.ControlText;
        }
        private void txtAdresseCP_TextChanged(object sender, EventArgs e)
        {
            txtAdresseCP.ForeColor = SystemColors.ControlText;
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

                MessageBox.Show("Les informations ont été enregistrées avec succès.", "Enregistrement", MessageBoxButtons.OK);
            }
        }

      
    }
}
