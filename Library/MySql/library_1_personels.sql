-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: localhost    Database: library_1
-- ------------------------------------------------------
-- Server version	8.0.32

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `personels`
--

DROP TABLE IF EXISTS `personels`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `personels` (
  `personel_id` int NOT NULL AUTO_INCREMENT,
  `personel_name` varchar(45) NOT NULL,
  `personel_surname` varchar(45) NOT NULL,
  `personel_birthday` datetime NOT NULL,
  `personel_gender` tinytext NOT NULL,
  `personel_number` varchar(11) NOT NULL,
  `personel_address` varchar(200) NOT NULL,
  `personel_mail` varchar(45) NOT NULL,
  `job_id` int NOT NULL,
  `personel_start_day` datetime NOT NULL,
  `personelname` varchar(45) NOT NULL,
  `personel_password` varchar(20) NOT NULL,
  `personel_update` datetime DEFAULT NULL,
  PRIMARY KEY (`personel_id`),
  UNIQUE KEY `personelname_UNIQUE` (`personelname`),
  UNIQUE KEY `personel_password_UNIQUE` (`personel_password`),
  UNIQUE KEY `personel_number_UNIQUE` (`personel_number`),
  KEY `fk_jobid` (`job_id`),
  CONSTRAINT `fk_jobid` FOREIGN KEY (`job_id`) REFERENCES `jobs` (`job_id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personels`
--

LOCK TABLES `personels` WRITE;
/*!40000 ALTER TABLE `personels` DISABLE KEYS */;
INSERT INTO `personels` VALUES (1,'Derya','Gevrek','2002-02-12 00:00:00','Kadın','05234567543','Kocaeli Gebze','deryagevrek@gmail.com',1,'2023-05-26 00:00:00','derya','1111',NULL),(2,'Edanur','Kuru','2003-06-27 12:12:12','Kadın','05432345456','Sakarya Adapazarı','kuruogluedanur@gmail.com',2,'2020-12-01 12:12:12','edanur1','9999',NULL),(3,'Sezen','Aksu','1988-12-07 17:56:54','Kadın','05675646788','İstanbul','sezenaksu@gmail.com',3,'2023-05-02 00:00:00','sezenaksu340','34sezenaksu34','2023-06-03 17:32:24'),(9,'Hatice','Seher','2000-10-18 12:06:04','Kadın','6572323455','Adana','seherhatice45@gmail.com',7,'2023-04-26 00:00:00','seherhatice45','hatice45seher',NULL),(11,'Sarenur','Koral','2000-02-02 19:24:49','Kadın','5656676756','Kırşehir','koralsarenur567@gmail.com',8,'2019-03-13 00:00:00','sarenur45','45sarenur56',NULL),(12,'Vahide','Sultan','2000-02-09 10:49:53','Kadın','5423245213','Sakarya Karasu','sultanvahide@gmail.com',2,'2020-02-04 00:00:00','sultanvahid87588','75vahide',NULL),(14,'Edanur','Seher','1989-06-20 21:13:00','Kadın','05345666767','Siirt','seheredanur@gmail.com',6,'2023-04-25 00:00:00','eda','2222',NULL),(16,'Salkım','Gündüz','2000-02-02 19:38:58','Kadın','05094094895','Manisa','gunduzsalkim67@gmail.com',6,'2022-12-27 00:00:00','salkımgündüzz54g','45ftg55',NULL),(17,'Salkım ','Korel','1990-06-14 20:04:16','Kadın','04563242354','Denizli','korelsalkim@gmail.com',6,'2022-12-26 00:00:00','salkimkorell56','546fgdfsd',NULL);
/*!40000 ALTER TABLE `personels` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-17 14:36:28
