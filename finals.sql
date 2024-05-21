-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 21, 2024 at 10:30 AM
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
-- Database: `finals`
--

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `customer_code` varchar(11) NOT NULL,
  `cust_name` varchar(15) NOT NULL,
  `cust_address` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`customer_code`, `cust_name`, `cust_address`) VALUES
('C_001', 'Sample', 'Daet'),
('C_002', 'ronald', 'Vinzons'),
('C_003', 'Abel', 'Daet'),
('C_004', 'joriz', 'Daet'),
('C_005', 'kyle', 'Daet');

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `product_code` varchar(11) NOT NULL,
  `Prod_name` varchar(15) NOT NULL,
  `Prod_qty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`product_code`, `Prod_name`, `Prod_qty`) VALUES
('P_001', 'Laptop', 62),
('P_003', 'Roys', 20),
('P_004', 'Lomi', 73),
('P_005', 'Pom', 12),
('P_006', 'Phone', 20);

-- --------------------------------------------------------

--
-- Table structure for table `product_purchase_order`
--

CREATE TABLE `product_purchase_order` (
  `Product_code` varchar(11) NOT NULL,
  `Qty` varchar(11) NOT NULL,
  `Transaction` varchar(5) NOT NULL,
  `Customer_Supplier` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `product_purchase_order`
--

INSERT INTO `product_purchase_order` (`Product_code`, `Qty`, `Transaction`, `Customer_Supplier`) VALUES
('1', '3', '', 'S_1'),
('1', '3', '', 'S_1'),
('1', '3', 'Deliv', 'S_2'),
('3', '34', 'Deliv', 'S_2'),
('1', '23', 'Sold', 'C_3'),
('4', '23', 'Deliv', 'S_2'),
('003', '3', 'Sold', 'C_003'),
('001', '3', 'Deliv', 'S_004'),
('P_005', '4', 'Sold', 'C_003'),
('P_005', '4', 'Sold', 'C_003'),
('P_005', '4', 'Sold', 'C_003'),
('P_005', '4', 'Sold', 'C_003'),
('P_005', '4', 'Sold', 'C_003'),
('P_004', '4', 'Sold', 'C_002'),
('P_004', '4', 'Sold', 'C_002'),
('P_004', '4', 'Sold', 'C_002'),
('P_004', '4', 'Sold', 'C_002'),
('P_004', '4', 'Sold', 'C_002'),
('P_004', '4', 'Sold', 'C_002'),
('004', '20', 'Deliv', 'S_004'),
('P_001', '10', 'Sold', 'C_003'),
('P_001', '10', 'Sold', 'C_002'),
('P_003', '1', 'Sold', 'C_003'),
('P_003', '1', 'Sold', 'C_003'),
('P_001', '1', 'Deliv', 'S_001'),
('P_003', '1', 'Deliv', 'S_001'),
('P_003', '1', 'Sold', 'C_001'),
('P_003', '1', 'Sold', 'C_001'),
('P_001', '1', 'Sold', 'C_001');

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `supplier_id` varchar(11) NOT NULL,
  `supplier_name` varchar(15) NOT NULL,
  `supplier_location` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`supplier_id`, `supplier_name`, `supplier_location`) VALUES
('S_001', 'ABC', 'Daet'),
('S_002', 'NANA', 'Alawihao'),
('S_003', 'MaamL', 'Daet'),
('S_004', 'DeRamos', 'Daet'),
('S_005', 'Ripa', 'Vinzons');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`customer_code`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`product_code`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`supplier_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
