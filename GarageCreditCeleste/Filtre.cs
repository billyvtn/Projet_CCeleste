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
    public partial class Filtre : Form
    {
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
    }
}
