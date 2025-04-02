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

        public ClControleTechnique(string uneDate, string uneHeure)
        {
            date = uneDate;
            heure = uneHeure;
        }

        public string GetDate()
        {
            return date;
        }

        public string GetHeure()
        {
            return heure;
        }
    }
}
