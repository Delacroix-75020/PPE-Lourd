-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : mer. 28 avr. 2021 à 10:40
-- Version du serveur :  10.4.18-MariaDB
-- Version de PHP : 7.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

DROP DATABASE IF EXISTS ppe;
CREATE DATABASE ppe;
USE ppe;


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `ppe`
--

-- --------------------------------------------------------

--
-- Structure de la table `admin`
--

CREATE TABLE `admin` (
  `id` int(11) NOT NULL,
  `username` varchar(128) NOT NULL,
  `email` varchar(128) NOT NULL,
  `pass` varchar(128) NOT NULL,
  `Role` int(11) NOT NULL COMMENT '1 = Admin / 0 = Employée',
  `locked` tinyint(1) DEFAULT 0 COMMENT '1 = compte verrouillé'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `admin`
--

INSERT INTO `admin` (`id`, `username`, `email`, `pass`, `Role`, `locked`) VALUES
(1, 'Delacroix', 'ad.dela75020@gmail.com', '4f9996ad3b634ef65d772b702509236456662a35', 0, 0),
(4, 'Adrien', 'admin@gmail.com', '7af2d10b73ab7cd8f603937f7697cb5fe432c7ff', 1, 0),
(5, 'employe', 'employe@gmail.com', '107d348bff437c999a9ff192adcb78cb03b8ddc6', 0, 0),
(11, 'LeTest', 'LeTesteur@gmail.com', '41837ae81e18ab2c22bff7faf52042b9505c345d', 0, 0);

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--

CREATE TABLE `categorie` (
  `id_categorie` int(11) NOT NULL,
  `nom_categorie` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `categorie`
--

INSERT INTO `categorie` (`id_categorie`, `nom_categorie`) VALUES
(1, 'Voiture'),
(2, 'Accessoires'),
(3, 'Bus'),
(4, 'Camion');

-- --------------------------------------------------------

--
-- Structure de la table `commande`
--

CREATE TABLE `commande` (
  `ref_com` int(11) NOT NULL,
  `date_commande` date NOT NULL,
  `id_u` int(11) NOT NULL,
  `total` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `commande`
--

INSERT INTO `commande` (`ref_com`, `date_commande`, `id_u`, `total`) VALUES
(22, '2021-04-14', 20, 1614.95),
(24, '2021-04-14', 18, 377.99);

-- --------------------------------------------------------

--
-- Structure de la table `image`
--

CREATE TABLE `image` (
  `id_image` int(11) NOT NULL,
  `nom_image` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `image`
--

INSERT INTO `image` (`id_image`, `nom_image`) VALUES
(1, 'moteurAudi.jpg'),
(2, 'retro.jpg'),
(3, 'VolantVoiture.jpg'),
(4, 'downpipe.jpg'),
(5, 'jante.jpg'),
(6, 'pessi.jpg');

-- --------------------------------------------------------

--
-- Structure de la table `journal`
--

CREATE TABLE `journal` (
  `id` int(11) NOT NULL,
  `dateconnect` datetime DEFAULT NULL,
  `etat` tinyint(1) NOT NULL,
  `PersonID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `journal`
--

INSERT INTO `journal` (`id`, `dateconnect`, `etat`, `PersonID`) VALUES
(35, '2021-04-24 20:59:46', 1, 4),
(36, '2021-04-24 21:03:53', 1, 1),
(37, '2021-04-25 12:21:18', 1, 4),
(38, '2021-04-25 12:21:53', 0, 4),
(39, '2021-04-25 12:22:09', 0, 4),
(40, '2021-04-25 12:22:15', 1, 4),
(41, '2021-04-26 11:11:04', 1, 5),
(42, '2021-04-26 11:12:16', 0, 1),
(43, '2021-04-26 11:12:29', 0, 1),
(44, '2021-04-26 11:12:36', 1, 1),
(45, '2021-04-27 19:42:54', 1, 1),
(46, '2021-04-27 19:43:19', 1, 1),
(47, '2021-04-27 20:16:35', 1, 4),
(48, '2021-04-27 20:17:59', 1, 1),
(49, '2021-04-27 20:18:17', 0, 1),
(50, '2021-04-27 20:18:20', 0, 1),
(51, '2021-04-27 20:19:44', 0, 1),
(52, '2021-04-27 20:25:07', 0, 1),
(53, '2021-04-27 20:25:20', 0, 1),
(54, '2021-04-27 20:25:37', 0, 1),
(55, '2021-04-27 20:25:42', 0, 1),
(56, '2021-04-27 20:25:48', 0, 1),
(57, '2021-04-27 20:27:12', 0, 1),
(58, '2021-04-27 20:27:21', 0, 1),
(59, '2021-04-27 20:27:22', 0, 1),
(60, '2021-04-27 20:27:23', 0, 1),
(61, '2021-04-27 20:27:24', 0, 1),
(62, '2021-04-27 20:29:15', 0, 1),
(63, '2021-04-27 20:29:16', 0, 1),
(64, '2021-04-27 20:29:17', 0, 1),
(65, '2021-04-27 20:29:18', 0, 1),
(66, '2021-04-27 20:29:18', 0, 1),
(67, '2021-04-27 20:34:43', 1, 4),
(68, '2021-04-27 20:43:10', 0, 4),
(69, '2021-04-27 20:43:19', 1, 4),
(70, '2021-04-27 20:44:56', 1, 4),
(71, '2021-04-27 20:48:09', 1, 4),
(72, '2021-04-27 20:54:34', 1, 4),
(73, '2021-04-27 20:55:42', 1, 4),
(74, '2021-04-27 20:56:13', 1, 5),
(75, '2021-04-27 20:59:03', 0, 4),
(76, '2021-04-27 20:59:04', 0, 4),
(77, '2021-04-27 20:59:04', 0, 4),
(78, '2021-04-27 20:59:05', 0, 4),
(79, '2021-04-27 20:59:05', 0, 4),
(80, '2021-04-27 20:59:06', 0, 4),
(81, '2021-04-27 20:59:06', 0, 4),
(82, '2021-04-27 20:59:12', 1, 4);

-- --------------------------------------------------------

--
-- Structure de la table `panier`
--

CREATE TABLE `panier` (
  `id_produit` int(11) NOT NULL,
  `ref_com` int(11) NOT NULL,
  `qte` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `panier`
--

INSERT INTO `panier` (`id_produit`, `ref_com`, `qte`) VALUES
(1, 22, 1),
(2, 24, 2),
(6, 22, 1),
(6, 24, 1),
(7, 22, 4);

-- --------------------------------------------------------

--
-- Structure de la table `produit`
--

CREATE TABLE `produit` (
  `id_produit` int(11) NOT NULL,
  `nom_produit` varchar(128) NOT NULL,
  `p_motscles` varchar(280) NOT NULL,
  `description` varchar(255) NOT NULL,
  `qteProduit` int(6) NOT NULL,
  `prix` float NOT NULL,
  `id_categorie` int(11) NOT NULL,
  `id_image` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `produit`
--

INSERT INTO `produit` (`id_produit`, `nom_produit`, `p_motscles`, `description`, `qteProduit`, `prix`, `id_categorie`, `id_image`) VALUES
(1, 'Moteur de Voiture Audi A3', 'Moteur;Voiture;Audi;A3;', 'Ceci est un moteur blablabla ', 1, 799, 1, 1),
(2, 'Rétroviseur Renault ', '', 'Rétroviseur de la marque Renault avec une tes grande flexibilité ', 100, 39, 2, 2),
(4, 'Volant GT sport +', 'volant, voiture, sport', 'Un volant en carbone de wish qui pèse environ 361 kg ce qui va te donner l\'impression de conduire un camtar', 200, 29, 1, 3),
(6, 'downpipe Scania V8', 'scania, camion, downpipe, V8', 'Downpipe pour Scania V8 5ème génération, idéal pour une reprogrammation moteur', 0, 299.99, 4, 4),
(7, 'jante pour bus ', 'jante, bus,', 'jante en aluminium', 5, 45.5, 3, 5);

-- --------------------------------------------------------

--
-- Structure de la table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(70) NOT NULL,
  `tel` varchar(20) NOT NULL,
  `adresse` varchar(128) DEFAULT NULL,
  `email` varchar(70) NOT NULL,
  `pass` varchar(70) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `users`
--

INSERT INTO `users` (`id`, `username`, `tel`, `adresse`, `email`, `pass`) VALUES
(18, 'LeCLient', '0674661495', '8 Rue Ernest Lefevre', 'user@gmail.com', '107d348bff437c999a9ff192adcb78cb03b8ddc6'),
(20, 'Steve', '0688367843', '8 Rue Ernest Lefevre', 'stevizou@g.com', '9ce5770b3bb4b2a1d59be2d97e34379cd192299f');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `categorie`
--
ALTER TABLE `categorie`
  ADD PRIMARY KEY (`id_categorie`);

--
-- Index pour la table `commande`
--
ALTER TABLE `commande`
  ADD PRIMARY KEY (`ref_com`),
  ADD KEY `id_u` (`id_u`);

--
-- Index pour la table `image`
--
ALTER TABLE `image`
  ADD PRIMARY KEY (`id_image`);

--
-- Index pour la table `journal`
--
ALTER TABLE `journal`
  ADD PRIMARY KEY (`id`),
  ADD KEY `PersonID` (`PersonID`);

--
-- Index pour la table `panier`
--
ALTER TABLE `panier`
  ADD PRIMARY KEY (`id_produit`,`ref_com`),
  ADD KEY `ref_com` (`ref_com`);

--
-- Index pour la table `produit`
--
ALTER TABLE `produit`
  ADD PRIMARY KEY (`id_produit`),
  ADD KEY `id_categorie` (`id_categorie`),
  ADD KEY `id_image` (`id_image`);

--
-- Index pour la table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `email` (`email`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `admin`
--
ALTER TABLE `admin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT pour la table `categorie`
--
ALTER TABLE `categorie`
  MODIFY `id_categorie` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT pour la table `commande`
--
ALTER TABLE `commande`
  MODIFY `ref_com` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT pour la table `image`
--
ALTER TABLE `image`
  MODIFY `id_image` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT pour la table `journal`
--
ALTER TABLE `journal`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=83;

--
-- AUTO_INCREMENT pour la table `produit`
--
ALTER TABLE `produit`
  MODIFY `id_produit` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT pour la table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `commande`
--
ALTER TABLE `commande`
  ADD CONSTRAINT `commande_ibfk_1` FOREIGN KEY (`id_u`) REFERENCES `users` (`id`) ON DELETE CASCADE;

--
-- Contraintes pour la table `journal`
--
ALTER TABLE `journal`
  ADD CONSTRAINT `journal_ibfk_1` FOREIGN KEY (`PersonID`) REFERENCES `admin` (`id`);

--
-- Contraintes pour la table `panier`
--
ALTER TABLE `panier`
  ADD CONSTRAINT `panier_ibfk_1` FOREIGN KEY (`id_produit`) REFERENCES `produit` (`id_produit`),
  ADD CONSTRAINT `panier_ibfk_2` FOREIGN KEY (`ref_com`) REFERENCES `commande` (`ref_com`) ON DELETE CASCADE;

--
-- Contraintes pour la table `produit`
--
ALTER TABLE `produit`
  ADD CONSTRAINT `produit_ibfk_1` FOREIGN KEY (`id_categorie`) REFERENCES `categorie` (`id_categorie`),
  ADD CONSTRAINT `produit_ibfk_2` FOREIGN KEY (`id_image`) REFERENCES `image` (`id_image`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
