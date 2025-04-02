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
    public partial class Credit : Form
    {
        public Credit()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e){} //pas toucher
        private void label16_Click(object sender, EventArgs e){}//idem


        private void Credit_Load(object sender, EventArgs e)
        {
            int i;
            for (i = 1; i <= 60; i++)
            {
                cbxDurée.Items.Add(i);
            }

            lblMarque.Text = Globales.voiture.getMarque();
            lblModele.Text = Globales.voiture.getModele();
            lblAnnee.Text = Globales.voiture.getAnnee().ToString();
            lblKilometrage.Text = Globales.voiture.getKilometrage().ToString();
            lblCouleur.Text = Globales.voiture.getCouleur();
            lblPuissance.Text = Globales.voiture.getPuissance().ToString();
            lblImmat.Text = Globales.voiture.getImmatriculation();
            lblPrix.Text = Globales.voiture.getPrix().ToString("C"); // Affichage en format monétaire

            lblMontant.Text = Convert.ToString(Globales.voiture.getPrix());
        }
        ClCredit unCredit;
        private void btnCalcul_Click(object sender, EventArgs e)
        {
            if (cbxDurée.Text != "" && txtTauxAnnuel.Text != "")
            {
                unCredit = new ClCredit(Convert.ToDouble(lblMontant.Text), Convert.ToInt32(cbxDurée.Text), Convert.ToDouble(txtTauxAnnuel.Text));
                btnConfirmer.Enabled = true;
                lblMens.Text = Convert.ToString(unCredit.getMensualiteCredit());
            }
            else
            {
                MessageBox.Show("Veuillez remplir les champs durée et taux.");
            }
        }

        private void txtApport_TextChanged(object sender, EventArgs e)
        {
            btnCalcul.Enabled = false;
            btnApport.Enabled = true;
            if (txtApport.Text == "")
            {
                lblMontant.Text = Convert.ToString(Globales.voiture.getPrix());
                btnCalcul.Enabled = true;
                btnApport.Enabled = false;
            }
            lblMens.Text = "";
            btnConfirmer.Enabled = false;

        }

        private void btnApport_Click(object sender, EventArgs e)
        {
            btnCalcul.Enabled = true;
            btnApport.Enabled = false;
            lblMontant.Text = Convert.ToString(Globales.voiture.getPrix() - Convert.ToInt32(txtApport.Text));
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            Globales.credit = unCredit;

            MessageBox.Show("Les informations ont été enregistrées avec succès.", "Enregistrement", MessageBoxButtons.OK);

            Globales.Type.Add("Credit");
            Globales.accueil = new Accueil();
            Globales.accueil.Show();
            Globales.frmCredit.Close();
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            DialogResult choix = MessageBox.Show(
                "Voulez-vous annuler votre crédit ?",
                "Finalisation de l'achat",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (choix == DialogResult.Yes)
            {
                Globales.accueil = new Accueil();
                Globales.accueil.Show();
                Globales.frmCredit.Close();
            }
            else if (choix == DialogResult.No)
            {


            }
        }
    }
}
