-- MariaDB dump 10.19  Distrib 10.4.32-MariaDB, for Win64 (AMD64)
--
-- Host: evolto4.ddns.net    Database: penguinferryjasa
-- ------------------------------------------------------
-- Server version	5.6.51

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `loading_data`
--

DROP TABLE IF EXISTS `loading_data`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `loading_data` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `vessel` varchar(30) NOT NULL,
  `team_supervisor` varchar(30) NOT NULL,
  `start_loading_time` int(11) NOT NULL,
  `finish_loading_time` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `created_at` int(11) DEFAULT NULL,
  `deleted_at` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `loading_data`
--

LOCK TABLES `loading_data` WRITE;
/*!40000 ALTER TABLE `loading_data` DISABLE KEYS */;
/*!40000 ALTER TABLE `loading_data` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ship_data`
--

DROP TABLE IF EXISTS `ship_data`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ship_data` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `date` int(11) NOT NULL,
  `vessel` varchar(30) NOT NULL,
  `captain` varchar(30) NOT NULL,
  `estimate_arrival_time` int(11) NOT NULL,
  `actual_arrival_time` int(11) NOT NULL,
  `package_import_quantity` varchar(30) NOT NULL,
  `voyage_number` int(11) NOT NULL,
  `estimate_departure_time` int(11) NOT NULL,
  `actual_departure_time` int(11) NOT NULL,
  `package_export_quantity` int(11) NOT NULL,
  `created_at` int(11) NOT NULL,
  `deleted_at` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ship_data`
--

LOCK TABLES `ship_data` WRITE;
/*!40000 ALTER TABLE `ship_data` DISABLE KEYS */;
/*!40000 ALTER TABLE `ship_data` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `unloading_data`
--

DROP TABLE IF EXISTS `unloading_data`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `unloading_data` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `vessel` varchar(30) NOT NULL,
  `team_supervisor` varchar(30) NOT NULL,
  `start_unloading_time` int(11) NOT NULL,
  `finish_unloading_time` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `created_at` int(11) DEFAULT NULL,
  `deleted_at` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `unloading_data`
--

LOCK TABLES `unloading_data` WRITE;
/*!40000 ALTER TABLE `unloading_data` DISABLE KEYS */;
/*!40000 ALTER TABLE `unloading_data` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-06-21 18:33:19
