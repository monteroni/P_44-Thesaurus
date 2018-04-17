-- phpMyAdmin SQL Dump
-- version 4.1.4
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Mar 13 Février 2018 à 13:18
-- Version du serveur :  5.6.15-log
-- Version de PHP :  5.5.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

Drop DATABASE IF EXISTS db_thesaurus;
CREATE DATABASE db_thesaurus;
use db_thesaurus;

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `db_thesaurus`
--

-- --------------------------------------------------------

--
-- Structure de la table `t_occurence`
--

CREATE TABLE IF NOT EXISTS `t_occurence` (
  `ocuNumbre` int(11) DEFAULT NULL,
  `idFile` int(11) NOT NULL,
  `IdWord` int(11) NOT NULL,
  PRIMARY KEY (`idFile`,`IdWord`),
  KEY `FK_occurence_IdWord` (`IdWord`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `t_file`
--

CREATE TABLE IF NOT EXISTS `t_file` (
  `idFile` int(11) NOT NULL AUTO_INCREMENT,
  `filName` varchar(100) DEFAULT NULL,
  `filSize` double(22,2) DEFAULT NULL,
  `filExtend` varchar(30) DEFAULT NULL,
  `filURL` varchar(1000) DEFAULT NULL,
  PRIMARY KEY (`idFile`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Structure de la table `t_word`
--

CREATE TABLE IF NOT EXISTS `t_word` (
  `IdWord` int(11) NOT NULL AUTO_INCREMENT,
  `worWord` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`IdWord`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `occurence`
--
ALTER TABLE `t_occurence`
  ADD CONSTRAINT `FK_occurence_idFile` FOREIGN KEY (`idFile`) REFERENCES `t_file` (`idFile`),
  ADD CONSTRAINT `FK_occurence_IdWord` FOREIGN KEY (`IdWord`) REFERENCES `t_word` (`IdWord`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
