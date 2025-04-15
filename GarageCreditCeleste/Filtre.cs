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
    public partial class Filtre : Form
    {
        List<Voiture> lesMarques = new List<Voiture>();
        public Filtre()
        {
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Globales.acheter = new Acheter();
            Globales.acheter.Show();
            Globales.filtre.Close();
        }

        private void btnAppliquer_Click(object sender, EventArgs e)
        {
            //ajouter les filtres dans un objet Globales pour les appliquer sur la recherche
            Globales.acheter = new Acheter();
            Globales.acheter.Show();
            Globales.filtre.Close();
        }

        private void Filtre_Load(object sender, EventArgs e)
        {
            List<Voiture> lesVoitures = RecupererMarques();

            cboMarque.Items.Clear();

            foreach (Voiture uneVoit in lesVoitures)
            {
                cboMarque.Items.Add($" {uneVoit.getMarque()}");
            }
        }

        public List<Voiture> RecupererMarques()
        {
            //connexion au lycée : 
            //string connectionString = "Data Source=10.129.184.106;User Id=connEleveSio;password=mdpEleveSi0;Initial Catalog=PROJETCC_K";
            //connexion à la maison :
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=PROJETCC_K;User Id=connEleveSio;Password=mdpEleveSi0;TrustServerCertificate=True;";

            string strRequete = "SELECT Marque FROM VEHICULE WHERE StatutDisp = 1";

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
                                Voiture uneMarque = new Voiture(Convert.ToString(oReader[0]));
                                lesMarques.Add(uneMarque);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Erreur SQL : {ex.Message}");
                    }
                }
            }
            return lesMarques;
        }
    }
}
