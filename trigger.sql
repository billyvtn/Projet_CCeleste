USE PROJETCC_K;
GO

IF OBJECT_ID('TRG_AUGMENTER_PRIX', 'TR') IS NOT NULL
    DROP TRIGGER TRG_AUGMENTER_PRIX;
GO

CREATE TRIGGER TRG_AUGMENTER_PRIX
ON VEHICULE
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO VEHICULE (Marque, Modele, Annee, Valeur, Kilometrage, Couleur, Puissance, StatutDisp, Immat, idUtilisateur)
    SELECT 
        Marque,
        Modele,
        Annee,
        Valeur * 1.2, 
        Kilometrage,
        Couleur,
        Puissance,
        StatutDisp,
        Immat,
        idUtilisateur
    FROM inserted;
END;
GO
