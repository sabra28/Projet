-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : sam. 07 mai 2022 à 16:06
-- Version du serveur :  5.7.31
-- Version de PHP : 7.4.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `gestionprestation`
--

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

DROP TABLE IF EXISTS `client`;
CREATE TABLE IF NOT EXISTS `client` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(250) NOT NULL,
  `prenom` varchar(250) NOT NULL,
  `adresse` varchar(250) NOT NULL,
  `tel` int(10) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `client`
--

INSERT INTO `client` (`id`, `nom`, `prenom`, `adresse`, `tel`) VALUES
(1, 'Arnaud', 'Paulolo', '16 rue de dreux', 695814810),
(8, 'Billard', 'Manon', '59 rue Chateaudun', 785956230),
(4, 'moreira', 'Bruno', '25 rue de maurée', 634285992),
(5, 'Blanchard', 'Axel', '36 rue de Chartres 28000 chartres', 771047190),
(6, 'Molarer', 'Clement', '8 bis rue chartres', 695842851),
(7, 'Kasmi', 'Sabra', '16 rue varlet', 658171984);

-- --------------------------------------------------------

--
-- Structure de la table `commande`
--

DROP TABLE IF EXISTS `commande`;
CREATE TABLE IF NOT EXISTS `commande` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `date` date DEFAULT NULL,
  `idclient` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `idclient` (`idclient`)
) ENGINE=MyISAM AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `commande`
--

INSERT INTO `commande` (`id`, `date`, `idclient`) VALUES
(16, '2022-04-25', 8),
(10, '2022-03-25', 4),
(14, '2022-04-25', 3),
(13, '2022-04-25', 5),
(11, '2022-04-14', 1),
(9, '2022-03-13', 1),
(15, '2022-04-20', 3);

-- --------------------------------------------------------

--
-- Structure de la table `ligne`
--

DROP TABLE IF EXISTS `ligne`;
CREATE TABLE IF NOT EXISTS `ligne` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idprestation` int(11) DEFAULT NULL,
  `idcommande` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idprestation` (`idprestation`),
  KEY `idcommande` (`idcommande`)
) ENGINE=MyISAM AUTO_INCREMENT=24 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `ligne`
--

INSERT INTO `ligne` (`id`, `idprestation`, `idcommande`) VALUES
(1, 7, 10),
(2, 7, 10),
(3, 7, 10),
(4, 5, 10),
(5, 6, 10),
(6, 7, 9),
(7, 6, 9),
(8, 5, 11),
(9, 6, 12),
(10, 8, 12),
(11, 5, 13),
(12, 5, 13),
(13, 6, 13),
(14, 7, 13),
(15, 6, 12),
(16, 6, 12),
(17, 7, 12),
(18, 6, 12),
(19, 6, 14),
(20, 6, 14),
(21, 8, 14),
(22, 10, 16),
(23, 12, 16);

-- --------------------------------------------------------

--
-- Structure de la table `prestation`
--

DROP TABLE IF EXISTS `prestation`;
CREATE TABLE IF NOT EXISTS `prestation` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `prestation` varchar(250) NOT NULL,
  `description` varchar(250) NOT NULL,
  `prix` int(100) NOT NULL,
  `isActive` bit(1) NOT NULL DEFAULT b'1',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `prestation`
--

INSERT INTO `prestation` (`id`, `prestation`, `description`, `prix`, `isActive`) VALUES
(7, 'Ecran casse', 'inutilisable', 19, b'1'),
(5, 'chargeur', 'chargeur defectueux', 26, b'1'),
(6, 'clavier casse', 'a reparer', 22, b'1'),
(8, 'usb', 'a changer', 20, b'1'),
(9, 'Microsoft Windows 10', 'Installation', 99, b'0'),
(10, 'Montage pc', 'Assemblage pc', 75, b'1'),
(11, 'Montage pc complexe', 'Assemblage pc', 120, b'1'),
(12, 'Depoussierage', 'Nettoyage', 26, b'1'),
(13, 'Diagnotic disque dur', 'verification', 15, b'1');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
