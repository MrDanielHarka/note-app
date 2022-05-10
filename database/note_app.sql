-- phpMyAdmin SQL Dump
-- version 4.7.1
-- https://www.phpmyadmin.net/
--
-- Host: eu-cdbr-west-02.cleardb.net
-- Generation Time: May 08, 2022 at 06:04 PM
-- Server version: 5.6.50-log
-- PHP Version: 7.0.33-0ubuntu0.16.04.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `heroku_afb9b8b1a529dbe`
--

-- --------------------------------------------------------

--
-- Table structure for table `notes`
--

CREATE TABLE `notes` (
  `note_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `title` varchar(30) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `content` text COLLATE utf8mb4_hungarian_ci NOT NULL,
  `public` tinyint(1) NOT NULL,
  `shared` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- Dumping data for table `notes`
--

INSERT INTO `notes` (`note_id`, `user_id`, `title`, `content`, `public`, `shared`) VALUES
(15, 30, 'jegyzet2 jegyzet', 'jegyzet2 jegyzet2 jegyzet2 jegyzet2 jegyzet2 jegyzet2 jegyzet2 jegyzet2 jegyzet2 jegyzet2 jegyzet2 jegyzet2 ', 1, 0),
(36, 52, 'jegyzet', 'jegyzet', 0, 1),
(41, 2, '1111111111111', '11111111', 0, 0),
(51, 2, '222222222', '2222222222222', 0, 0),
(61, 2, '3333333', '3333333', 0, 0),
(71, 2, '444444', '444444', 0, 0),
(91, 71, 'ssssssssssss', 'sssssssss', 1, 0),
(101, 2, '555', '55555555', 1, 0),
(111, 2, '6666666', '6666666 6666666 6666666666 6666666666666 6666666 666666 66666', 1, 0),
(121, 91, '1111', '11111111', 0, 0),
(131, 91, '2222222', '222222', 1, 0),
(141, 2, '77777777', '777777', 0, 0),
(151, 2, '88888', '8888888888', 0, 0),
(171, 81, '11111', '1111111', 1, 0),
(181, 81, 'public note', 'public noted\nsf\nsd\nf\nsd\nf\nsd\nfsdfsdg\nds\nfsd', 1, 0),
(191, 2, '999999', '999999', 1, 0),
(201, 81, 'aaa', 'aaaa', 0, 0),
(211, 2, 'Trying xss attack', 'alert(\"This alert should not work.\");', 1, 0),
(221, 2, 'Trying html formatting', '<h1>Hello there.</h1>', 1, 0),
(231, 201, '1111111', '11111111111111', 0, 0),
(241, 201, '1111111', '1111111', 0, 0),
(251, 201, '1111111', '1111111', 0, 0),
(261, 201, '1111111', '1111111', 0, 0),
(271, 201, '1111111', '1111111', 0, 0),
(281, 201, '1111111', '1111111', 0, 0),
(291, 201, '1111111', '1111111', 0, 0),
(301, 201, '1111111', '1111111', 0, 0),
(311, 211, 'Brum matek', 'Egy brum, meg két brum, az három brum. Négy brum, meg öt brum, az kilenc brum.', 1, 0),
(321, 221, 'aaa', '<html><h1>hi</h1></html>', 0, 0),
(331, 2, 'new note', 'new note', 0, 0),
(341, 291, 'My title', 'My content', 0, 0),
(351, 201, '-----------', '-----------', 0, 0),
(361, 201, '-----------', '-----------', 0, 0),
(371, 201, '-----------', '-----------', 0, 0),
(381, 201, '-----------', '-----------', 0, 0),
(391, 201, '-----------', '-----------', 0, 0),
(401, 201, '-----------', '-----------', 0, 0),
(411, 201, '-----------', '-----------', 0, 0),
(421, 201, '-----------', '-----------', 0, 0),
(431, 201, '-----------', '-----------', 0, 0),
(441, 201, '-----------', '-----------', 0, 0),
(451, 201, '-----------', '-----------', 0, 0),
(461, 301, 'Bevásárlás lista', 'Chips\nKukorica\nMarha hús\nCoca cola\n', 0, 0),
(471, 321, 'Teszt', 'Csak sikerült a felület is, tetsztik! :-) A többit késöbb…', 0, 0),
(481, 331, 'Záró dolgozat', 'Szoftverfejlesztő és tesztelő', 1, 0),
(491, 331, 'Eredmény', 'Köszönöm a linket! A regisztráció, a belépés és a jegyzetkészítés működik, készüljenek a gyakorlati vizsgákra!\nCsak egy kérdés, nem kellene látszani, hogy kié az üzenet? Már a publikus részben…', 1, 0);

-- --------------------------------------------------------

--
-- Table structure for table `note_category`
--

CREATE TABLE `note_category` (
  `note_id` int(11) NOT NULL,
  `note_category` varchar(30) COLLATE utf8mb4_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

-- --------------------------------------------------------

--
-- Table structure for table `shares`
--

CREATE TABLE `shares` (
  `note_id` int(11) NOT NULL,
  `email` varchar(30) COLLATE utf8mb4_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- Dumping data for table `shares`
--

INSERT INTO `shares` (`note_id`, `email`) VALUES
(36, 'a');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `email` varchar(50) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `password` varchar(100) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `first_name` varchar(20) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `last_name` varchar(20) COLLATE utf8mb4_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `email`, `password`, `first_name`, `last_name`) VALUES
(1, 'admin1', '$2a$11$1P./i3aDOjnmO8pf3Zv42eOUc3GsRF2WTXtmz.6u1Mm5jgVvx6Xoe', '', ''),
(2, 'daniel@harka.com', '$2b$12$YXd953.zP988jCsG.3/9MOAjH7ntf4anf6J/qoVAfQ6ppOeBGdsue', 'Daniel', 'Harka'),
(30, 'a', '$2a$11$dBV4qO2xxH2Tq2Dy2lDG8OXlp4CITh3fGd5c/3XSr1tgLzyohfWOW', '', ''),
(52, 'b', '$2a$11$5fAL2mj0M7K4C5uGmn4C3eJ3pM8q5xwBJeX1ERU2vkjpsQId4Agdm', '', ''),
(53, '99', '$2b$12$/lsYi6pv81Lh8XX9UQQpN.43GhkN0AxhjopW9GmKWXzU7tTrM4BPC', '', ''),
(54, 'admin1@gmail.com', '$2a$11$FLjsFIsGpAH9xQLaOPmmnOIkzmiJxnJsc/0WVqyn83jlpxalvn09i', '', ''),
(55, 's', '$2a$11$mEE8bCHHvkJZ2pTPzMM8XeNcXieyvrYg4OjRVNlDQFtAJXEVUmRFq', '', ''),
(57, 'a@', '$2a$11$45zjSrP/Jo4gROJbz1c26OzTdp0hllncEn5B5OLJPiDfIOFTB3sdu', '', ''),
(58, 'aq', '$2a$11$fz.0dfj2tiN9O8zoj3HmhuBSeoBnsxLoY3OuQX5VMGl2JwPesaBZK', '', ''),
(71, 'sara@harka.com', '$2b$12$iVupxB48KYlAubNbrUjCB.MvDKXIcSEUSgJZkS5Xqs8Uef6UKH692', 'Sara', 'Harka'),
(81, 'b@harka.com', '$2b$12$ctMll4is9XYe/6XiEcruzu334B3m3EOrJju.GhptRNIxlSx1faIU.', 'bbbbb', 'bbbbb'),
(91, 'csabak@gmailllll.com', '$2b$12$.7Kk38cHxeeHHk2CqqOt9O071hSURGMzHLILcUBUGnry3VYryjV.i', 'Csaba', 'Kkk'),
(101, 'testuser1@testuser1.com', '$2b$12$h0djK.O1mG1q9euS9alRUObppsD9Et7c8jMUO6ovUYugtrzU.PSPW', 'TestUser1', 'TestUser1'),
(151, 'user@harka.com', '$2b$12$g5rk1iLNACuR86CFsR6gbePmOedUTGhz8Mx5xGB6xe.N.aci0NjYK', 'user', 'user'),
(201, 'many@harka.com', '$2b$12$EPZwVSRhJjVQvAgzSFc.len6ETrHm5bdmrrC7iYTWT/CQvAVEGpzK', 'Many', 'Notes'),
(211, 'medvekoma@brum.com', '$2b$12$FEq6vrrXurQeZsVub1ZeieJ.c.vJbJ/2PTwVFnfSSQQr2nVG6/by.', 'Brumba', 'Maci'),
(221, 'aa@a', '$2b$12$SSWWHlmlKWGzVGPCUilfhuzcab9cHSK2NtmecMmVURZ6J5Ia2iPzy', 'aaa', 'aaa'),
(231, 'birojozsi@gmail.com', '$2b$12$lwuPszO84xdSK7rf.zzT2.vXF3zbDdI6jZ8lVhstBFVho.dHMgXo2', 'Biró ', 'József'),
(241, 'felhasznalo@gmail.com', '$2b$12$vlLBhdSmnXd.33rxJXb08.r8LwjV7SqCGvD59ATKecyMNuRBL7Sgq', 'felhasznalo', 'felhasznalo'),
(251, 'felhasznalo2@gmail.com', '$2b$12$XAXHcg6C7yPeqQxDmSDnWOvPfYvm0RfHTRYAYNqPSonLjJY5pRi1.', 'felhasznalo2', 'felhasznalo2'),
(291, 'random-user@harka.com', '$2b$12$ef6/GQ3xR4VLBzWti0f3POkTjsb9O4OvZ85QyZI6lLNIy.ETn1UK2', 'Random', 'User'),
(301, 'akosmateffy11@gmail.com', '$2b$12$hykcJvGIizHW/bzO/r.u4O3NGgjnNdngOV5LPYEvswa0KpCNmvtO2', 'Ákos', 'Mátéffy'),
(311, 'stevecsoka@gmail.com', '$2b$12$tJBVb5AhdhYOj3agbR.2/eTY2vUC0uQVKjK7atwOrExKD3bV5giMi', 'Steve', 'Csoka'),
(321, 'bencze780@gmail.com', '$2b$12$W77JsGt2IJZYgnTQs1AAiOEJXftyPef9gxRx2OcjB/yyt3nZEPCXq', 'István', 'Bencze'),
(331, 'mravcsi@gmail.com', '$2b$12$WKHKxLoT22JGjwbifITh6OHS6P8OYe5fryKLYlC.ggCb3w/lm53cW', 'Dobrocsi', 'Róbertné');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `notes`
--
ALTER TABLE `notes`
  ADD PRIMARY KEY (`note_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `note_category`
--
ALTER TABLE `note_category`
  ADD PRIMARY KEY (`note_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id` (`email`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `notes`
--
ALTER TABLE `notes`
  MODIFY `note_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=501;
--
-- AUTO_INCREMENT for table `note_category`
--
ALTER TABLE `note_category`
  MODIFY `note_id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=341;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `notes`
--
ALTER TABLE `notes`
  ADD CONSTRAINT `notes_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`);

--
-- Constraints for table `note_category`
--
ALTER TABLE `note_category`
  ADD CONSTRAINT `note_category_ibfk_1` FOREIGN KEY (`note_id`) REFERENCES `notes` (`note_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
