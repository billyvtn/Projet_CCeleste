USE [PROJETCC_K]
GO

-- Supprimer les procédures existantes si elles existent
IF OBJECT_ID('dbo.InsVoitureEtVente', 'P') IS NOT NULL
    DROP PROCEDURE dbo.InsVoitureEtVente;
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

CREATE PROCEDURE dbo.InsVoitureEtVente
    @Marque VARCHAR(50),
    @Modele VARCHAR(50),
    @Annee INT,
    @Valeur DECIMAL(15,2),
    @Kilometrage INT,
    @Couleur VARCHAR(50),
    @Puissance INT,
    @StatutDisp BIT,
    @Immat VARCHAR(50),
    @EmailUtilisateur VARCHAR(100),  -- L'email est utilisé pour récupérer l'idUtilisateur
    @PrixVente DECIMAL(15,2),
    @DateVente DATE
AS
BEGIN
    DECLARE @idVehicule INT;
    DECLARE @idUtilisateur INT;

    -- Démarrer une transaction pour assurer la cohérence des données
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Récupérer l'id de l'utilisateur à partir de son email
        SELECT @idUtilisateur = idUtilisateur FROM UTILISATEUR WHERE Email = @EmailUtilisateur;

        IF @idUtilisateur IS NULL
        BEGIN
            RAISERROR('Utilisateur non trouvé avec cet email.', 16, 1);
        END

        -- Insérer la voiture et récupérer l'ID généré
        INSERT INTO VEHICULE (Marque, Modele, Annee, Valeur, Kilometrage, Couleur, Puissance, StatutDisp, Immat, idUtilisateur)
        VALUES (@Marque, @Modele, @Annee, @Valeur, @Kilometrage, @Couleur, @Puissance, @StatutDisp, @Immat, @idUtilisateur);

        -- Récupérer l'ID de la voiture insérée
        SET @idVehicule = SCOPE_IDENTITY();

        IF @idVehicule IS NULL
        BEGIN
            RAISERROR('L''insertion du véhicule a échoué.', 16, 1);
        END

        -- Insérer la transaction de vente
        INSERT INTO VENTE (PrixVente, DateVente, idUtilisateur, idVehicule)
        VALUES (@PrixVente, @DateVente, @idUtilisateur, @idVehicule);

        -- Valider la transaction
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Capture l'erreur SQL
        DECLARE @ErrorMessage NVARCHAR(4000);
        SET @ErrorMessage = ERROR_MESSAGE();

        -- Annuler la transaction en cas d'erreur
        ROLLBACK TRANSACTION;

        -- Retourner l'erreur
        RAISERROR(@ErrorMessage, 16, 1);
    END CATCH
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