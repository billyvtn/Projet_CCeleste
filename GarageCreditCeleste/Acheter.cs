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
    public partial class Acheter : Form
    {
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
        }

        private void lsbVoituresDispo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public List<Voiture> RecupererVoitures()
        {
            string connectionString = "Data Source=10.129.184.106;User Id=connEleveSio;password=mdpEleveSi0;Initial Catalog=PROJETCC_K";

            List<Voiture> lesVoitures = new List<Voiture>();

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
                                Voiture unCredit = new Voiture(Convert.ToString(oReader[0]), Convert.ToString(oReader[1]), Convert.ToInt16(oReader[2]), Convert.ToInt16(oReader[3]), Convert.ToString(oReader[4]), Convert.ToInt16(oReader[5]), Convert.ToString(oReader[6]), Convert.ToInt16(oReader[7]));

                                lesVoitures.Add(unCredit);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Erreur lors de la récupération des crédits : {ex.Message}");
                    }

                }
            }

            return lesVoitures;
        }
    }
}
