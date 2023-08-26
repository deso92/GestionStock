--Création de la base de données
CREATE DATABASE GestionStock

--Création des Tables
CREATE TABLE Client(
Id_client int not null Identity(1,1),
Nom_client Varchar(250) not null,
Prenom_client varchar(250) not null,
Adresse_client Varchar(250) not null,
Telephone_client Varchar(250) not null,
Pays_client Varchar(250) not null,
Ville_client varchar(250) not null,
CONSTRAINT PK_client PRIMARY KEY(Id_client)
)
CREATE TABLE Produit(
Id_produit int not not null Identity(1,1),
Nom_produit varchar(250) not null,
Quantite_produit int not null,
Prix_produit Varchar(250) not null,
Image_produit Image not null,
Id_categororie int not null,
CONSTRAINT PK_produit PRIMARY KEY(Id_produit)
)

CREATE TABLE Categorie(
Id_categorie int not null Identity(1,1),
Nom_categorie Varchar(250) not null,
CONSTRAINT PK_categorie PRIMARY KEY (Id_categorie)
)

CREATE TABLE Commande(
Id_commande int not null Identity(1,1),
Date_commande datetime not null,
Id_client int not null,
CONSTRAINT PK_commande PRIMARY KEY(Id_commande)
)

CREATE TABLE DetailsCommande(
Id_details_commande int not null Identity(1,1),
Id_commande int not null,
Id_produit int not null,
Quantite_produit int not null
CONSTRAINT PK_detailsCommande PRIMARY KEY(Id_details_commande)
)

CREATE TABLE Utilisateurs(
Id_utilisateur int not null Identity(1,1),
email_utilisateur Varchar(250),
Nom_utilisateur Varchar(250),
GroupeUtilisateur Varchar(250)
Mot_de_passe Varchar(250),
CONSTRAINT PK_utilisateur PRIMARY KEY(email_utilisateur)
)