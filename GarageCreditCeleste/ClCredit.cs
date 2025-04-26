using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageCreditCeleste
{
    public class ClCredit
    {
        private double monMontant;
        private int monDuree;
        private double monTaux;
        private double monMensualite;
        private int monApport;
        private string dateDébut;

        public ClCredit()
        {
        }

        public ClCredit(double montant, int duree, double taux, string date)
        {
            monMontant = montant;
            monDuree = duree;
            monTaux = taux;
            dateDébut = date;
        }

        public ClCredit(double montant, int duree, double taux, int apport, string date)
        {
            monMontant = montant;
            monDuree = duree;
            monTaux = taux;
            monApport = apport;
            dateDébut = date;
        }

        public ClCredit(double montant, int duree, double taux, double mensualite)
        {
            monMontant = montant;
            monDuree = duree;
            monTaux = taux;
            monMensualite = mensualite;
        }

        public double getMontantCredit()
        {
            return monMontant;
        }

        public double getMonApport()
        {
            return monApport;
        }
        public int getDureeCredit()
        {
            return monDuree;
        }

        public double getTauxCredit()
        {
            return monTaux;
        }

        public string getDate()
        {
            return dateDébut;
        }

        public double getMensualiteCredit()
        {
            // Formule : m = V0 * i / (1 - (1 + i) ^ -n)
            // m : mensualité, V0 : montant financé initial, n : durée en mois, i : taux annuel

            double tauxMens = monTaux / 1200; // Taux mensuel

            monMensualite = Math.Round((monMontant * tauxMens) / (1 - Math.Pow(1 + tauxMens, -monDuree)), 2);

            return monMensualite;
        }
    }

}
