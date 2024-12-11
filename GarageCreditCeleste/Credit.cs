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
            int i;

            for (i = 1; i <= 180; i++)
            {
                cbxDurée.Items.Add(i);
            }
        }

        private void cbxDurée_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Globales.acheter = new Acheter();
            Globales.acheter.Show();
            this.Close();
        }

        private void cmdCalcul_Click(object sender, EventArgs e)
        {
            CCredit unCredit = new CCredit(Convert.ToDouble(txtMontantFinnance.Text), Convert.ToDouble(cbxDurée.Text), Convert.ToDouble(txtTauxAnnuel.Text));

            

            txtMensualité.Text = Convert.ToString(unCredit.GetMensualite());
        }
    }
}
