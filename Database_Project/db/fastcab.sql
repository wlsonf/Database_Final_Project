-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 03, 2017 at 10:15 AM
-- Server version: 10.1.21-MariaDB
-- PHP Version: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `fastcab`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `staffID` varchar(100) NOT NULL,
  `officeID` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`staffID`, `officeID`) VALUES
('st01', 'of01'),
('st02', 'of02'),
('st03', 'of03'),
('st04', 'of04'),
('st05', 'of05');

-- --------------------------------------------------------

--
-- Table structure for table `business`
--

CREATE TABLE `business` (
  `clientID` varchar(100) NOT NULL,
  `contractID` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `business`
--

INSERT INTO `business` (`clientID`, `contractID`) VALUES
('cl01', 'ct01'),
('cl05', 'ct02'),
('cl06', 'ct03'),
('cl10', 'ct04');

-- --------------------------------------------------------

--
-- Table structure for table `client`
--

CREATE TABLE `client` (
  `clientID` varchar(100) NOT NULL,
  `name` varchar(100) NOT NULL,
  `phone` varchar(100) NOT NULL,
  `class` varchar(1) DEFAULT NULL,
  `address` varchar(300) NOT NULL,
  `password` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `client`
--

INSERT INTO `client` (`clientID`, `name`, `phone`, `class`, `address`, `password`) VALUES
('cl01', 'Teh Botol', '0819849392', 'b', 'Jl. Teh Botol Sosro', '123456'),
('cl02', 'Kabel Data', '09128394030', 'p', 'Jl. Kabel Data Kenceng', '123456'),
('cl03', 'Wilson Will', '08123949302', 'p', 'Jl. MOI', '123456'),
('cl04', 'Semoura Coyy', '08123948392', 'p', 'Jl. Gatau Namanya Keren', '123456'),
('cl05', 'Unilever', '08123949203', 'b', 'Jl. Unilever Utara', '123456'),
('cl06', 'Apple', '08123494320', 'b', 'Jl. Apple Selatan', '123456'),
('cl07', 'Teddy Hooo', '08158393201', 'p', 'Jl. Ponti', '123456'),
('cl08', 'Tono Oye', '089917238884', 'p', 'Jl. Tonooo', '123456'),
('cl09', 'Ono Oo', '089888399282', 'p', 'Jl. Onoooo', '123456'),
('cl10', 'BCA', '0213444555', 'b', 'Jl. Central Asia', '123456');

-- --------------------------------------------------------

--
-- Table structure for table `contract`
--

CREATE TABLE `contract` (
  `contractID` varchar(100) NOT NULL,
  `staffID` varchar(100) NOT NULL,
  `numberOfJob` int(11) NOT NULL,
  `totalMilage` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `contract`
--

INSERT INTO `contract` (`contractID`, `staffID`, `numberOfJob`, `totalMilage`) VALUES
('ct01', 'st06', 5, 50),
('ct02', 'st06', 14, 635),
('ct03', 'st06', 21, 1402),
('ct04', 'st07', 0, 0),
('ct05', 'st07', 4, 190),
('ct06', 'st07', 99, 1673),
('ct07', 'st08', 25, 687),
('ct08', 'st08', 14, 251),
('ct09', 'st08', 216, 1803),
('ct10', 'st09', 82, 729),
('ct11', 'st09', 51, 1006),
('ct12', 'st09', 82, 196),
('ct13', 'st10', 60, 2800),
('ct14', 'st10', 52, 2589),
('ct15', 'st10', 69, 5402);

-- --------------------------------------------------------

--
-- Table structure for table `driver`
--

CREATE TABLE `driver` (
  `extID` varchar(100) NOT NULL,
  `plateNumber` varchar(20) NOT NULL,
  `staffID` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `driver`
--

INSERT INTO `driver` (`extID`, `plateNumber`, `staffID`) VALUES
('ex11', 'SCT 0983', 'st10'),
('ex12', 'SCT 4738', 'st07'),
('ex13', 'SCT 5123', 'st07'),
('ex14', 'SCT 5123', 'st07'),
('ex15', 'SCT 6723', 'st09'),
('ex16', 'SCT 6748', 'st08'),
('ex17', 'SCT 7380', 'st07'),
('ex18', 'SCT 7380', 'st07'),
('ex19', 'SCT 7912', 'st06'),
('ex20', 'SCT 8123', 'st06'),
('ex21', 'SCT 8132', 'st07'),
('ex22', 'SCT 8192', 'st08'),
('ex23', 'SCT 8192', 'st08'),
('ex24', 'SCT 8888', 'st10'),
('ex10', 'SCT 8888', 'st10'),
('ex25', 'SCT 8889', 'st10'),
('ex26', 'SCT 8889', 'st10'),
('ex27', 'SCT 8890', 'st10'),
('ex28', 'SCT 8913', 'st09'),
('ex29', 'SCT 6748', 'st08'),
('ex30', 'SCT 6723', 'st09'),
('ex31', 'SCT 8123', 'st06'),
('ex32', 'SCT 8123', 'st06'),
('ex33', 'SCT 7912', 'st06'),
('ex34', 'SCT 8123', 'st06'),
('ex35', 'SCT 6812', 'st06'),
('ex36', 'SCT 9987', 'st06'),
('ex37', 'SCT 6812', 'st06'),
('ex38', 'SCT 9987', 'st06'),
('ex39', 'SCT 7912', 'st06'),
('ex40', 'SCT 9987', 'st06');

-- --------------------------------------------------------

--
-- Table structure for table `external`
--

CREATE TABLE `external` (
  `extID` varchar(100) NOT NULL,
  `name` varchar(100) NOT NULL,
  `phone` varchar(100) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `age` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `external`
--

INSERT INTO `external` (`extID`, `name`, `phone`, `gender`, `age`) VALUES
('ex01', 'John D. Reid', '7738379458', 'male', 76),
('ex02', 'Christine T. Loh', '5086301617', 'female', 36),
('ex03', 'Frank Price', '3234653596', 'male', 34),
('ex04', 'Derek Mont', '8040058495', 'male', 54),
('ex05', 'Maria Williams', '7829103901', 'female', 27),
('ex06', 'Jacquelyn', '5082437912', 'female', 44),
('ex07', 'Bokonono', '2523930185', 'male', 37),
('ex08', 'Eddie Oo', '2099755530', 'male', 25),
('ex09', 'Amy Wiggins', '2485576633', 'female', 33),
('ex10', 'Bob Cain', '8156746406', 'male', 42),
('ex11', 'Richard Adams', '6064392056', 'male', 36),
('ex12', 'Monica March', '6207666516', 'female', 29),
('ex13', 'Ryan Onjo', '5732985180', 'male', 41),
('ex14', 'Lucy Ann', '6623901843', 'female', 28),
('ex15', 'Marion B. Bunch', '912-601-4648', 'female', 35),
('ex16', 'Geraldine M. Henderson', '425-709-9363', 'female', 61),
('ex17', 'Dorothy R. Smith', '361-961-1086', 'female', 54),
('ex18', 'Rose Frewin', '614-874-8053', 'female', 43),
('ex19', 'Maddison Cunningham', '079 1772 6803', 'female', 60),
('ex20', 'Seth Leggatt', '070 3611 9788', 'male', 45),
('ex21', 'Fiacre Galarneau', '077 7564 1571', 'male', 36),
('ex22', 'Ansel Corbin', '070 0736 4854', 'male', 45),
('ex23', 'Fortunata Bergamaschi', '070 6230 6088', 'female', 44),
('ex24', 'Maria Lorenzo', '077 5363 4712', 'female', 31),
('ex25', 'Franco Milanesi', '077 3995 9360', 'male', 34),
('ex26', 'Ildebrando Lucchese', '070 1221 7639', 'male', 26),
('ex27', 'Ida Loggia', '078 4345 2818', 'female', 58),
('ex28', 'Xavier Gauvin', '079 0664 1586', 'male', 37),
('ex29', 'Tyler Collins', '701 6521 4746\r\n', 'male', 22),
('ex30', 'Kody Jones', '406 6557 2356', 'male', 32),
('ex31', 'Virginia M. Brower', '616 2307 1594', 'female', 33),
('ex32', 'Christine T. Nissen', '337 1262 3257', 'female', 24),
('ex33', 'Ensio Juva', '071 3029 7683', 'male', 31),
('ex34', 'Erik Baum', '070 8894 5606', 'male', 22),
('ex35', 'Birgit Fischer', '079 0052 8442', 'female', 19),
('ex36', 'Matteo Toscani', '070 5800 6541', 'male', 40),
('ex37', 'Virgilia Panicucci', '078 4622 4430', 'female', 28),
('ex38', 'Gianetto Siciliani', '079 5029 9372', 'male', 33),
('ex39', 'Lushikatome', '077 1204 7642', 'male', 26),
('ex40', 'Dionisia Napolitani', '078 2127 9883', 'female', 42);

-- --------------------------------------------------------

--
-- Table structure for table `job`
--

CREATE TABLE `job` (
  `jobID` varchar(100) NOT NULL,
  `extID` varchar(100) NOT NULL,
  `clientID` varchar(100) NOT NULL,
  `date` date NOT NULL,
  `pTime` time NOT NULL,
  `dTime` time NOT NULL,
  `pAddress` varchar(100) NOT NULL,
  `dAddress` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `job`
--

INSERT INTO `job` (`jobID`, `extID`, `clientID`, `date`, `pTime`, `dTime`, `pAddress`, `dAddress`) VALUES
('jb001', 'ex20', 'cl01', '2017-06-02', '09:19:31', '09:33:14', 'fx', 'jwc'),
('jb002', 'ex12', 'cl03', '2017-06-02', '09:27:48', '09:52:15', 'gbk', 'gi'),
('jb003', 'ex31', 'cl05', '2017-06-02', '09:03:16', '09:21:35', 'senayan', 'kelapa gading'),
('jb004', 'ex12', 'cl04', '2017-06-02', '10:07:19', '10:31:20', 'meruya', 'senayan'),
('jb005', 'ex33', 'cl06', '2017-06-03', '02:22:14', '02:39:19', 'puri', 'meruya'),
('jb006', 'ex33', 'cl08', '2017-06-03', '03:00:13', '03:17:07', 'pik', 'bandara');

-- --------------------------------------------------------

--
-- Table structure for table `manager`
--

CREATE TABLE `manager` (
  `staffID` varchar(100) NOT NULL,
  `officeID` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `manager`
--

INSERT INTO `manager` (`staffID`, `officeID`) VALUES
('st06', 'of01'),
('st07', 'of02'),
('st08', 'of03'),
('st09', 'of04'),
('st10', 'of05');

-- --------------------------------------------------------

--
-- Table structure for table `office`
--

CREATE TABLE `office` (
  `officeID` varchar(30) NOT NULL,
  `name` varchar(100) NOT NULL,
  `city` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `office`
--

INSERT INTO `office` (`officeID`, `name`, `city`) VALUES
('of01', 'Glasgow', 'Glasgow'),
('of02', 'Aberdeen', 'Aberdeen'),
('of03', 'Edinburgh', 'Edinburgh'),
('of04', 'Stirling', 'Stirling'),
('of05', 'Dundee', 'Dundee');

-- --------------------------------------------------------

--
-- Table structure for table `owner`
--

CREATE TABLE `owner` (
  `extID` varchar(100) NOT NULL,
  `staffID` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `owner`
--

INSERT INTO `owner` (`extID`, `staffID`) VALUES
('ex01', 'st06'),
('ex02', 'st06'),
('ex03', 'st07'),
('ex04', 'st07'),
('ex05', 'st08'),
('ex06', 'st08'),
('ex07', 'st09'),
('ex08', 'st09'),
('ex09', 'st10'),
('ex10', 'st10');

-- --------------------------------------------------------

--
-- Table structure for table `private`
--

CREATE TABLE `private` (
  `clientID` varchar(100) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `age` int(11) NOT NULL,
  `staffID` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `private`
--

INSERT INTO `private` (`clientID`, `gender`, `age`, `staffID`) VALUES
('cl02', 'male', 2, 'st06'),
('cl03', 'male', 19, 'st06'),
('cl04', 'female', 25, 'st07'),
('cl07', 'male', 20, 'st07'),
('cl08', 'male', 20, 'st08'),
('cl09', 'female', 31, 'st09');

-- --------------------------------------------------------

--
-- Table structure for table `receipt`
--

CREATE TABLE `receipt` (
  `jobID` varchar(100) NOT NULL,
  `mileage` int(11) NOT NULL,
  `status` varchar(100) NOT NULL,
  `description` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `receipt`
--

INSERT INTO `receipt` (`jobID`, `mileage`, `status`, `description`) VALUES
('jb001', 12, 'succeed', 'ok'),
('jb002', 7, 'succeed', 'ok'),
('jb003', 9, 'succeed', 'ok'),
('jb004', 15, 'succeed', 'ok'),
('jb005', 20, 'succeed', 'ok'),
('jb006', 14, 'succeed', 'ok');

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `staffID` varchar(30) NOT NULL,
  `name` varchar(100) NOT NULL,
  `phone` varchar(20) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `age` int(11) NOT NULL,
  `password` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`staffID`, `name`, `phone`, `gender`, `age`, `password`) VALUES
('st01', 'Wilson', '08128071900', 'male', 19, 'admin'),
('st02', 'Jeffrey', '0878899000', 'male', 20, 'admin'),
('st03', 'Novi', '08128593973', 'female', 30, 'admin'),
('st04', 'Wuilly', '0897685938', 'male', 43, 'admin'),
('st05', 'Justin', '08928319237', 'male', 32, 'admin'),
('st06', 'Noah', '08293148574', 'male', 28, 'admin'),
('st07', 'Vani', '08931884273', 'female', 42, 'admin'),
('st08', 'Jordanatha', '089627888389', 'male', 18, 'admin'),
('st09', 'Archel Taneka', '08128071999', 'male', 19, 'admin'),
('st10', 'Adrian Alexander', '08128071988', 'male', 19, 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `taxi`
--

CREATE TABLE `taxi` (
  `plateNumber` varchar(20) NOT NULL,
  `type` varchar(30) NOT NULL,
  `color` varchar(10) NOT NULL,
  `extID` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `taxi`
--

INSERT INTO `taxi` (`plateNumber`, `type`, `color`, `extID`) VALUES
('SCT 0983', 'Smart', 'blue', 'ex09'),
('SCT 4738', 'Toyota Camry', 'purple', 'ex04'),
('SCT 5123', 'Nissan March', 'yellow', 'ex03'),
('SCT 6723', 'Fiat Panda', 'white', 'ex07'),
('SCT 6748', 'Citroen C1', 'black', 'ex06'),
('SCT 6812', 'Smart', 'orange', 'ex01'),
('SCT 7380', 'Toyota Yaris', 'black', 'ex10'),
('SCT 7912', 'VW Golf', 'silver', 'ex02'),
('SCT 8123', 'Smart', 'green', 'ex01'),
('SCT 8132', 'Mitsubishi Mirage', 'brown', 'ex03'),
('SCT 8192', 'AUDI A4', 'orange', 'ex05'),
('SCT 8888', 'Chevrolet Camaro', 'purple', 'ex10'),
('SCT 8889', 'Chevrolet Corvette Stingray', 'pink', 'ex10'),
('SCT 8890', 'Chevrolet Volt', 'grey', 'ex10'),
('SCT 8913', 'Peugeot 308', 'red', 'ex08'),
('SCT 9987', 'AUDI A4', 'white', 'ex02');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD KEY `staffID` (`staffID`),
  ADD KEY `officeID` (`officeID`);

--
-- Indexes for table `business`
--
ALTER TABLE `business`
  ADD KEY `contractID` (`contractID`),
  ADD KEY `clientID` (`clientID`);

--
-- Indexes for table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`clientID`);

--
-- Indexes for table `contract`
--
ALTER TABLE `contract`
  ADD PRIMARY KEY (`contractID`),
  ADD KEY `staffID` (`staffID`);

--
-- Indexes for table `driver`
--
ALTER TABLE `driver`
  ADD KEY `extID` (`extID`),
  ADD KEY `plateNumber` (`plateNumber`),
  ADD KEY `staffID` (`staffID`);

--
-- Indexes for table `external`
--
ALTER TABLE `external`
  ADD PRIMARY KEY (`extID`);

--
-- Indexes for table `job`
--
ALTER TABLE `job`
  ADD PRIMARY KEY (`jobID`),
  ADD KEY `extID` (`extID`),
  ADD KEY `clientID` (`clientID`);

--
-- Indexes for table `manager`
--
ALTER TABLE `manager`
  ADD KEY `staffID` (`staffID`),
  ADD KEY `officeID` (`officeID`);

--
-- Indexes for table `office`
--
ALTER TABLE `office`
  ADD PRIMARY KEY (`officeID`);

--
-- Indexes for table `owner`
--
ALTER TABLE `owner`
  ADD KEY `extID` (`extID`),
  ADD KEY `staffID` (`staffID`);

--
-- Indexes for table `private`
--
ALTER TABLE `private`
  ADD KEY `clientID` (`clientID`),
  ADD KEY `staffID` (`staffID`);

--
-- Indexes for table `receipt`
--
ALTER TABLE `receipt`
  ADD KEY `jobID` (`jobID`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`staffID`);

--
-- Indexes for table `taxi`
--
ALTER TABLE `taxi`
  ADD PRIMARY KEY (`plateNumber`),
  ADD KEY `extID` (`extID`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `admin`
--
ALTER TABLE `admin`
  ADD CONSTRAINT `admin_ibfk_1` FOREIGN KEY (`staffID`) REFERENCES `staff` (`staffID`) ON UPDATE CASCADE,
  ADD CONSTRAINT `admin_ibfk_2` FOREIGN KEY (`officeID`) REFERENCES `office` (`officeID`) ON UPDATE CASCADE;

--
-- Constraints for table `business`
--
ALTER TABLE `business`
  ADD CONSTRAINT `business_ibfk_1` FOREIGN KEY (`contractID`) REFERENCES `contract` (`contractID`) ON UPDATE CASCADE,
  ADD CONSTRAINT `business_ibfk_2` FOREIGN KEY (`clientID`) REFERENCES `client` (`clientID`) ON UPDATE CASCADE;

--
-- Constraints for table `contract`
--
ALTER TABLE `contract`
  ADD CONSTRAINT `contract_ibfk_1` FOREIGN KEY (`staffID`) REFERENCES `manager` (`staffID`) ON UPDATE CASCADE;

--
-- Constraints for table `driver`
--
ALTER TABLE `driver`
  ADD CONSTRAINT `driver_ibfk_1` FOREIGN KEY (`extID`) REFERENCES `external` (`extID`) ON UPDATE CASCADE,
  ADD CONSTRAINT `driver_ibfk_2` FOREIGN KEY (`plateNumber`) REFERENCES `taxi` (`plateNumber`) ON UPDATE CASCADE,
  ADD CONSTRAINT `driver_ibfk_3` FOREIGN KEY (`staffID`) REFERENCES `manager` (`staffID`) ON UPDATE CASCADE;

--
-- Constraints for table `job`
--
ALTER TABLE `job`
  ADD CONSTRAINT `job_ibfk_1` FOREIGN KEY (`extID`) REFERENCES `driver` (`extID`) ON UPDATE CASCADE,
  ADD CONSTRAINT `job_ibfk_2` FOREIGN KEY (`clientID`) REFERENCES `client` (`clientID`) ON UPDATE CASCADE;

--
-- Constraints for table `manager`
--
ALTER TABLE `manager`
  ADD CONSTRAINT `manager_ibfk_1` FOREIGN KEY (`staffID`) REFERENCES `staff` (`staffID`) ON UPDATE CASCADE,
  ADD CONSTRAINT `manager_ibfk_2` FOREIGN KEY (`officeID`) REFERENCES `office` (`officeID`) ON UPDATE CASCADE;

--
-- Constraints for table `owner`
--
ALTER TABLE `owner`
  ADD CONSTRAINT `owner_ibfk_1` FOREIGN KEY (`extID`) REFERENCES `external` (`extID`) ON UPDATE CASCADE,
  ADD CONSTRAINT `owner_ibfk_2` FOREIGN KEY (`staffID`) REFERENCES `manager` (`staffID`) ON UPDATE CASCADE;

--
-- Constraints for table `private`
--
ALTER TABLE `private`
  ADD CONSTRAINT `private_ibfk_1` FOREIGN KEY (`clientID`) REFERENCES `client` (`clientID`) ON UPDATE CASCADE,
  ADD CONSTRAINT `private_ibfk_2` FOREIGN KEY (`staffID`) REFERENCES `manager` (`staffID`) ON UPDATE CASCADE;

--
-- Constraints for table `receipt`
--
ALTER TABLE `receipt`
  ADD CONSTRAINT `receipt_ibfk_1` FOREIGN KEY (`jobID`) REFERENCES `job` (`jobID`) ON UPDATE CASCADE;

--
-- Constraints for table `taxi`
--
ALTER TABLE `taxi`
  ADD CONSTRAINT `taxi_ibfk_1` FOREIGN KEY (`extID`) REFERENCES `external` (`extID`) ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
