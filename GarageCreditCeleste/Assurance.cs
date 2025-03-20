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
    public partial class Assurance : Form
    {
        double prixFinal;
        public Assurance()
        {
            InitializeComponent();
        }

        private void Assurance_Load(object sender, EventArgs e)
        {
            rdbTousRisque.Checked = true;
            lblMarque.Text = Globales.voiture.getMarque();
            lblModele.Text = Globales.voiture.getModele();
            lblAnnee.Text = Globales.voiture.getAnnee().ToString();
            lblKilometrage.Text = Globales.voiture.getKilometrage().ToString();
            lblCouleur.Text = Globales.voiture.getCouleur();
            lblPuissance.Text = Globales.voiture.getPuissance().ToString();
            lblImmat.Text = Globales.voiture.getImmatriculation();
            lblPrix.Text = Globales.voiture.getPrix().ToString("C"); // Affichage en format monétaire
        }

        private void btnCalculMensualité_Click(object sender, EventArgs e)
        {
            double prixBase = 30;
            prixFinal = prixBase;

            double puissance = Globales.voiture.getPuissance();
            int annee = Globales.voiture.getAnnee();

            prixFinal += puissance * 1.5;

            prixFinal += (annee - 1990) * 1.1; // Plus la voiture est récente, plus c'est cher

            if (rdbTiers.Checked)
            {
                prixFinal += 10; 
            }
            else if (rdbTiersPlus.Checked)
            {
                prixFinal += 40; 
            }
            else if (rdbTousRisque.Checked)
            {
                prixFinal += 70; 
            }

            lblMensualite.Text = $"Mensualité : {prixFinal:C}"; // Affichage en format monétaire
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult choix = MessageBox.Show(
                "Voulez-vous payez votre voiture avec un crédit ?",
                "Finalisation de l'achat",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (choix == DialogResult.Yes)
            {
                Globales.credit = new Credit();
                Globales.credit.Show();
                Globales.frmAssurance.Close();
            }
            else if (choix == DialogResult.No)
            {
                Globales.Type = "Achat";
                Globales.accueil = new Accueil();
                Globales.accueil.Show();
                Globales.frmAssurance.Close();
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            DateTime dateActuelle = DateTime.Now;
            DateTime datePlusUnMois = dateActuelle.AddMonths(1);

            string dateDebutAssurance = datePlusUnMois.ToString("dd/MM/yyyy"); // Format JJ/MM/AAAA

            string typeAssurance;

            if (rdbTiers.Checked == true)
            {
                typeAssurance = "Tiers";
            }
            else if(rdbTiersPlus.Checked == true)
            {
                typeAssurance = "Tiers+";
            }
            else
            {
                typeAssurance = "Tous Risques";
            }

            Globales.assurance = new ClAssurance(typeAssurance, prixFinal, dateDebutAssurance);

            MessageBox.Show("Les informations ont été enregistrées avec succès.", "Enregistrement", MessageBoxButtons.OK);

            DialogResult choix = MessageBox.Show(
                "Voulez-vous payez votre voiture avec un crédit ?",
                "Finalisation de l'achat",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (choix == DialogResult.Yes)
            {
                Globales.credit = new Credit();
                Globales.credit.Show();
                Globales.frmAssurance.Close();
            }
            else if (choix == DialogResult.No)
            {
                // gestion du double type achat + assurance
                Globales.accueil = new Accueil();
                Globales.accueil.Show();
                Globales.frmAssurance.Close();
            }
        }
    }
}
