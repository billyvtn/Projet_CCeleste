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
    public partial class Reparation : Form
    {
        public Reparation()
        {
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Globales.services = new Services();
            Globales.services.Show();
            Globales.reparation.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            //enregistrer les infos du rdv dans un objet Globales
        }
    }
}
