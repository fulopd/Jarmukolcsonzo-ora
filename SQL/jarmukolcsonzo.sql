-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2019. Dec 19. 16:01
-- Kiszolgáló verziója: 10.4.8-MariaDB
-- PHP verzió: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `jarmukolcsonzo`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `jarmu`
--

CREATE TABLE `jarmu` (
  `rendszam` int(6) NOT NULL,
  `kategoriaId` int(11) NOT NULL,
  `tipus` varchar(50) NOT NULL,
  `modell` varchar(50) NOT NULL,
  `ferohely` int(2) NOT NULL,
  `fogyasztas` int(2) NOT NULL,
  `elerheto` tinyint(1) NOT NULL,
  `szervizben` tinyint(1) NOT NULL,
  `szervizDatum` datetime NOT NULL DEFAULT current_timestamp(),
  `muszakiDatum` datetime NOT NULL DEFAULT current_timestamp(),
  `beszerzesDatum` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `jarmukategoria`
--

CREATE TABLE `jarmukategoria` (
  `Id` int(11) NOT NULL,
  `kategoriaNev` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `jarmukategoria`
--

INSERT INTO `jarmukategoria` (`Id`, `kategoriaNev`) VALUES
(1, 'Személygépkocsi'),
(2, 'Teherautó'),
(3, 'Kamion0');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `jarmu`
--
ALTER TABLE `jarmu`
  ADD PRIMARY KEY (`rendszam`),
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
