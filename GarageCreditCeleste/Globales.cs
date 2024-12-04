﻿using System;
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
        private string civilite;
        private string nom;
        private string prenom;
        private string email;
        private string adresse;
    }
}
