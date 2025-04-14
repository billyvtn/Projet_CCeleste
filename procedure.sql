USE [PROJETCC_K]
GO

-- Supprimer les procédures existantes si elles existent
IF OBJECT_ID('dbo.InsClient', 'P') IS NOT NULL
    DROP PROCEDURE dbo.InsClient;
GO

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

IF OBJECT_ID('dbo.ConfirmerAchatVoiture', 'P') IS NOT NULL
    DROP PROCEDURE dbo.ConfirmerAchatVoiture;
GO

-- Création de la procédure InsClient
CREATE PROCEDURE dbo.InsClient
    @Civ BIT,
    @Nom VARCHAR(50),
    @Prenom VARCHAR(50),
    @Email VARCHAR(100),
    @NumeroTel VARCHAR(15),
    @AdresseNum INT,
    @AdresseVoie VARCHAR(50),
    @AdresseVille VARCHAR(50),
    @AdresseCP INT
AS
BEGIN
    -- Vérifie que l'email n'existe pas déjà
    IF EXISTS (SELECT 1 FROM UTILISATEUR WHERE Email = @Email)
    BEGIN
        RAISERROR('Un utilisateur avec cet email existe déjà.', 16, 1);
        RETURN;
    END

    -- Insère le nouvel utilisateur
    INSERT INTO UTILISATEUR (Civ, Nom, Prenom, Email, NumeroTel, AdresseNum, AdresseVoie, AdresseVille, AdresseCP)
    VALUES (@Civ, @Nom, @Prenom, @Email, @NumeroTel, @AdresseNum, @AdresseVoie, @AdresseVille, @AdresseCP);

END;
GO

-- Création de la procédure InsVoitureEtVente
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
    @DateVente VARCHAR(50),
	@ModePaiement VARCHAR(50)
AS
BEGIN
    DECLARE @idVehicule INT;
    DECLARE @idUtilisateur INT;

    -- Démarrer une transaction pour assurer la cohérence des données
    BEGIN TRANSACTION;

    BEGIN TRY

        -- Récupérer l'id de l'utilisateur à  partir de son email
        SELECT @idUtilisateur = idUtilisateur FROM UTILISATEUR WHERE Email = @EmailUtilisateur;

        IF @idUtilisateur IS NULL
        BEGIN
            RAISERROR('Utilisateur non trouvé avec cet email.', 16, 1);
        END

        -- Insérer la voiture et récupérer l'ID généré
        INSERT INTO VEHICULE (Marque, Modele, Annee, Valeur, Kilometrage, Couleur, Puissance, StatutDisp, Immat, idUtilisateur)
        VALUES (@Marque, @Modele, @Annee, @Valeur, @Kilometrage, @Couleur, @Puissance, @StatutDisp, @Immat, @idUtilisateur);

        -- Récupérer l'ID de la voiture insérée
        SELECT @idVehicule = idVehicule FROM VEHICULE WHERE Immat = @Immat;

        -- Insérer la transaction de vente
        INSERT INTO VENTE (PrixVente, DateVente, ModePaiement ,idUtilisateur, idVehicule)
        VALUES (@PrixVente, @DateVente, @ModePaiement ,@idUtilisateur, @idVehicule);

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

-- Création de la procédure ConfirmerAchatVoiture
CREATE PROCEDURE dbo.ConfirmerAchatVoiture
    @Email VARCHAR(100),
    @Immat VARCHAR(50),
    @DateAchat VARCHAR(50),
    @ModePaiement VARCHAR(50),
    
    -- Champs du crédit (optionnels)
    @AvecCredit BIT,
    @MontantTotal INT = NULL,
    @Mensualite INT = NULL,
    @Duree INT = NULL,
    @Taux INT = NULL,

    -- Champs de l'assurance (optionnels)
    @AvecAssurance BIT,
    @TypeAssurance VARCHAR(50) = NULL,
    @MensualiteAssurance DECIMAL(15,2) = NULL,
    @DateDebutAssurance VARCHAR(50) = NULL
AS
BEGIN
    DECLARE @idUtilisateur INT;
    DECLARE @idVehicule INT;
    DECLARE @idCredit INT = NULL;
    DECLARE @idAssurance INT = NULL;

    BEGIN TRANSACTION;

    BEGIN TRY
        -- Récupérer id utilisateur
        SELECT @idUtilisateur = idUtilisateur FROM UTILISATEUR WHERE Email = @Email;
        IF @idUtilisateur IS NULL
            THROW 50001, 'Utilisateur introuvable.', 1;

        -- Mettre à jour statut véhicule
        EXEC dbo.UpdateStatutVoiture @Immat = @Immat, @Email = @Email;

        -- Récupérer idVehicule
        SELECT @idVehicule = idVehicule FROM VEHICULE WHERE Immat = @Immat;
        IF @idVehicule IS NULL
            THROW 50002, 'Véhicule introuvable.', 1;

        -- Si crédit, insérer et récupérer id
        IF @AvecCredit = 1
        BEGIN
            EXEC dbo.InsCredit @MontantTotal, @Mensualite, @Duree, @Taux;

            SELECT TOP 1 @idCredit = idCredit FROM CREDIT ORDER BY idCredit DESC;
        END

        -- Si assurance, insérer et récupérer id
        IF @AvecAssurance = 1
        BEGIN
            EXEC dbo.InsAssurance @TypeAssurance, @MensualiteAssurance, @DateDebutAssurance;

            SELECT TOP 1 @idAssurance = idAssurance FROM ASSURANCE ORDER BY idAssurance DESC;
        END

        -- Insérer l'achat
        INSERT INTO ACHAT (DateAchat, ModePaiement, idVehicule, idCredit, idAssurance, idUtilisateur)
        VALUES (@DateAchat, @ModePaiement, @idVehicule, @idCredit, @idAssurance, @idUtilisateur);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        DECLARE @ErrMsg NVARCHAR(4000) = ERROR_MESSAGE();
        THROW 50010, @ErrMsg, 1;
    END CATCH
END;
GO
