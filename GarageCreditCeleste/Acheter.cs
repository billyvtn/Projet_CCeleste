﻿using System;
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
    public partial class Acheter : Form
    {
        List<Voiture> lesVoitures = new List<Voiture>();
        public Acheter()
        {
            InitializeComponent();
        }

        private void Acheter_Load(object sender, EventArgs e)
        {
            List<Voiture> lesVoitures = RecupererVoitures();

            lsbVoituresDispo.Items.Clear();

            foreach (Voiture uneVoit in lesVoitures)
            {
                lsbVoituresDispo.Items.Add($" {uneVoit.getMarque()}, {uneVoit.getModele()}, {uneVoit.getAnnee()}");
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        { 
            Globales.accueil = new Accueil();
            Globales.accueil.Show();

            this.Close();
        }

        private void btnFiltrer_Click(object sender, EventArgs e)
        {
            Globales.filtre = new Filtre();
            Globales.filtre.Show();
            Globales.acheter.Close();
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            //placer les infos dans un objet Globales
            Globales.voiture = lesVoitures[lsbVoituresDispo.SelectedIndex];
            Globales.Type.Add("Achat");

            // Afficher un message avec deux choix
            DialogResult choix = MessageBox.Show(
                "Voulez-vous souscrire à une de nos assurance ?",
                "Finalisation de l'achat",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (choix == DialogResult.Yes)
            {
                Globales.frmAssurance = new Assurance();
                Globales.frmAssurance.Show();
                Globales.acheter.Close();
            }
            else if (choix == DialogResult.No)
            {
                // Afficher un message avec deux choix
                DialogResult choix2 = MessageBox.Show(
                    "Voulez-vous payez votre voiture avec un crédit ?",
                    "Finalisation de l'achat",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (choix2 == DialogResult.Yes)
                {
                    Globales.frmCredit = new Credit();
                    Globales.frmCredit.Show();
                    Globales.acheter.Close();
                }
                else if (choix2 == DialogResult.No)
                {
                    Globales.accueil = new Accueil();
                    Globales.accueil.Show();
                    Globales.acheter.Close();
                }
            }

        }

        private void lsbVoituresDispo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbVoituresDispo.SelectedItem != null)
            {
                Voiture voitureSelectionnee = lesVoitures[lsbVoituresDispo.SelectedIndex];

                lblMarque.Text = voitureSelectionnee.getMarque();
                lblModele.Text = voitureSelectionnee.getModele();
                lblAnnee.Text = voitureSelectionnee.getAnnee().ToString();
                lblKilometrage.Text = voitureSelectionnee.getKilometrage().ToString();
                lblCouleur.Text = voitureSelectionnee.getCouleur();
                lblPuissance.Text = voitureSelectionnee.getPuissance().ToString();
                lblImmat.Text = voitureSelectionnee.getImmatriculation();
                lblPrix.Text = voitureSelectionnee.getPrix().ToString("C"); // Affichage en format monétaire
            }
        }

        public List<Voiture> RecupererVoitures()
        {
            //connexion au lycée : 
            //string connectionString = "Data Source=10.129.184.106;User Id=connEleveSio;password=mdpEleveSi0;Initial Catalog=PROJETCC_K";
            //connexion à la maison :
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=PROJETCC_K;User Id=connEleveSio;Password=mdpEleveSi0;TrustServerCertificate=True;";

            string strRequete = "SELECT * FROM VEHICULE WHERE StatutDisp = 1";

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
                                Voiture uneVoiture = new Voiture(Convert.ToString(oReader[1]), Convert.ToString(oReader[2]), Convert.ToInt32(oReader[3]), Convert.ToInt32(oReader[5]), Convert.ToString(oReader[6]), Convert.ToInt32(oReader[7]), Convert.ToString(oReader[9]), Convert.ToBoolean(oReader[8]), Convert.ToDouble(oReader[4]));
                                lesVoitures.Add(uneVoiture);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Erreur SQL : {ex.Message}");
                    }

                }
            }

            return lesVoitures;
        }
    }
}
