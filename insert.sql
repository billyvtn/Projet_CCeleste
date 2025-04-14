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

-- Insertion dans PIECE
INSERT INTO PIECE (NomPiece, Marque) VALUES
('Pneu Michelin', 'Michelin'),
('Filtre à huile', 'Bosch'),
('Batterie Varta', 'Varta');
GO

