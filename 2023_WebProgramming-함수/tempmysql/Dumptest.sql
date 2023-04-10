-- MariaDB dump 10.19  Distrib 10.4.25-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: test
-- ------------------------------------------------------
-- Server version	10.4.25-MariaDB

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
-- Table structure for table `hak`
--

DROP TABLE IF EXISTS `hak`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hak` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `hak_no` char(4) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `hak_addr` char(3) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hak`
--

LOCK TABLES `hak` WRITE;
/*!40000 ALTER TABLE `hak` DISABLE KEYS */;
INSERT INTO `hak` VALUES (1,'1001','aaa'),(2,'1002','bbb');
/*!40000 ALTER TABLE `hak` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jumsu`
--

DROP TABLE IF EXISTS `jumsu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `jumsu` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `jum_no` char(4) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `jum_name` char(10) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `jum_kor` int(11) DEFAULT NULL,
  `jum_eng` int(11) DEFAULT NULL,
  `jum_mat` int(11) DEFAULT NULL,
  `jum_birthday` date DEFAULT NULL,
  `jum_class` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jumsu`
--

LOCK TABLES `jumsu` WRITE;
/*!40000 ALTER TABLE `jumsu` DISABLE KEYS */;
INSERT INTO `jumsu` VALUES (1,'1001','홍길동',99,99,99,NULL,1),(2,'1002','김유신',88,78,78,NULL,1),(3,'1003','강감찬',69,45,99,NULL,2),(4,'1004','장보고',49,100,88,NULL,2),(5,'1005','홍길자',100,100,88,NULL,2),(6,'1001','홍길동',99,99,99,NULL,1);
/*!40000 ALTER TABLE `jumsu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `list`
--

DROP TABLE IF EXISTS `list`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `list` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` char(4) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `address` char(10) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `t_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `list`
--

LOCK TABLES `list` WRITE;
/*!40000 ALTER TABLE `list` DISABLE KEYS */;
INSERT INTO `list` VALUES (1,'홍길동','사창동',0),(2,'김유신','분평동',0),(3,'강감찬','사직동',1),(4,'장보고','용암동',1),(5,'김길동','개신동',2);
/*!40000 ALTER TABLE `list` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `score2`
--

DROP TABLE IF EXISTS `score2`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `score2` (
  `id` int(11) NOT NULL,
  `score` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `score2`
--

LOCK TABLES `score2` WRITE;
/*!40000 ALTER TABLE `score2` DISABLE KEYS */;
INSERT INTO `score2` VALUES (3,99),(4,88),(5,100),(7,100);
/*!40000 ALTER TABLE `score2` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-03-30 15:24:26
