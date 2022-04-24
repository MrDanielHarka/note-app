-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2022. Már 21. 20:06
-- Kiszolgáló verziója: 10.4.22-MariaDB
-- PHP verzió: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `note_app`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `notes`
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
-- A tábla adatainak kiíratása `notes`
--

INSERT INTO `notes` (`note_id`, `user_id`, `title`, `content`, `public`, `shared`, `creation_date`, `last_saved`) VALUES
(3, 1, 'test3', 'test3', 0, 0, '0000-00-00', '0000-00-00'),
(4, 1, 'test4', 'test4', 1, 0, '0000-00-00', '0000-00-00'),
(5, 1, 'daniel@harka.com', '', 1, 0, '0000-00-00', '0000-00-00'),
(6, 1, 'test5', 'test5', 1, 0, '0000-00-00', '0000-00-00'),
(7, 17, '6 title', '6 content', 1, 0, '0000-00-00', '0000-00-00'),
(59, 2, '5555555', '5555555', 1, 0, '0000-00-00', '0000-00-00'),
(61, 2, '6666', '666666', 1, 0, '0000-00-00', '0000-00-00'),
(66, 2, '8888', '88888', 1, 0, '0000-00-00', '0000-00-00');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `note_category`
--

CREATE TABLE `note_category` (
  `note_id` int(11) NOT NULL,
  `note_category` varchar(30) COLLATE utf8mb4_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `shares`
--

CREATE TABLE `shares` (
  `note_id` int(11) NOT NULL,
  `email` varchar(30) COLLATE utf8mb4_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `email` varchar(50) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `password` varchar(100) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `first_name` varchar(20) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `last_name` varchar(20) COLLATE utf8mb4_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `users`
--

INSERT INTO `users` (`id`, `email`, `password`, `first_name`, `last_name`) VALUES
(1, 'birojozsi6@gmail.com', 'C#Master', 'Jozsef', 'Biro'),
(2, 'daniel@harka.com', '19930209', 'Daniel', 'Harka'),
(3, 'test1', 'test1', '', ''),
(4, 'test2', 'test2', '', ''),
(5, 'test3', 'test3', '', ''),
(6, 'test4', 'test4', '', ''),
(7, 'test5', 'test5', '', ''),
(11, 'test6', 'test6', '', ''),
(12, 'naszi@gmail.com', 'dsfdsfgdg', '', ''),
(17, '6@66.6', '666666', 'first 6', 'last 6'),
(22, '7@7.7', '$2b$12$yiTTaBErs.B0.uk38v5ytOJLtUvpS8DwMQRipH4zgHy', '77777', '777777'),
(23, '8@8.8', '$2b$12$b88zgSyTL13co9f6FNR86O4EUZ4auZdRcxGyDosEvRnUOQxionOcG', '88888', '88888');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `notes`
--
ALTER TABLE `notes`
  ADD PRIMARY KEY (`note_id`),
  ADD KEY `user_id` (`user_id`);

--
-- A tábla indexei `note_category`
--
ALTER TABLE `note_category`
  ADD PRIMARY KEY (`note_id`);

--
-- A tábla indexei `shares`
--
ALTER TABLE `shares`
  ADD PRIMARY KEY (`note_id`),
  ADD UNIQUE KEY `note_id` (`email`);

--
-- A tábla indexei `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id` (`email`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `notes`
--
ALTER TABLE `notes`
  MODIFY `note_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=68;

--
-- AUTO_INCREMENT a táblához `note_category`
--
ALTER TABLE `note_category`
  MODIFY `note_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `notes`
--
ALTER TABLE `notes`
  ADD CONSTRAINT `notes_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`);

--
-- Megkötések a táblához `note_category`
--
ALTER TABLE `note_category`
  ADD CONSTRAINT `note_category_ibfk_1` FOREIGN KEY (`note_id`) REFERENCES `notes` (`note_id`);

--
-- Megkötések a táblához `shares`
--
ALTER TABLE `shares`
  ADD CONSTRAINT `shares_ibfk_1` FOREIGN KEY (`email`) REFERENCES `users` (`email`),
  ADD CONSTRAINT `shares_ibfk_2` FOREIGN KEY (`note_id`) REFERENCES `notes` (`note_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
