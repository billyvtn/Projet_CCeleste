using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageCreditCeleste
{
    class CCredit
    {
        private double monMontant;
        private double monDuree;
        private double monTaux;
        private double monMensualite;

        // Constructeur par défaut
        public CCredit()
        {
        }

        // Constructeur avec montant, durée et taux
        public CCredit(double montant, double duree, double taux)
        {
            // Par défaut, en C#, les constructeurs sont publics sauf si spécifié autrement
            monMontant = montant;
            monDuree = duree;
            monTaux = taux;

            // Ici, c'est la mensualité qui sera calculée
            monMensualite = 0;
        }

        // Constructeur avec montant, durée, taux et mensualité
        public CCredit(double montant, double duree, double taux, double mensualite)
        {
            monMontant = montant;
            monDuree = duree;
            monTaux = taux;
            monMensualite = mensualite;

            // Ici, c'est la valeur de 0 qui sera calculée par itérations successives
        }

        // Méthode pour obtenir la mensualité
        public double GetMensualite()
        {
            // Formule :
            // m = V0 * i / (1 - (1 + i) ^ -n)
            // m = mensualité ; V0 = montant financé initial ; n = durée en mois ; i = taux annuel

            double tauxMens = monTaux / 1200; // Sur 12 mois en pourcentage
            monMensualite = Math.Round((monMontant * tauxMens) / (1 - Math.Pow(1 + tauxMens, -monDuree)), 2);

            return monMensualite;
        }
    }
}
