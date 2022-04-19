CREATE DATABASE GESTION_STOCK

CREATE TABLE CLIENT
(Id_Client int not null identity(1,1),
Nom_Client nvarchar(250) not null,
Prenom_Client nvarchar(250) not null,
Adresse_Client nvarchar(250) not null,
Telephone_Client nvarchar(250) not null,
Pays_Client nvarchar(250) not null,
Ville_Client nvarchar(250) not null,
CONSTRAINT PK_CLIENT PRIMARY KEY (Id_Client))

CREATE TABLE PRODUIT
(Id_Produit int not null identity(1,1),
Nom_Produit nvarchar(250)not null,
Quantite_Produit int not null,
Prix_Produit nvarchar(250) not null,
Image_Produit IMAGE not null,
Id_Categorie int not null,
CONSTRAINT PK_PRODUIT PRIMARY KEY (Id_Produit))

CREATE TABLE CATEGORIE
(Id_Categorie int not null identity(1,1),
Nom_Categorie nvarchar(250) not null,
CONSTRAINT PK_CATEGORIE PRIMARY KEY(Id_Categorie))

CREATE TABLE COMMANDE
(Id_Commande int not null identity(1,1),
Date_Commande DATETIME not null,
Id_Client int not null,
constraint PK_COMMANDE PRIMARY KEY(Id_Commande))

CREATE TABLE Details_Commande
(Id_Commande int not null,
Id_Produit int not null,
Quantite int not null)

CREATE TABLE UTILISATEUR
(
Nom_Utilisateur nvarchar(250) not null,
Mot_de_passe nvarchar(250) not null,
CONSTRAINT PK_UTILISATEUR PRIMARY KEY(Nom_Utilisateur))

Alter TABLE CLIENT ADD Email_Client nvarchar(250) not null