-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 05, 2024 at 02:11 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cosme`
--

-- --------------------------------------------------------

--
-- Table structure for table `d_records`
--

CREATE TABLE `d_records` (
  `NAME` varchar(50) NOT NULL,
  `LASTNAME` varchar(50) NOT NULL,
  `EMAIL` varchar(50) NOT NULL,
  `DATE` date NOT NULL,
  `PASSWORDS` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `d_records`
--

INSERT INTO `d_records` (`NAME`, `LASTNAME`, `EMAIL`, `DATE`, `PASSWORDS`) VALUES
('alexander', 'man', 'fdf', '2024-05-07', '123'),
('AYAW', 'AYAW', 'AYAW', '2002-03-17', 'AYAW'),
('jetlance', 'arabaca', 'arabaca@gmal.com', '2000-06-14', 'pogi'),
('JHONFRED', 'DOPING', 'DOPING@GMAI.COM', '2001-07-19', '1xbet'),
('rey', 'pogi', 'rey@gmail.com', '2000-02-09', 'rey');

-- --------------------------------------------------------

--
-- Table structure for table `m_records`
--

CREATE TABLE `m_records` (
  `MEDICINE#` int(11) NOT NULL,
  `MEDICINE NAME` varchar(50) NOT NULL,
  `STOCKS` int(11) NOT NULL,
  `PRICE` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `m_records`
--

INSERT INTO `m_records` (`MEDICINE#`, `MEDICINE NAME`, `STOCKS`, `PRICE`) VALUES
(8, 'bioflu', 45, 423),
(11, 'PARACETAMOL', 567, 1500),
(12, 'ANTI BIOTICS', 123, 343);

-- --------------------------------------------------------

--
-- Table structure for table `par_records`
--

CREATE TABLE `par_records` (
  `NAME` varchar(50) NOT NULL,
  `LASTNAME` varchar(50) NOT NULL,
  `EMAIL` varchar(50) NOT NULL,
  `DATE` date NOT NULL,
  `PASSWORDS` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `par_records`
--

INSERT INTO `par_records` (`NAME`, `LASTNAME`, `EMAIL`, `DATE`, `PASSWORDS`) VALUES
('ERIK', 'JHON', 'JHON@GMAIL.COM', '2005-07-14', 'pogi'),
('JHON', 'ERIC', 'JHON@GMAIL.COM', '2004-07-15', 'luca'),
('LATINA', 'LATINA', 'LATINA@GMAIL.COM', '1995-07-13', '65'),
('mendez', 'afro', 'afro@gmail.com', '1995-03-09', '2');

-- --------------------------------------------------------

--
-- Table structure for table `price_records`
--

CREATE TABLE `price_records` (
  `PROCEDURE#` int(11) NOT NULL,
  `PROCEDURE NAME` varchar(50) NOT NULL,
  `PROCEDURE PRICE` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `price_records`
--

INSERT INTO `price_records` (`PROCEDURE#`, `PROCEDURE NAME`, `PROCEDURE PRICE`) VALUES
(4, 'BUTTAX', 5647),
(7, 'eyebrow extender', 2312),
(8, 'PENIS INLARGEMENT', 20456),
(9, 'RHINO PLACTIC', 123213),
(11, 'BUTTAX', 2343);

-- --------------------------------------------------------

--
-- Table structure for table `p_records`
--

CREATE TABLE `p_records` (
  `PATIENT_NUMBER` int(11) NOT NULL,
  `PATIENT_NAME` varchar(100) NOT NULL,
  `PROCEDURE` varchar(100) NOT NULL,
  `APPOINTMENT` varchar(100) NOT NULL,
  `TIME` varchar(100) NOT NULL,
  `DOCTOR` varchar(100) NOT NULL,
  `ROOM` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `p_records`
--

INSERT INTO `p_records` (`PATIENT_NUMBER`, `PATIENT_NAME`, `PROCEDURE`, `APPOINTMENT`, `TIME`, `DOCTOR`, `ROOM`) VALUES
(1, 'MIGUEL', 'RHINO PLASTIY', '4/12/2024', '10:00 AM', 'Jetlance Arabaca', 'h5'),
(2, 'BAKARDE TAN', 'BREAS INPLANT', '4/27/2024', '9:00 AM', 'PARK LEE', 'H7'),
(4, 'LEBRON JAMES', 'EYEBROW EXTENDER', '4/13/2024', '10:00 AM', 'JETLANCE ARABACA', 'H5'),
(6, 'GOHUN', 'BOTTOX', '4/6/2024', '3:00 AM', 'JETLANCE ARABACA', 'H4'),
(8, 'ANNE CURTIS', 'EYE BROW EXTENSION', '5/10/2024', '10:00 AM', 'JHONFRED DOPING', 'H5');

-- --------------------------------------------------------

--
-- Table structure for table `r_records`
--

CREATE TABLE `r_records` (
  `NAME` varchar(50) NOT NULL,
  `LASTNAME` varchar(50) NOT NULL,
  `EMAIL` varchar(50) NOT NULL,
  `DATE` date NOT NULL,
  `PASSWORDS` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `r_records`
--

INSERT INTO `r_records` (`NAME`, `LASTNAME`, `EMAIL`, `DATE`, `PASSWORDS`) VALUES
('goku', 'hame', 'ds', '1995-03-09', '1'),
('kim', 'alonzo', 'ALONZO@GMAIL.COM', '1995-07-13', 'QWER'),
('KUZMA', 'KYLE', 'KYLE@GMAIL.COM', '1999-02-24', 'kyle'),
('Lim', 'Lopez', 'lopez@gmail.com', '2000-07-13', 'ayos'),
('rey', 'pogi', 'pogi@gmail.com', '2024-03-07', '12'),
('tyu', 'qwe2', 'qwe2@gmail.com', '2024-06-08', '123');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `d_records`
--
ALTER TABLE `d_records`
  ADD PRIMARY KEY (`NAME`);

--
-- Indexes for table `m_records`
--
ALTER TABLE `m_records`
  ADD PRIMARY KEY (`MEDICINE#`);

--
-- Indexes for table `par_records`
--
ALTER TABLE `par_records`
  ADD PRIMARY KEY (`NAME`);

--
-- Indexes for table `price_records`
--
ALTER TABLE `price_records`
  ADD PRIMARY KEY (`PROCEDURE#`);

--
-- Indexes for table `p_records`
--
ALTER TABLE `p_records`
  ADD PRIMARY KEY (`PATIENT_NUMBER`);

--
-- Indexes for table `r_records`
--
ALTER TABLE `r_records`
  ADD PRIMARY KEY (`NAME`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `m_records`
--
ALTER TABLE `m_records`
  MODIFY `MEDICINE#` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `price_records`
--
ALTER TABLE `price_records`
  MODIFY `PROCEDURE#` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `p_records`
--
ALTER TABLE `p_records`
  MODIFY `PATIENT_NUMBER` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
