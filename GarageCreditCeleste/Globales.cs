using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageCreditCeleste
{
    static class Globales
    {
        //Déclaration des objets fenêtre
        public static Demarrage demarrage;
        public static Accueil accueil;
        public static Vendre vendre;
        public static Services services;
        public static Acheter acheter;
        public static Filtre filtre;
        public static Reparation reparation;
        public static Entretien entretien;
        public static ControleTechnique controletechnique;
        public static Assurance frmAssurance;
        public static Credit frmCredit;
        
        //Déclaration des objets pour la gestion de la bdd
        public static Client client;
        public static Voiture voiture;
        public static Voiture voitureRachat;
        public static ClAssurance assurance;
        public static ClCredit credit;

        public static List<String> Type = new List<string>();

        public static ClControleTechnique controleTechnique;
        public static ClEntretien Entretien;

        public static Dictionary<string, string> Filtres = new Dictionary<string, string>();

    }
}
