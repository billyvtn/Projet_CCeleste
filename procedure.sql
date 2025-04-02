USE [PROJETCC_K]
GO

-- Supprimer les procédures existantes si elles existent
IF OBJECT_ID('dbo.InsVoiture', 'P') IS NOT NULL
    DROP PROCEDURE dbo.InsVoiture;
GO

IF OBJECT_ID('dbo.InsCredit', 'P') IS NOT NULL
    DROP PROCEDURE dbo.InsCredit;
GO

IF OBJECT_ID('dbo.InsAssurance', 'P') IS NOT NULL
    DROP PROCEDURE dbo.InsAssurance;
GO

IF OBJECT_ID('dbo.UpdateStatutVoiture', 'P') IS NOT NULL
    DROP PROCEDURE dbo.UpdateStatutVoiture;
GO

-- Création de la procédure InsVoiture
CREATE PROCEDURE dbo.InsVoiture
    @Marque VARCHAR(50),
    @Modele VARCHAR(50),
    @Annee INT,
    @Valeur DECIMAL(15,2),
    @Kilometrage INT,
    @Couleur VARCHAR(50),
    @Puissance INT,
    @StatutDisp BIT,
    @Immat VARCHAR(50),
    @idUtilisateur INT = NULL
AS
BEGIN
    INSERT INTO VEHICULE (Marque, Modele, Annee, Valeur, Kilometrage, Couleur, Puissance, StatutDisp, Immat, idUtilisateur)
    VALUES (@Marque, @Modele, @Annee, @Valeur, @Kilometrage, @Couleur, @Puissance, @StatutDisp, @Immat, @idUtilisateur);
END;
GO

-- Création de la procédure InsCredit
CREATE PROCEDURE dbo.InsCredit
    @MontantTotal INT,
    @Mensualite INT,
    @Duree INT,
    @Taux INT
AS
BEGIN
    INSERT INTO CREDIT (MontantTotal, Mensualite, Duree, Taux)
    VALUES (@MontantTotal, @Mensualite, @Duree, @Taux);
END;
GO

-- Création de la procédure InsAssurance
CREATE PROCEDURE dbo.InsAssurance
    @TypeAssurance VARCHAR(50),
    @Mensualite DECIMAL(15,2),
    @DateDebut VARCHAR(50)
AS
BEGIN
    INSERT INTO ASSURANCE (TypeAssurance, Mensualite, DateDebut)
    VALUES (@TypeAssurance, @Mensualite, @DateDebut);
END;
GO

-- Création de la procédure
CREATE PROCEDURE dbo.UpdateStatutVoiture
    @Immat VARCHAR(50),     
    @Email VARCHAR(100)     
AS
BEGIN
    -- Mise à jour du statut de la voiture avec l'ID de l'utilisateur
    UPDATE VEHICULE
    SET StatutDisp = 0, 
        idUtilisateur = (SELECT idUtilisateur FROM UTILISATEUR WHERE Email = @Email)
    WHERE Immat = @Immat;
END;
GO