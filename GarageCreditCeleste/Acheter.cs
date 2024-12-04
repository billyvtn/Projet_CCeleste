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
    public partial class Acheter : Form
    {
        public Acheter()
        {
            InitializeComponent();
        }

        private void Acheter_Load(object sender, EventArgs e)
        {

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
    }
}
