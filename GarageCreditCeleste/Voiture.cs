using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageCreditCeleste
{
    public class Voiture
    {
        private string marque;
        private string modele;
        private int annee;
        private int kilometrage;
        private string couleur;
        private int puissance;
        private string immatriculation;
        private bool statutDispo;
        private double prix;

        public Voiture(string marqu, string model, int anne, int kilometrag, string couleu, int puissanc, string immat, bool statutD)
        {
            marque = marqu;
            modele = model;
            annee = anne;
            kilometrage = kilometrag;
            couleur = couleu;
            puissance = puissanc;
            immatriculation = immat;
            statutDispo = statutD;
        }

        public Voiture(string marqu, string model, int anne, int kilometrag, string couleu, int puissanc, string immat, bool statutD, double prixA)
        {
            marque = marqu;
            modele = model;
            annee = anne;
            kilometrage = kilometrag;
            couleur = couleu;
            puissance = puissanc;
            immatriculation = immat;
            prix = prixA;
            statutDispo = statutD;
        }
        public Voiture(string marqu, string model, int anne, int kilometrag, string couleu, int puissanc, string immat, double prixR)
        {
            marque = marqu;
            modele = model;
            annee = anne;
            kilometrage = kilometrag;
            couleur = couleu;
            puissance = puissanc;
            immatriculation = immat;
            prix = prixR;
            statutDispo = false;
        }

        public string getMarque()
        {
            return marque;
        }
        public string getModele()
        {
            return modele;
        }
        public int getAnnee()
        {
            return annee;
        }
        public int getKilometrage()
        {
            return kilometrage;
        }
        public string getCouleur()
        {
            return couleur;
        }
        public int getPuissance()
        {
            return puissance;
        }
        public string getImmatriculation()
        {
            return immatriculation;
        }
        public double getPrix()
        {
            return prix;
        }
        public bool getStatutDispo()
        {
            return statutDispo;
        }
    }
}
