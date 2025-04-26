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

            btnValider.Enabled = false;
        }

        private void btnCalculMensualité_Click(object sender, EventArgs e)
        {
            double prixBase = 10;
            prixFinal = prixBase;

            double puissance = Globales.voiture.getPuissance();
            int annee = Globales.voiture.getAnnee();

            prixFinal += puissance * 1.01;

            prixFinal += (annee - 1990) * 1.01; // Plus la voiture est récente, plus c'est cher

            if (rdbTiers.Checked)
            {
                prixFinal += 10; 
            }
            else if (rdbTiersPlus.Checked)
            {
                prixFinal += 30; 
            }
            else if (rdbTousRisque.Checked)
            {
                prixFinal += 60; 
            }

            lblMensualite.Text = $"Mensualité : {prixFinal:C}"; // Affichage en format monétaire

            btnValider.Enabled = true;
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
                Globales.frmCredit = new Credit();
                Globales.frmCredit.Show();
                Globales.frmAssurance.Close();
            }
            else if (choix == DialogResult.No)
            {
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

            //if ((Globales.voiture.getPrix() - Globales.voitureRachat.getPrix()) > 0)
            //{
            //    DialogResult choix = MessageBox.Show(
            //    "Voulez-vous payez votre voiture avec un crédit ?",
            //    "Finalisation de l'achat",
            //    MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Question);

            //    if (choix == DialogResult.Yes)
            //    {
            //        Globales.frmCredit = new Credit();
            //        Globales.frmCredit.Show();
            //        Globales.frmAssurance.Close();
            //    }
            //    else if (choix == DialogResult.No)
            //    {
            //        Globales.accueil = new Accueil();
            //        Globales.accueil.Show();
            //        Globales.frmAssurance.Close();
            //    }
            //}
            //else
            //{
            //    Globales.accueil = new Accueil();
            //    Globales.accueil.Show();
            //    Globales.frmAssurance.Close();
            //}

            if (Globales.voitureRachat != null)
            {
                if ((Globales.voiture.getPrix() - Globales.voitureRachat.getPrix()) > 0)
                {
                    DialogResult choix = MessageBox.Show(
                        "Voulez-vous payer votre voiture avec un crédit ?",
                        "Finalisation de l'achat",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (choix == DialogResult.Yes)
                    {
                        Globales.frmCredit = new Credit();
                        Globales.frmCredit.Show();
                        Globales.frmAssurance.Close();
                    }
                    else if (choix == DialogResult.No)
                    {
                        Globales.accueil = new Accueil();
                        Globales.accueil.Show();
                        Globales.frmAssurance.Close();
                    }
                }
                else
                {
                    Globales.accueil = new Accueil();
                    Globales.accueil.Show();
                    Globales.frmAssurance.Close();
                }
            }
            else
            {
                DialogResult choix = MessageBox.Show(
                        "Voulez-vous payer votre voiture avec un crédit ?",
                        "Finalisation de l'achat",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (choix == DialogResult.Yes)
                {
                    Globales.frmCredit = new Credit();
                    Globales.frmCredit.Show();
                    Globales.frmAssurance.Close();
                }
                else if (choix == DialogResult.No)
                {
                    Globales.accueil = new Accueil();
                    Globales.accueil.Show();
                    Globales.frmAssurance.Close();
                }

            }



            Globales.Type.Add("Assurance");

            
        }
    }
}
