-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 13, 2025 at 02:41 PM
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
-- Database: `kasir`
--

-- --------------------------------------------------------

--
-- Table structure for table `detail_transaksi`
--

CREATE TABLE `detail_transaksi` (
  `id` int(11) NOT NULL,
  `transaksi_id` int(11) DEFAULT NULL,
  `produk_id` int(11) DEFAULT NULL,
  `qty` int(11) DEFAULT NULL,
  `subtotal` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `detail_transaksi`
--

INSERT INTO `detail_transaksi` (`id`, `transaksi_id`, `produk_id`, `qty`, `subtotal`) VALUES
(1, 1, 2, 3, 15000.00),
(2, 2, 3, 3, 36000.00),
(3, 3, 1, 2, 30000.00),
(4, 4, 2, 1, 5000.00),
(5, 5, 1, 3, 45000.00),
(6, 6, 1, 1, 15000.00),
(7, 6, 2, 2, 10000.00),
(8, 7, 3, 3, 36000.00),
(9, 7, 2, 3, 15000.00),
(10, 8, 1, 3, 45000.00),
(11, 9, 6, 0, 0.00),
(12, 9, 8, 0, 0.00),
(13, 10, 1, 0, 0.00),
(14, 10, 2, 0, 0.00),
(15, 11, 1, 1, 15000.00),
(16, 11, 2, 1, 5000.00),
(17, 12, 1, 1, 15000.00),
(18, 12, 3, 2, 24000.00);

-- --------------------------------------------------------

--
-- Table structure for table `produk`
--

CREATE TABLE `produk` (
  `id` int(11) NOT NULL,
  `nama` varchar(100) DEFAULT NULL,
  `harga` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `produk`
--

INSERT INTO `produk` (`id`, `nama`, `harga`) VALUES
(1, 'Nasi Goreng', 15000.00),
(2, 'Es Teh', 5000.00),
(3, 'Mie Goreng', 12000.00),
(4, 'Mie Rebus', 12000.00),
(5, 'Roti Bakar', 10000.00),
(6, 'Pisang Manis', 10000.00),
(7, 'Taichan', 15000.00),
(8, 'Pancong', 10000.00),
(9, 'Nutri Sari', 8000.00),
(10, 'Bir Pletok', 13000.00);

-- --------------------------------------------------------

--
-- Table structure for table `transaksi`
--

CREATE TABLE `transaksi` (
  `id` int(11) NOT NULL,
  `tanggal` datetime DEFAULT NULL,
  `total` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `transaksi`
--

INSERT INTO `transaksi` (`id`, `tanggal`, `total`) VALUES
(1, '2025-05-27 21:27:13', 15000.00),
(2, '2025-05-27 21:30:35', 36000.00),
(3, '2025-06-02 11:56:11', 30000.00),
(4, '2025-06-02 11:58:09', 5000.00),
(5, '2025-06-02 11:59:17', 45000.00),
(6, '2025-06-02 12:20:56', 25000.00),
(7, '2025-06-02 13:14:28', 51000.00),
(8, '2025-06-02 13:33:05', 45000.00),
(9, '2025-06-13 19:21:40', 0.00),
(10, '2025-06-13 19:25:26', 0.00),
(11, '2025-06-13 19:28:04', 20000.00),
(12, '2025-06-13 19:36:15', 39000.00);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `detail_transaksi`
--
ALTER TABLE `detail_transaksi`
  ADD PRIMARY KEY (`id`),
  ADD KEY `transaksi_id` (`transaksi_id`),
  ADD KEY `produk_id` (`produk_id`);

--
-- Indexes for table `produk`
--
ALTER TABLE `produk`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `detail_transaksi`
--
ALTER TABLE `detail_transaksi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `produk`
--
ALTER TABLE `produk`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `transaksi`
--
ALTER TABLE `transaksi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `detail_transaksi`
--
ALTER TABLE `detail_transaksi`
  ADD CONSTRAINT `detail_transaksi_ibfk_1` FOREIGN KEY (`transaksi_id`) REFERENCES `transaksi` (`id`),
  ADD CONSTRAINT `detail_transaksi_ibfk_2` FOREIGN KEY (`produk_id`) REFERENCES `produk` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
