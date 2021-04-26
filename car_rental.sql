-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Oct 16, 2020 at 04:41 PM
-- Server version: 5.7.24
-- PHP Version: 7.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `car_rental`
--

-- --------------------------------------------------------

--
-- Table structure for table `booking`
--

DROP TABLE IF EXISTS `booking`;
CREATE TABLE IF NOT EXISTS `booking` (
  `customer` varchar(50) NOT NULL,
  `car` varchar(20) NOT NULL,
  `rent_date` date NOT NULL,
  `return_date` date NOT NULL,
  `days` int(10) NOT NULL,
  `amount` int(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `booking`
--

INSERT INTO `booking` (`customer`, `car`, `rent_date`, `return_date`, `days`, `amount`) VALUES
('0', 'jlkiouo', '2020-01-01', '2020-01-04', 4, 2323233);

-- --------------------------------------------------------

--
-- Table structure for table `car_categ`
--

DROP TABLE IF EXISTS `car_categ`;
CREATE TABLE IF NOT EXISTS `car_categ` (
  `Name` varchar(20) NOT NULL,
  `Description` varchar(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `car_manag`
--

DROP TABLE IF EXISTS `car_manag`;
CREATE TABLE IF NOT EXISTS `car_manag` (
  `car_name` varchar(20) NOT NULL,
  `category` varchar(15) NOT NULL,
  `brand` varchar(15) NOT NULL,
  `color` varchar(10) NOT NULL,
  `mileage` int(40) NOT NULL,
  `car_number` int(40) NOT NULL,
  `daily_price` int(40) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `car_manag`
--

INSERT INTO `car_manag` (`car_name`, `category`, `brand`, `color`, `mileage`, `car_number`, `daily_price`) VALUES
('qweeeeeeeeee', 'asdsad', 'asdasd', 'asdasd', 2342, 23432, 324324),
('asdasdas', 'adsasda', 'asdasd', 'asdasd', 234234, 234234, 234243),
('asdasdas', 'aadsasd', 'asdasd', 'asdasd', 234234, 234234, 234243),
('etqeqtq', 'eqtqet', 'eteqt', 'qweqw', 32324, 324324, 324),
('aaaaaaaaaaaaaa', 'sadasdsad', 'asda', 'asdasd', 324, 3242, 23423),
('adsasdas', 'asdasd', 'asdasd', 'sadasd', 234, 234324, 234324);

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
CREATE TABLE IF NOT EXISTS `customers` (
  `F_Nname` varchar(50) NOT NULL,
  `L_Name` varchar(50) NOT NULL,
  `Phone` int(12) NOT NULL,
  `DOB` date NOT NULL,
  `Licence` varchar(20) NOT NULL,
  `Issue_Date` date NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`F_Nname`, `L_Name`, `Phone`, `DOB`, `Licence`, `Issue_Date`) VALUES
('fdg', 'fsd', 54, '2020-10-12', '36', '2020-10-02'),
('sdf', 'ghj', 21, '2020-10-12', '45', '2020-10-08'),
('dfg', 'ghj', 45, '2020-10-12', '75', '2020-10-02');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

DROP TABLE IF EXISTS `login`;
CREATE TABLE IF NOT EXISTS `login` (
  `Fname` varchar(50) NOT NULL,
  `Lname` varchar(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`Fname`, `Lname`, `username`, `password`) VALUES
('', '', '', ''),
('', '', '', ''),
('mariooo', 'mariiilolololol', 'root', 'root'),
('sadmdsakpm', 'sda,dsa,sad', 'k', 'm');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
