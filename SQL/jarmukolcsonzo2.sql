-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Jan 18. 12:00
-- Kiszolgáló verziója: 10.1.34-MariaDB
-- PHP verzió: 7.2.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `jarmukolcsonzo2`
--
CREATE DATABASE IF NOT EXISTS `jarmukolcsonzo2` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `jarmukolcsonzo2`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `jarmu`
--

CREATE TABLE `jarmu` (
  `Id` int(11) NOT NULL,
  `rendszam` varchar(10) NOT NULL,
  `kategoriaId` int(11) NOT NULL,
  `tipus` varchar(50) DEFAULT NULL,
  `modell` varchar(50) DEFAULT NULL,
  `ferohely` int(2) DEFAULT NULL,
  `fogyasztas` double DEFAULT NULL,
  `elerheto` tinyint(1) NOT NULL DEFAULT '1',
  `szervizben` tinyint(1) NOT NULL DEFAULT '0',
  `szervizDatum` datetime DEFAULT CURRENT_TIMESTAMP,
  `muszakiDatum` datetime DEFAULT NULL,
  `beszerzesDatum` datetime DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `jarmu`
--

INSERT INTO `jarmu` (`Id`, `rendszam`, `kategoriaId`, `tipus`, `modell`, `ferohely`, `fogyasztas`, `elerheto`, `szervizben`, `szervizDatum`, `muszakiDatum`, `beszerzesDatum`) VALUES
(1, 'TESZT', 1, 'Ford', 'Galaxy', NULL, NULL, 1, 0, '2020-01-18 11:18:17', NULL, '2020-01-18 11:18:17'),
(2, 'TESZT2', 3, 'Scania', NULL, NULL, NULL, 0, 0, '2020-01-18 11:18:47', NULL, '2020-01-18 11:18:47');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `jarmukategoria`
--

CREATE TABLE `jarmukategoria` (
  `Id` int(11) NOT NULL,
  `kategoriaNev` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `jarmukategoria`
--

INSERT INTO `jarmukategoria` (`Id`, `kategoriaNev`) VALUES
(1, 'Személygépkocsi'),
(2, 'Teherkocsi'),
(3, 'Kamion00');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `jarmu`
--
ALTER TABLE `jarmu`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `rendszam` (`rendszam`),
  ADD KEY `kategoriaId` (`kategoriaId`);

--
-- A tábla indexei `jarmukategoria`
--
ALTER TABLE `jarmukategoria`
  ADD PRIMARY KEY (`Id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `jarmu`
--
ALTER TABLE `jarmu`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT a táblához `jarmukategoria`
--
ALTER TABLE `jarmukategoria`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `jarmu`
--
ALTER TABLE `jarmu`
  ADD CONSTRAINT `jarmu_ibfk_1` FOREIGN KEY (`kategoriaId`) REFERENCES `jarmukategoria` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
