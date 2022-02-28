-- phpMyAdmin SQL Dump
-- version 4.7.1
-- https://www.phpmyadmin.net/
--
-- Host: sql11.freemysqlhosting.net
-- Generation Time: Feb 28, 2022 at 11:07 AM
-- Server version: 5.5.62-0ubuntu0.14.04.1
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
-- Database: `sql11475111`
--

-- --------------------------------------------------------

--
-- Table structure for table `notes`
--

CREATE TABLE `notes` (
  `note_id` int(11) NOT NULL,
  `title` varchar(30) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `content` text COLLATE utf8mb4_hungarian_ci NOT NULL,
  `creation_date` date NOT NULL,
  `last_saved` date NOT NULL,
  `public` tinyint(1) NOT NULL,
  `shared` tinyint(1) NOT NULL,
  `user_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

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
  `mail_address` varchar(30) COLLATE utf8mb4_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `mail_address` varchar(50) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `password` varchar(32) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `username` varchar(30) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `first_name` varchar(20) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `last_name` varchar(20) COLLATE utf8mb4_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `mail_address`, `password`, `username`, `first_name`, `last_name`) VALUES
(1, 'birojozsi6@gmail.com', 'C#Master', 'bjozsef02', 'Jozsef', 'Biro'),
(2, 'daniel@harka.com', '19930209', 'MrDanielHarka', 'Daniel', 'Harka'),
(3, 'test1', 'test1', '', '', '');

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
-- Indexes for table `shares`
--
ALTER TABLE `shares`
  ADD PRIMARY KEY (`note_id`),
  ADD UNIQUE KEY `note_id` (`mail_address`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id` (`mail_address`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `notes`
--
ALTER TABLE `notes`
  MODIFY `note_id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `note_category`
--
ALTER TABLE `note_category`
  MODIFY `note_id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `shares`
--
ALTER TABLE `shares`
  MODIFY `note_id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
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

--
-- Constraints for table `shares`
--
ALTER TABLE `shares`
  ADD CONSTRAINT `shares_ibfk_1` FOREIGN KEY (`mail_address`) REFERENCES `users` (`mail_address`),
  ADD CONSTRAINT `shares_ibfk_2` FOREIGN KEY (`note_id`) REFERENCES `notes` (`note_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
