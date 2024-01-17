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
-- Table structure for table `book_delivery`
--

DROP TABLE IF EXISTS `book_delivery`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `book_delivery` (
  `borrowing_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `user_name` varchar(45) NOT NULL,
  `user_surname` varchar(45) NOT NULL,
  `book_name` varchar(45) NOT NULL,
  `book_ISBN` varchar(13) NOT NULL,
  `book_lending_date` datetime NOT NULL,
  `book_due_date` datetime NOT NULL,
  `borrowing_state` varchar(15) NOT NULL,
  `penalty` int NOT NULL,
  PRIMARY KEY (`borrowing_id`)
) ENGINE=InnoDB AUTO_INCREMENT=72 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `book_delivery`
--

LOCK TABLES `book_delivery` WRITE;
/*!40000 ALTER TABLE `book_delivery` DISABLE KEYS */;
INSERT INTO `book_delivery` VALUES (1,6,'Selin','Karaca','Kürk Mantolu Madonna','9789753638029','2023-06-08 22:11:03','2023-06-07 22:11:03','Evet',0),(2,3,'Ali','Kar','Ezilenler','9789944883146','2023-06-08 22:13:20','2023-06-06 22:13:19','Evet',0),(3,10,'Elif ','Ersan','Ezilenler','9789944883146','2023-05-29 22:41:32','2023-06-06 22:41:32','Evet',0),(7,20,'Heidi','Karaca','Kürk Mantolu Madonna','9789753638029','2023-06-08 22:46:56','2023-06-08 22:46:56','Evet',0),(8,20,'Heidi','Karaca','Ezilenler','9789944883146','2023-06-08 22:46:56','2023-06-06 22:46:55','Evet',0),(9,9,'Hülya','Yoldaşçı','Bi İdam mahkumunun Son Günü','5676575467654','2023-06-02 22:48:50','2023-06-06 22:48:50','Evet',0),(57,3,'Ali','Kar','Ezilenler','9789944883146','2023-06-08 22:13:20','2023-06-06 22:13:19','Evet',4),(58,10,'Elif ','Ersan','Ezilenler','9789944883146','2023-05-29 22:41:32','2023-06-06 22:41:32','Evet',4),(59,20,'Heidi','Karaca','Kürk Mantolu Madonna','9789753638029','2023-06-08 22:46:56','2023-06-08 22:46:56','Evet',4),(60,20,'Heidi','Karaca','Ezilenler','9789944883146','2023-06-08 22:46:56','2023-06-06 22:46:55','Evet',4),(61,9,'Hülya','Yoldaşçı','Bi İdam mahkumunun Son Günü','5676575467654','2023-06-02 22:48:50','2023-06-06 22:48:50','Evet',4),(62,8,'Mustafa','Manavlı','İnsancıklar','9789750739606','2023-05-29 23:01:17','2023-06-06 23:01:17','Evet',4),(63,7,'Seher','Korkmaz','How to Understand Art','9780500295833','2023-06-12 21:12:14','2023-06-19 21:12:13','Evet',168),(65,20,'Heidi','Karaca','Bi İdam mahkumunun Son Günü','5676575467654','2023-06-13 10:19:09','2023-06-13 10:19:09','Evet',180),(66,41,'Ekrem','Şan','Bi İdam mahkumunun Son Günü','5676575467654','2023-06-13 10:19:09','2023-06-13 10:19:09','Evet',180),(67,3,'Ali','Kar','Bi İdam mahkumunun Son Günü','5676575467654','2023-09-11 21:10:18','2023-09-11 21:10:18','Evet',6),(68,1,'Edanur','Kuruoğlu','Kürk Mantolu Madonna','9789753638029','2023-09-14 14:11:35','2023-09-14 14:11:35','Evet',4),(69,1,'Edanur','Kuruoğlu','Simyacı','9789750726439','2023-09-14 14:11:59','2023-09-21 14:11:59','Evet',0),(70,1,'Edanur','Kuruoğlu','Ezilenler','9789944883146','2023-09-14 15:03:03','2023-09-14 15:03:03','Evet',4),(71,1,'Edanur','Kuruoğlu','How to Understand Art','9780500295833','2023-09-07 15:03:03','2023-09-13 15:03:03','Evet',2);
/*!40000 ALTER TABLE `book_delivery` ENABLE KEYS */;
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
