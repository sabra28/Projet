# Projet 

Prestation de services est un logiciel de facturation pour un autoentrepreneur

## Description

Logiciel permettant d'ajouter, modifier, supprimer des clients et des prestations puis de créer des factures selon les prestations choisies.
Avant de commencer, vous pouvez visualiser mon mcd : "mcdpresta.png" et mon use case "usecase.png"


### PRÉREQUIS ET INSTALLATION :

- Visual studio 2019
- Wamp
- Winrar (pour décomposer le fichier, facultatif)
- Cliquer sur CODE >> download ZIP
- Décomposer le dossier 
- Importer le .sql dans PHPMYADMIN (LANCER WAMP AVANT)  
- Vérifier que l'id:root et mdp:  (dans PHPMYADMIN) si cela n'est pas le cas
 → Aller dans le fichier Projet/Projet/MyDATABASE.cs ligne 20 (changer en fonction de votre identifiant)
Ainsi que pour valider les tests unitaires, il faut avoir le bon id et mdp, veuillez modifier si ce ne sont pas les mêmes : \Projet\Projet.Tests\unitTest1.cs ligne14


### Utilisation

- Lancer wamp si ce n'est pas déjà effectuer
- Ouvrir le fichier Projet.sln 
- Cliquer sur le Projet en haut

Ps : Merci de ne pas supprimer le client 1 (ARNAUD) de la commande 11, car un test a été effectuer pour vérifier ses prestations.

Pour visualiser les factures : \Projet\Projet\bin\Debug\net5.0-windows  >> facture-le nom du client.pdf

