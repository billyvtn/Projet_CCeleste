using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageCreditCeleste
{
    class ClControleTechnique
    {
        private string date;
        private string heure;
        private int cout;

        public ClControleTechnique(string uneDate, string uneHeure)
        {
            date = uneDate;
            heure = uneHeure;
            cout = 80;
        }

        public string GetDate()
        {
            return date;
        }

        public string GetHeure()
        {
            return heure;
        }

        public int GetCout()
        {
            return cout;
        }
    }
}
