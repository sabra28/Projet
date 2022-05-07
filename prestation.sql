-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : sam. 07 mai 2022 à 16:05
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
