-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 03, 2025 at 09:27 AM
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
-- Database: `enrollmentsystemdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblay`
--

CREATE TABLE `tblay` (
  `AYcode` varchar(50) NOT NULL,
  `status` varchar(50) NOT NULL DEFAULT 'Open'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblay`
--

INSERT INTO `tblay` (`AYcode`, `status`) VALUES
('2021-2022', 'Close'),
('2022-2023', 'Close'),
('2023-2024', 'Open'),
('2024-2025', 'Close');

-- --------------------------------------------------------

--
-- Table structure for table `tblbilling`
--

CREATE TABLE `tblbilling` (
  `id` int(11) NOT NULL,
  `enrollmentid` int(11) DEFAULT NULL,
  `feesid` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblbilling`
--

INSERT INTO `tblbilling` (`id`, `enrollmentid`, `feesid`) VALUES
(1, 4, 2),
(2, 4, 3),
(3, 4, 4),
(4, 1, 2),
(5, 1, 3),
(6, 1, 4),
(7, 2, 2),
(8, 2, 3),
(9, 2, 4),
(10, 5, 2),
(11, 5, 3),
(12, 5, 4),
(13, 6, 2),
(14, 6, 3),
(15, 6, 4),
(16, 6, 5),
(17, 9, 3);

-- --------------------------------------------------------

--
-- Table structure for table `tblcourse`
--

CREATE TABLE `tblcourse` (
  `id` int(11) NOT NULL,
  `course` varchar(50) NOT NULL,
  `year` varchar(50) NOT NULL,
  `adviserid` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblcourse`
--

INSERT INTO `tblcourse` (`id`, `course`, `year`, `adviserid`) VALUES
(1, 'KYOTIPATOTI', '12th Grade', '24-1-8834'),
(2, 'ASTIG-TO', '7th Grade', '23-1-0764'),
(4, 'YOBMOT-1A', '12th Grade', '25-1-0001'),
(5, 'POGI ONLY', '9th Grade', '24-1-8835');

-- --------------------------------------------------------

--
-- Table structure for table `tblenrollment`
--

CREATE TABLE `tblenrollment` (
  `enrollmentid` int(11) NOT NULL,
  `lrn` varchar(50) NOT NULL,
  `courseid` int(11) NOT NULL,
  `AYcode` varchar(50) NOT NULL,
  `enrolldate` date NOT NULL,
  `status` varchar(50) NOT NULL DEFAULT 'Enrolled'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblenrollment`
--

INSERT INTO `tblenrollment` (`enrollmentid`, `lrn`, `courseid`, `AYcode`, `enrolldate`, `status`) VALUES
(1, '12434232', 2, '2023-2024', '2025-05-25', 'Enrolled'),
(2, '9271397', 4, '2023-2024', '2025-05-26', 'Enrolled'),
(3, '96945324', 1, '2021-2022', '2025-05-26', 'Dropped'),
(4, '13254687', 4, '2022-2023', '2025-05-27', 'Enrolled'),
(5, '12434232', 4, '2022-2023', '2025-05-30', 'Enrolled'),
(6, '96945324', 1, '2024-2025', '2025-05-30', 'Enrolled'),
(7, '213897124', 2, '2024-2025', '2025-05-30', 'Enrolled'),
(8, '9271397', 5, '2024-2025', '2025-05-30', 'Enrolled'),
(9, '3429053', 2, '2023-2024', '2025-06-01', 'Enrolled');

-- --------------------------------------------------------

--
-- Table structure for table `tblfees`
--

CREATE TABLE `tblfees` (
  `id` int(11) NOT NULL,
  `fees` varchar(50) NOT NULL,
  `amount` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `tblfees`
--

INSERT INTO `tblfees` (`id`, `fees`, `amount`) VALUES
(2, 'Laboratory', 9000.00),
(3, 'Tuition', 10000.00),
(4, 'Misc', 2500.00),
(5, 'Uniform', 900.00);

-- --------------------------------------------------------

--
-- Table structure for table `tblpayment`
--

CREATE TABLE `tblpayment` (
  `id` int(11) NOT NULL,
  `pdate` date NOT NULL,
  `enrollmentid` int(11) NOT NULL,
  `amount` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblpayment`
--

INSERT INTO `tblpayment` (`id`, `pdate`, `enrollmentid`, `amount`) VALUES
(2, '2025-05-30', 5, 5000.00),
(3, '2025-05-30', 2, 2500.00),
(6, '2025-05-30', 6, 5000.00),
(7, '2025-06-01', 9, 5000.00);

-- --------------------------------------------------------

--
-- Table structure for table `tblstudent`
--

CREATE TABLE `tblstudent` (
  `lrn` varchar(50) NOT NULL,
  `lname` varchar(50) NOT NULL,
  `fname` varchar(50) NOT NULL,
  `mname` varchar(50) NOT NULL,
  `address` text NOT NULL,
  `bdate` date NOT NULL,
  `age` int(11) NOT NULL,
  `father` varchar(50) NOT NULL,
  `father_occupation` varchar(50) NOT NULL,
  `mother` varchar(50) NOT NULL,
  `mother_occupation` varchar(50) NOT NULL,
  `status` varchar(50) NOT NULL DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblstudent`
--

INSERT INTO `tblstudent` (`lrn`, `lname`, `fname`, `mname`, `address`, `bdate`, `age`, `father`, `father_occupation`, `mother`, `mother_occupation`, `status`) VALUES
('12434232', 'Garcia', 'Hans', ' Pogi', 'Dalahican, Roxas, Oriental Mindoro', '2003-08-06', 22, 'Willie Garcia', 'Pool Manager', 'd ko alam', 'OFW', 'Active'),
('213897124', 'Solanoy', 'Patricia Mae', 'Panget', 'Mansalay', '2004-06-16', 21, 'asdf', 'asdf', 'asdfasdf', 'asdf', 'Active'),
('3429053', 'Fontanilla', 'Ryan Mikhael', 'Viduya', 'Macatoc, Victoria, Oriental Mindoro', '2003-02-27', 23, 'Cromwell M. Fontanilla', 'OFW', 'Menchu T. Viduya', 'Teacher', 'Active'),
('9271397', 'Gutierrez', 'Jarinyes Dexcem', 'T', 'Odiong, Roxas, Oriental Mindoro', '2004-02-05', 22, 'Pogi Gutierrez', 'Driver', 'Ganda Gutierrez', 'Teacher', 'Active'),
('96945324', 'Lomboy', 'Margarette', 'Faye', 'San Aquilino, Roxas, Oriental Mindoro', '2005-06-15', 20, 'Pogi Lomboy', 'Welder', 'Ganda Lomboy', 'OFW', 'Active');

-- --------------------------------------------------------

--
-- Table structure for table `tblteacher`
--

CREATE TABLE `tblteacher` (
  `teacherId` varchar(50) NOT NULL,
  `lname` varchar(50) NOT NULL,
  `fname` varchar(50) NOT NULL,
  `mname` varchar(50) NOT NULL,
  `contact` varchar(50) NOT NULL,
  `address` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblteacher`
--

INSERT INTO `tblteacher` (`teacherId`, `lname`, `fname`, `mname`, `contact`, `address`, `email`) VALUES
('23-1-0764', 'Fontanilla', 'Charles Ivan ', 'Viduya', '09166232739', 'San Mariano, Roxas, Oriental Mindoro', 'charlesivanfontanilla04@gmail.com'),
('23-1-1432', 'Albino', 'Sherly', 'asdf', '0938431342', 'San Aquilino', 'SherlyZ.gandits@gmail.com'),
('24-1-8834', 'Escalona', 'Lhean Joyce', 'Belarmino', '09886271684', 'San Roque, Bulalacao, Oriental Mindoro', 'lhean.ngetpa@gmail.com'),
('24-1-8835', 'Andres', 'Rejean', 'Malla', '09926741990', 'Sabang, Caluya, Antique', 'itsRejeanMen.98@gmail.com'),
('25-1-0001', 'Sansano', 'Reign Aryana', 'Fontanilla', '09921091276', 'Macatoc, Victoria, Oriental Mindoro', 'REigNzz@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `tbluser`
--

CREATE TABLE `tbluser` (
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `name` varchar(50) NOT NULL,
  `role` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Stand-in structure for view `vwbilling`
-- (See below for the actual view)
--
CREATE TABLE `vwbilling` (
`enrollmentid` int(11)
,`lrn` varchar(50)
,`student` varchar(153)
,`course` varchar(50)
,`year` varchar(50)
,`AYcode` varchar(50)
,`amount` decimal(32,2)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `vwcourse`
-- (See below for the actual view)
--
CREATE TABLE `vwcourse` (
`id` int(11)
,`course` varchar(50)
,`year` varchar(50)
,`adviserid` varchar(50)
,`adviser` varchar(153)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `vwenrollment`
-- (See below for the actual view)
--
CREATE TABLE `vwenrollment` (
`enrollmentid` int(11)
,`lrn` varchar(50)
,`student` varchar(153)
,`course` varchar(50)
,`year` varchar(50)
,`adviserid` varchar(50)
,`adviser` varchar(153)
,`AYcode` varchar(50)
,`enrolldate` date
,`status` varchar(50)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `vwpayment`
-- (See below for the actual view)
--
CREATE TABLE `vwpayment` (
`id` int(11)
,`pdate` date
,`enrollmentid` int(11)
,`lrn` varchar(50)
,`student` varchar(153)
,`year` varchar(50)
,`course` varchar(50)
,`amount` decimal(10,2)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `vwtotalpayment`
-- (See below for the actual view)
--
CREATE TABLE `vwtotalpayment` (
`enrollmentid` int(11)
,`total` decimal(32,2)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `vwtuition`
-- (See below for the actual view)
--
CREATE TABLE `vwtuition` (
`id` int(11)
,`enrollmentid` int(11)
,`feesid` int(11)
,`fees` varchar(50)
,`amount` decimal(10,2)
);

-- --------------------------------------------------------

--
-- Structure for view `vwbilling`
--
DROP TABLE IF EXISTS `vwbilling`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vwbilling`  AS SELECT `e`.`enrollmentid` AS `enrollmentid`, `e`.`lrn` AS `lrn`, `e`.`student` AS `student`, `e`.`course` AS `course`, `e`.`year` AS `year`, `e`.`AYcode` AS `AYcode`, ifnull(sum(`t`.`amount`),0) AS `amount` FROM (`vwenrollment` `e` left join `vwtuition` `t` on(`e`.`enrollmentid` = `t`.`enrollmentid`)) WHERE `e`.`status` like 'Enrolled' GROUP BY `e`.`lrn`, `e`.`AYcode` ;

-- --------------------------------------------------------

--
-- Structure for view `vwcourse`
--
DROP TABLE IF EXISTS `vwcourse`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vwcourse`  AS SELECT `s`.`id` AS `id`, `s`.`course` AS `course`, `s`.`year` AS `year`, `s`.`adviserid` AS `adviserid`, concat(`t`.`lname`,', ',`t`.`fname`,' ',`t`.`mname`) AS `adviser` FROM (`tblcourse` `s` join `tblteacher` `t` on(`t`.`teacherId` = `s`.`adviserid`)) ORDER BY `s`.`year` ASC, `s`.`course` ASC ;

-- --------------------------------------------------------

--
-- Structure for view `vwenrollment`
--
DROP TABLE IF EXISTS `vwenrollment`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vwenrollment`  AS SELECT `e`.`enrollmentid` AS `enrollmentid`, `e`.`lrn` AS `lrn`, concat(`s`.`lname`,', ',`s`.`fname`,' ',`s`.`mname`) AS `student`, `sec`.`course` AS `course`, `sec`.`year` AS `year`, `sec`.`adviserid` AS `adviserid`, `sec`.`adviser` AS `adviser`, `e`.`AYcode` AS `AYcode`, `e`.`enrolldate` AS `enrolldate`, `e`.`status` AS `status` FROM ((`tblenrollment` `e` join `tblstudent` `s` on(`s`.`lrn` = `e`.`lrn`)) join `vwcourse` `sec` on(`sec`.`id` = `e`.`courseid`)) ;

-- --------------------------------------------------------

--
-- Structure for view `vwpayment`
--
DROP TABLE IF EXISTS `vwpayment`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vwpayment`  AS SELECT `p`.`id` AS `id`, `p`.`pdate` AS `pdate`, `p`.`enrollmentid` AS `enrollmentid`, `v`.`lrn` AS `lrn`, `v`.`student` AS `student`, `v`.`year` AS `year`, `v`.`course` AS `course`, `p`.`amount` AS `amount` FROM (`tblpayment` `p` join `vwenrollment` `v` on(`v`.`enrollmentid` = `p`.`enrollmentid`)) ;

-- --------------------------------------------------------

--
-- Structure for view `vwtotalpayment`
--
DROP TABLE IF EXISTS `vwtotalpayment`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vwtotalpayment`  AS SELECT `tblpayment`.`enrollmentid` AS `enrollmentid`, ifnull(sum(`tblpayment`.`amount`),0) AS `total` FROM `tblpayment` GROUP BY `tblpayment`.`enrollmentid` ;

-- --------------------------------------------------------

--
-- Structure for view `vwtuition`
--
DROP TABLE IF EXISTS `vwtuition`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vwtuition`  AS SELECT `b`.`id` AS `id`, `b`.`enrollmentid` AS `enrollmentid`, `b`.`feesid` AS `feesid`, `f`.`fees` AS `fees`, `f`.`amount` AS `amount` FROM (`tblbilling` `b` join `tblfees` `f` on(`f`.`id` = `b`.`feesid`)) ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblay`
--
ALTER TABLE `tblay`
  ADD PRIMARY KEY (`AYcode`);

--
-- Indexes for table `tblbilling`
--
ALTER TABLE `tblbilling`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblcourse`
--
ALTER TABLE `tblcourse`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblenrollment`
--
ALTER TABLE `tblenrollment`
  ADD PRIMARY KEY (`enrollmentid`);

--
-- Indexes for table `tblfees`
--
ALTER TABLE `tblfees`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `fees` (`fees`);

--
-- Indexes for table `tblpayment`
--
ALTER TABLE `tblpayment`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblstudent`
--
ALTER TABLE `tblstudent`
  ADD PRIMARY KEY (`lrn`);

--
-- Indexes for table `tblteacher`
--
ALTER TABLE `tblteacher`
  ADD PRIMARY KEY (`teacherId`);

--
-- Indexes for table `tbluser`
--
ALTER TABLE `tbluser`
  ADD PRIMARY KEY (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblbilling`
--
ALTER TABLE `tblbilling`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `tblcourse`
--
ALTER TABLE `tblcourse`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tblenrollment`
--
ALTER TABLE `tblenrollment`
  MODIFY `enrollmentid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tblfees`
--
ALTER TABLE `tblfees`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tblpayment`
--
ALTER TABLE `tblpayment`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
