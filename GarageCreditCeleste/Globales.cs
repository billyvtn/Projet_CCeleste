using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageCreditCeleste
{
    static class Globales
    {
        public static Demarrage demarrage;
        public static Accueil accueil;
        public static Vendre vendre;
        public static Services services;
        public static Acheter acheter;
        public static Filtre filtre;
        public static Reparation reparation;
        public static Entretien entretien;
        public static ControleTechnique controletechnique;
    }

    class Client
    {
        private bool civilite; //true = homme, false = femme
        private string nom;
        private string prenom;
        private string email;
        private string numero;
        private string numAdresse;
        private string voieAdresse;
        private string ville;
        private string codePostal;

        public Client(bool civ, string no, string preno, string emai, string numer, string num, string voie, string vil, string codePos)
        {
            civilite = civ;
            nom = no;
            prenom = preno;
            email = emai;
            numero = numer;
            numAdresse = num;
            voieAdresse = voie;
            ville = vil;
            codePostal = codePos;
        }
    }
}
