USE [PROJETCC_K];
GO

EXEC sp_MSforeachtable "ALTER TABLE ? NOCHECK CONSTRAINT all";
GO

DROP TABLE IF EXISTS ASSURANCE;
DROP TABLE IF EXISTS ACHAT;
DROP TABLE IF EXISTS VENTE;
DROP TABLE IF EXISTS CONTROLE_TECHNIQUE;
DROP TABLE IF EXISTS PIECE;
DROP TABLE IF EXISTS REPARATION;
DROP TABLE IF EXISTS ENTRETIEN;
DROP TABLE IF EXISTS VEHICULE;
DROP TABLE IF EXISTS CREDIT;
DROP TABLE IF EXISTS UTILISATEUR;
GO

EXEC sp_MSforeachtable "ALTER TABLE ? CHECK CONSTRAINT all";
GO

CREATE TABLE UTILISATEUR(
   idUtilisateur INT IDENTITY(1,1) PRIMARY KEY,
   Civ BIT NOT NULL,
   Nom VARCHAR(50) NOT NULL,
   Prenom VARCHAR(50) NOT NULL,
   Email VARCHAR(100) NOT NULL,
   NumeroTel INT NOT NULL,
   AdresseNum INT NOT NULL,
   AdresseVoie VARCHAR(50) NOT NULL,
   AdresseVille VARCHAR(50),
   AdresseCP INT NOT NULL,
);
GO

CREATE TABLE VEHICULE(
   idVehicule INT IDENTITY(1,1) PRIMARY KEY,
   Marque VARCHAR(50) NOT NULL,
   Modele VARCHAR(50) NOT NULL,
   Annee INT NOT NULL,
   Valeur DECIMAL(15,2),
   Kilometrage INT NOT NULL,
   Couleur VARCHAR(50) NOT NULL,
   Puissance INT,
   StatutDisp BIT NOT NULL,
   Immat VARCHAR(50) NOT NULL UNIQUE,
   idUtilisateur INT,
   CONSTRAINT FK_UTILISATEUR_VEHICULE FOREIGN KEY (idUtilisateur) REFERENCES UTILISATEUR(idUtilisateur)
);
GO

CREATE TABLE ENTRETIEN(
   idEntretien INT IDENTITY(1,1) PRIMARY KEY,
   DateEntretien DATETIME NOT NULL,
   Cout INT,
   idVehicule INT NOT NULL,
   CONSTRAINT FK_VEHICULE_ENTRETIEN FOREIGN KEY (idVehicule) REFERENCES VEHICULE(idVehicule)
);
GO

CREATE TABLE REPARATION(
   idReparation INT IDENTITY(1,1) PRIMARY KEY,
   DateReparation DATETIME,
   Designation VARCHAR(50) NOT NULL,
   Prix INT,
   idVehicule INT NOT NULL,
   CONSTRAINT FK_VEHICULE_REPARATION FOREIGN KEY (idVehicule) REFERENCES VEHICULE(idVehicule)
);
GO

CREATE TABLE PIECE(
   idPiece INT IDENTITY(1,1) PRIMARY KEY,
   NomPiece VARCHAR(50) NOT NULL,
   Marque VARCHAR(50),
   idReparation INT NOT NULL UNIQUE,
   CONSTRAINT FK_REPARATION_PIECE FOREIGN KEY (idReparation) REFERENCES REPARATION(idReparation)
);
GO

CREATE TABLE CREDIT(
   idCredit INT IDENTITY(1,1) PRIMARY KEY,
   Mensualite INT,
   Apport INT,
   Taux INT,
   MontantTotal INT
);
GO

CREATE TABLE CONTROLE_TECHNIQUE(
   idControleTechnique INT IDENTITY(1,1) PRIMARY KEY,
   DateCT DATETIME,
   Cout INT,
   idVehicule INT NOT NULL,
   CONSTRAINT FK_VEHICULE_CONTROLE_TECHNIQUE FOREIGN KEY (idVehicule) REFERENCES VEHICULE(idVehicule)
);
GO

CREATE TABLE VENTE(
   idVente INT IDENTITY(1,1) PRIMARY KEY,
   PrixVente VARCHAR(50),
   idUtilisateur INT NOT NULL,
   idVehicule INT NOT NULL UNIQUE,
   CONSTRAINT FK_UTILISATEUR_VENTE FOREIGN KEY (idUtilisateur) REFERENCES UTILISATEUR(idUtilisateur),
   CONSTRAINT FK_VEHICULE_VENTE FOREIGN KEY (idVehicule) REFERENCES VEHICULE(idVehicule)
);
GO

CREATE TABLE ACHAT(
   idAchat INT IDENTITY(1,1) PRIMARY KEY,
   DateAchat DATE NOT NULL,
   ModePaiement VARCHAR(50),
   idVehicule INT NOT NULL UNIQUE,
   idCredit INT UNIQUE,
   idUtilisateur INT NOT NULL,
   CONSTRAINT FK_UTILISATEUR_ACHAT FOREIGN KEY (idUtilisateur) REFERENCES UTILISATEUR(idUtilisateur),
   CONSTRAINT FK_VEHICULE_ACHAT FOREIGN KEY (idVehicule) REFERENCES VEHICULE(idVehicule),
   CONSTRAINT FK_CREDIT_ACHAT FOREIGN KEY (idCredit) REFERENCES CREDIT(idCredit)
);
GO

CREATE TABLE ASSURANCE(
   idAssurance INT IDENTITY(1,1) PRIMARY KEY,
   TypeAssurance VARCHAR(50) NOT NULL,
   Mensualite INT,
   DateDebut DATE,
   idAchat INT UNIQUE,
   CONSTRAINT FK_ACHAT_ASSURANCE FOREIGN KEY (idAchat) REFERENCES ACHAT(idAchat)
);
GO