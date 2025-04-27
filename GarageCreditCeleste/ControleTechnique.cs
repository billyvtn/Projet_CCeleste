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
    public partial class ControleTechnique : Form
    {
        public ControleTechnique()
        {
            InitializeComponent();
            calControleTechnique.MinDate = DateTime.Today; // Grise automatiquement les dates passées
            calControleTechnique.MaxSelectionCount = 1;   // Permet de sélectionner un seul jour à la fois
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Globales.services = new Services();
            Globales.services.Show();
            Globales.controletechnique.Close();
            
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            //enregistrer les infos du rdv dans un objet Globales
            Globales.controleTechnique = new ClControleTechnique(calControleTechnique.SelectionStart.ToShortDateString(), Convert.ToString(cboHeureCT.SelectedItem));
            Globales.Type.Add("ControleTechnique");

            MessageBox.Show("Les informations ont été enregistrées avec succès.", "Enregistrement", MessageBoxButtons.OK);

            if (Globales.Type.Contains("ControleTechnique") && Globales.Type.Contains("Entretien"))
            {
                Globales.accueil = new Accueil();
                Globales.accueil.Show();
                Globales.controletechnique.Close();
            }
            else
            {
                DialogResult choix = MessageBox.Show(
                "Voulez-vous utiliser nos autres services ?",
                "Services",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
                if (choix == DialogResult.Yes)
                {
                    Globales.services = new Services();
                    Globales.services.Show();
                    Globales.controletechnique.Close();
                }
                else if (choix == DialogResult.No)
                {
                    Globales.accueil = new Accueil();
                    Globales.accueil.Show();
                    Globales.controletechnique.Close();
                }
            }
        }

        private void ControleTechnique_Load(object sender, EventArgs e)
        {
            lblMarque.Text += Globales.voiture.getMarque();
            lblModele.Text += Globales.voiture.getModele();
            lblAnnee.Text += Globales.voiture.getAnnee();
            lblKilometrage.Text += Globales.voiture.getKilometrage();
            lblCouleur.Text += Globales.voiture.getCouleur();
            lblPuissance.Text += Globales.voiture.getPuissance();
            lblImmat.Text += Globales.voiture.getImmatriculation();

            for (int hour = 9; hour <= 17; hour++)
            {
                if(hour != 12)
                {
                    cboHeureCT.Items.Add($"{hour}:00");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e){}

        private void label3_Click(object sender, EventArgs e){}

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboHeureCT.SelectedIndex != -1 && calControleTechnique.SelectionStart != null)
            {
                lblDateHeureRDV.Text += calControleTechnique.SelectionStart.ToShortDateString() + " " + Convert.ToString(cboHeureCT.SelectedItem);
            }
            btnEnregistrer.Enabled = true;
            
        }
    }
}
