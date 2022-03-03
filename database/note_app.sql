-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 03, 2022 at 01:18 PM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `note_app2`
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
  `shared` tinyint(1) NOT NULL,
  `creation_date` date NOT NULL,
  `last_saved` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- Dumping data for table `notes`
--

INSERT INTO `notes` (`note_id`, `user_id`, `title`, `content`, `public`, `shared`, `creation_date`, `last_saved`) VALUES
(1, 2, 'test1', 'test1', 1, 0, '0000-00-00', '0000-00-00'),
(2, 2, 'test2', 'test2', 1, 0, '0000-00-00', '0000-00-00'),
(3, 1, 'test3', 'test3', 0, 0, '0000-00-00', '0000-00-00'),
(4, 1, 'test4', 'test4', 1, 0, '0000-00-00', '0000-00-00'),
(5, 1, 'daniel@harka.com', '', 1, 0, '0000-00-00', '0000-00-00'),
(6, 1, 'test5', 'test5', 1, 0, '0000-00-00', '0000-00-00');

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

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `email` varchar(50) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `password` varchar(32) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `first_name` varchar(20) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `last_name` varchar(20) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `username` varchar(30) COLLATE utf8mb4_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `email`, `password`, `first_name`, `last_name`, `username`) VALUES
(1, 'birojozsi6@gmail.com', 'C#Master', 'Jozsef', 'Biro', 'bjozsef02'),
(2, 'daniel@harka.com', '19930209', 'Daniel', 'Harka', 'MrDanielHarka'),
(3, 'test1', 'test1', '', '', ''),
(4, 'test2', 'test2', '', '', ''),
(5, 'test3', 'test3', '', '', ''),
(6, 'test4', 'test4', '', '', ''),
(7, 'test5', 'test5', '', '', ''),
(11, 'test6', 'test6', '', '', ''),
(12, 'naszi@gmail.com', 'dsfdsfgdg', '', '', '');

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
  ADD UNIQUE KEY `note_id` (`email`);

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
  MODIFY `note_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

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
  ADD CONSTRAINT `shares_ibfk_1` FOREIGN KEY (`email`) REFERENCES `users` (`email`),
  ADD CONSTRAINT `shares_ibfk_2` FOREIGN KEY (`note_id`) REFERENCES `notes` (`note_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
