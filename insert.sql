USE [PROJETCC_K];
GO

-- Insertion dans UTILISATEUR
INSERT INTO UTILISATEUR (Civ, Nom, Prenom, Email, NumeroTel, AdresseNum, AdresseVoie, AdresseVille, AdresseCP) VALUES
(1, 'Dupont', 'Jean', 'jean.dupont@email.com', '0642665866', 12, 'Rue de la Paix', 'Paris', 75001),
(0, 'Martin', 'Sophie', 'sophie.martin@email.com', '0698312321', 34, 'Avenue des Champs', 'Lyon', 69000),
(1, 'Durand', 'Paul', 'paul.durand@email.com', '0623567581', 56, 'Boulevard Haussmann', 'Marseille', 13000);
GO

-- Insertion dans VEHICULE
INSERT INTO VEHICULE (Marque, Modele, Annee, Valeur, Kilometrage, Couleur, Puissance, StatutDisp, Immat, idUtilisateur) VALUES
('Renault', 'Clio', 2020, 15000.00, 20000, 'Rouge', 90, 1, 'ABC1234', 1),
('Peugeot', '208', 2019, 14000.00, 25000, 'Bleu', 95, 1, 'XYZ5678', NULL),
('Porsche', 'GT2RS', 2019, 14000.00, 25000, 'Noir', 95, 1, 'BP704MH', NULL),
('Toyota', 'Yaris', 2021, 18000.00, 15000, 'Blanc', 100, 1, 'LMN9101', 3);
GO

-- Insertion dans ENTRETIEN
INSERT INTO ENTRETIEN (DateEntretien, Cout, idVehicule) VALUES
('2024-01-10', 200, 1),
('2024-02-15', 250, 2),
('2024-03-20', 300, 3);
GO

-- Insertion dans REPARATION
INSERT INTO REPARATION (DateReparation, Designation, Prix, idVehicule) VALUES
('2024-01-05', 'Changement de pneus', 400, 1),
('2024-02-10', 'Réparation moteur', 600, 2),
('2024-03-15', 'Remplacement batterie', 150, 3);
GO

-- Insertion dans PIECE
INSERT INTO PIECE (NomPiece, Marque, idReparation) VALUES
('Pneu Michelin', 'Michelin', 1),
('Filtre à huile', 'Bosch', 2),
('Batterie Varta', 'Varta', 3);
GO

-- Insertion dans CREDIT
INSERT INTO CREDIT (MontantTotal, Mensualite, Duree, Taux) VALUES
(15000, 300, 100, 3),
(18000, 350, 180, 2.5),
(20000, 400, 60, 2);
GO

-- Insertion dans CONTROLE_TECHNIQUE
INSERT INTO CONTROLE_TECHNIQUE (DateCT, Cout, idVehicule) VALUES
('2024-01-20', 100, 1),
('2024-02-25', 120, 2),
('2024-03-30', 150, 3);
GO

-- Insertion dans VENTE
INSERT INTO VENTE (PrixVente, idUtilisateur, idVehicule) VALUES
('16000', 1, 1),
('15000', 2, 2),
('17000', 3, 3);
GO

-- Insertion dans ACHAT
INSERT INTO ACHAT (DateAchat, ModePaiement, idVehicule, idCredit, idUtilisateur) VALUES
('2024-01-15', 'Virement', 1, 1, 1),
('2024-02-20', 'Chèque', 2, 2, 2),
('2024-03-25', 'Carte bancaire', 3, 3, 3);
GO

-- Insertion dans ASSURANCE
INSERT INTO ASSURANCE (TypeAssurance, Mensualite, DateDebut, idAchat) VALUES
('Tous risques', 50, '2024-01-01', 1),
('Au tiers', 30, '2024-02-01', 2),
('Intermédiaire', 40, '2024-03-01', 3);
GO