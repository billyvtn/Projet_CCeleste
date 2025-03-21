using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageCreditCeleste
{
    public class ClAssurance
    {
        private string typeAssurance;
        private double mensualite;
        private string dateDebut;

        public ClAssurance()
        {

        }
        public ClAssurance(string typeA, double mens, string dateD)
        {
            typeAssurance = typeA;
            mensualite = mens;
            dateDebut = dateD;
        }

        public string getTypeAssurance()
        {
            return typeAssurance;
        }

        public double getMensualite()
        {
            return mensualite;
        }

        public string getDateDebutAssurance()
        {
            return dateDebut;
        }
    }
}
