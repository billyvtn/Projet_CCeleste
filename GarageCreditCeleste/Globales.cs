﻿using System;
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

        public static Client client;
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

        public bool getCivilite()
        {
            return civilite;
        }
        public string getNom()
        {
            return nom;
        }
        public string getPrenom()
        {
            return prenom;
        }
        public string getEmail()
        {
            return email;
        }
        public string getNumero()
        {
            return numero;
        }
        public string getAdresseNum()
        {
            return numAdresse;
        }
        public string getAdresseVoie()
        {
            return voieAdresse;
        }
        public string getVille()
        {
            return ville;
        }
        public string getCodePostal()
        {
            return codePostal;
        }
    }
}
