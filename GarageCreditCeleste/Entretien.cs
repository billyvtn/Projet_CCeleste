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
    public partial class Entretien : Form
    {
        public Entretien()
        {
            InitializeComponent();
            calEntretien.MinDate = DateTime.Today; // Grise automatiquement les dates passées
            calEntretien.MaxSelectionCount = 1;   // Permet de sélectionner un seul jour à la fois
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Globales.services = new Services();
            Globales.services.Show();
            Globales.entretien.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            //enregistrer les infos du rdv dans un objet Globales
            List<string> lesEntretiens = new List<string>();

            foreach (CheckBox chk in gboPiece.Controls)
            {
                if (chk.Checked)
                {
                    lesEntretiens.Add(chk.Text);
                }
            }

            Globales.Entretien = new ClEntretien(calEntretien.SelectionStart.ToShortDateString(), Convert.ToString(cboHeure.SelectedItem), lesEntretiens);
            Globales.Type.Add("Entretien");

            MessageBox.Show("Les informations ont été enregistrées avec succès.", "Enregistrement", MessageBoxButtons.OK);

            if (Globales.Type.Contains("ControleTechnique") && Globales.Type.Contains("Entretien") && Globales.Type.Contains("Reparation"))
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
                    Globales.entretien.Close();
                }
                else if (choix == DialogResult.No)
                {
                    Globales.accueil = new Accueil();
                    Globales.accueil.Show();
                    Globales.entretien.Close();
                }
            }
        }

        private void Entretien_Load(object sender, EventArgs e)
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
                if (hour != 12)
                {
                    cboHeure.Items.Add($"{hour}:00");
                }
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e){}

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboHeure.SelectedIndex != -1 && calEntretien.SelectionStart != null && verifGboPiece())
            {
                lblDateHeureEntretien.Text += calEntretien.SelectionStart.ToShortDateString() + " " + Convert.ToString(cboHeure.SelectedItem);
                btnEnregistrer.Enabled = true;
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une date, un horaire et cochez au moins une pièce à entretenir pour continuer.");
            }      
        }

        public bool verifGboPiece()
        {
            bool coche = false;
            foreach (CheckBox chk in gboPiece.Controls)
            {
                if (chk.Checked)
                {
                    coche = true;
                }
            }
            return coche;
        }
    }
}
