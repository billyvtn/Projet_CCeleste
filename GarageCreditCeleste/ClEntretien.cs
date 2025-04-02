using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageCreditCeleste
{
    class ClEntretien
    {
        private string date;
        private string heure;
        private List<string> listeEntretien;

        public ClEntretien(string uneDate, string uneHeure, List<string> uneListe)
        {
            date = uneDate;
            heure = uneHeure;
            listeEntretien = uneListe;
        }

        public string GetDate()
        {
            return date;
        }

        public string GetHeure()
        {
            return heure;
        }

        public List<string> GetListeEntretien()
        {
            return listeEntretien;
        }
    }
}
