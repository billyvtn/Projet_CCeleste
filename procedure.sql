USE [PROJETCC_K]
GO

IF OBJECT_ID('InsVoiture', 'P') IS NOT NULL
    DROP PROCEDURE InsVoiture;
GO

CREATE PROCEDURE InsVoiture
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
