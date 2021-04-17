-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : ven. 09 avr. 2021 à 23:44
-- Version du serveur :  10.4.18-MariaDB
-- Version de PHP : 7.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `lourdppe`
--

-- --------------------------------------------------------

--
-- Structure de la table `participant`

DROP DATABASE IF EXISTS lourdppe;
CREATE DATABASE lourdppe;
use lourdppe;
--

CREATE TABLE `participant` (
  `id` int(11) NOT NULL,
  `nom` varchar(128) NOT NULL,
  `prenom` varchar(128) NOT NULL,
  `departement` varchar(11) NOT NULL COMMENT 'Varchar car 2A et 2B chez les Corses',
  `email` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `participant`
--

INSERT INTO `participant` (`id`, `nom`, `prenom`, `departement`, `email`) VALUES
(1, 'Chaillou', 'Steve', '92', 'stevizou@g.com'),
(2, 'Vignon', 'Nicolas', '56', 'Nicolas@gmail.com'),
(7, 'Delacroix', 'Adrien', '78', 'adrien.doll@moniris.com'),
(8, 'Bruaire', 'Tom', '92', 'tom.bruaire@moniris.com');

-- --------------------------------------------------------

--
-- Structure de la table `participer`
--

CREATE TABLE `participer` (
  `id_participant` int(11) NOT NULL,
  `id_salon` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `participer`
--

INSERT INTO `participer` (`id_participant`, `id_salon`) VALUES
(1, 5);

-- --------------------------------------------------------

--
-- Structure de la table `salon`
--

CREATE TABLE `salon` (
  `id` int(11) NOT NULL,
  `nom` varchar(128) NOT NULL,
  `date_debut` date NOT NULL,
  `date_fin` date NOT NULL,
  `lieu` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `salon`
--

INSERT INTO `salon` (`id`, `nom`, `date_debut`, `date_fin`, `lieu`) VALUES
(4, 'Salon de l\'adoption', '2021-04-10', '2021-04-11', 'Centre culturelle du centre ville'),
(5, 'Salon de l\'agriculture', '2021-05-17', '2021-05-23', 'Versailles'),
(7, 'Exposition de la Barbacane', '2021-06-08', '2021-06-15', 'Mairie de Villiers '),
(8, 'Salon de l\'armement ', '2021-04-18', '2021-04-25', 'Place de Villiers-sur-Marne');

-- --------------------------------------------------------

--
-- Structure de la table `users`
--

CREATE TABLE `users` (
  `username` varchar(128) NOT NULL,
  `pass` varchar(128) NOT NULL,
  `Role` int(1) NOT NULL COMMENT '0 = Opérateur Salon / 1 = Administrateur '
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `users`
--

INSERT INTO `users` (`username`, `pass`, `Role`) VALUES
('admin', 'd033e22ae348aeb5660fc2140aec35850c4da997', 1),
('operateur', 'e8d08ecdc7c0b5cdcbfbe2c2bf7a328e5c10d476', 0);

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `participant`
--
ALTER TABLE `participant`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `email` (`email`);

--
-- Index pour la table `participer`
--
ALTER TABLE `participer`
  ADD PRIMARY KEY (`id_participant`,`id_salon`),
  ADD KEY `id_salon` (`id_salon`);

--
-- Index pour la table `salon`
--
ALTER TABLE `salon`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`username`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `participant`
--
ALTER TABLE `participant`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT pour la table `salon`
--
ALTER TABLE `salon`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `participer`
--
ALTER TABLE `participer`
  ADD CONSTRAINT `participer_ibfk_1` FOREIGN KEY (`id_participant`) REFERENCES `participant` (`id`),
  ADD CONSTRAINT `participer_ibfk_2` FOREIGN KEY (`id_salon`) REFERENCES `salon` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
