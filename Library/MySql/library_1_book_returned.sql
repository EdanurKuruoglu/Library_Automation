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
-- Table structure for table `book_returned`
--

DROP TABLE IF EXISTS `book_returned`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `book_returned` (
  `borrowing_id` int NOT NULL DEFAULT '0',
  `user_id` int NOT NULL,
  `user_name` varchar(45) NOT NULL,
  `user_surname` varchar(45) NOT NULL,
  `book_name` varchar(45) NOT NULL,
  `book_ISBN` varchar(13) NOT NULL,
  `book_lending_date` datetime NOT NULL,
  `book_due_date` datetime NOT NULL,
  `borrowing_state` char(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `book_returned`
--

LOCK TABLES `book_returned` WRITE;
/*!40000 ALTER TABLE `book_returned` DISABLE KEYS */;
INSERT INTO `book_returned` VALUES (25,9,'Hülya','Yoldaşçı','Ezilenler','9789944883146','2023-06-07 09:50:34','2023-06-07 09:50:34','Evet'),(28,7,'Seher','Korkmaz','Bi İdam mahkumunun Son Günü','5676575467654','2023-06-07 09:56:07','2023-06-21 09:56:06','Evet'),(26,7,'Seher','Korkmaz','Bi İdam mahkumunun Son Günü','5676575467654','2023-06-07 09:52:06','2023-06-07 09:52:06','Evet'),(34,1,'Edanur','Kuruoğlu','Bi İdam mahkumunun Son Günü','5676575467654','2023-06-07 10:09:04','2023-06-07 10:09:04','Evet'),(30,6,'Selin','Karaca','Bi İdam mahkumunun Son Günü','5676575467654','2023-06-07 09:56:46','2023-06-07 09:56:46','Evet'),(36,6,'Selin','Karaca','Ezilenler','9789944883146','2023-06-07 10:12:08','2023-06-07 10:12:08','2'),(37,7,'Seher','Korkmaz','Bi İdam mahkumunun Son Günü','5676575467654','2023-06-07 10:13:09','2023-06-07 10:13:09','Evet'),(38,3,'Ali','Kar','Bi İdam mahkumunun Son Günü','5676575467654','2023-06-07 10:19:22','2023-06-07 10:19:22','Evet'),(39,3,'Ali','Kar','Bi İdam mahkumunun Son Günü','5676575467654','2023-06-07 10:19:22','2023-06-07 10:19:22','Evet'),(55,9,'Hülya','Yoldaşçı','Bi İdam mahkumunun Son Günü','5676575467654','2023-06-07 12:31:05','2023-06-07 12:31:05','Evet'),(56,6,'Selin','Karaca','Kürk Mantolu Madonna','9789753638029','2023-06-08 22:11:03','2023-06-07 22:11:03','Evet'),(58,10,'Elif ','Ersan','Ezilenler','9789944883146','2023-05-29 22:41:32','2023-06-06 22:41:32','4'),(7,20,'Heidi','Karaca','Kürk Mantolu Madonna','9789753638029','2023-06-08 22:46:56','2023-06-08 22:46:56','0'),(57,3,'Ali','Kar','Ezilenler','9789944883146','2023-06-08 22:13:20','2023-06-06 22:13:19','Evet'),(57,3,'Ali','Kar','Ezilenler','9789944883146','2023-06-08 22:13:20','2023-06-06 22:13:19','Evet'),(9,9,'Hülya','Yoldaşçı','Bi İdam mahkumunun Son Günü','5676575467654','2023-06-02 22:48:50','2023-06-06 22:48:50','Evet'),(9,9,'Hülya','Yoldaşçı','Bi İdam mahkumunun Son Günü','5676575467654','2023-06-02 22:48:50','2023-06-06 22:48:50','Evet'),(8,20,'Heidi','Karaca','Ezilenler','9789944883146','2023-06-08 22:46:56','2023-06-06 22:46:55','Evet'),(1,6,'Selin','Karaca','Kürk Mantolu Madonna','9789753638029','2023-06-08 22:11:03','2023-06-07 22:11:03','Evet'),(2,3,'Ali','Kar','Ezilenler','9789944883146','2023-06-08 22:13:20','2023-06-06 22:13:19','Evet'),(29,1,'Edanur','Kuruoğlu','Bi İdam mahkumunun Son Günü','5676575467654','2023-06-07 09:56:07','2023-06-21 09:56:06','Evet'),(1,6,'Selin','Karaca','Kürk Mantolu Madonna','9789753638029','2023-06-08 22:11:03','2023-06-07 22:11:03','Evet'),(66,41,'Ekrem','Şan','Bi İdam mahkumunun Son Günü','5676575467654','2023-06-13 10:19:09','2023-06-13 10:19:09','Evet'),(8,20,'Heidi','Karaca','Ezilenler','9789944883146','2023-06-08 22:46:56','2023-06-06 22:46:55','Evet');
/*!40000 ALTER TABLE `book_returned` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-17 14:36:29
