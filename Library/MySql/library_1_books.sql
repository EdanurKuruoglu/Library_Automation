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
-- Table structure for table `books`
--

DROP TABLE IF EXISTS `books`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `books` (
  `book_ISBN` varchar(13) NOT NULL,
  `book_name` varchar(45) NOT NULL,
  `author_id` int NOT NULL,
  `genre_id` int NOT NULL,
  `book_page` int NOT NULL,
  `book_publication_year` datetime NOT NULL,
  `publisher_id` int NOT NULL,
  `book_number` int NOT NULL,
  `language_id` int NOT NULL,
  `book_update` datetime DEFAULT NULL,
  PRIMARY KEY (`book_ISBN`),
  KEY `fk_authorid` (`author_id`),
  KEY `fk_genreid` (`genre_id`),
  KEY `fk_publisherid` (`publisher_id`),
  KEY `fk_languageid` (`language_id`),
  KEY `idx_book_name` (`book_name`),
  CONSTRAINT `fk_authorid` FOREIGN KEY (`author_id`) REFERENCES `authors` (`author_id`),
  CONSTRAINT `fk_genreid` FOREIGN KEY (`genre_id`) REFERENCES `genres` (`genre_id`),
  CONSTRAINT `fk_languageid` FOREIGN KEY (`language_id`) REFERENCES `languages` (`language_id`),
  CONSTRAINT `fk_publisheRid` FOREIGN KEY (`publisher_id`) REFERENCES `publishers` (`publisher_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `books`
--

LOCK TABLES `books` WRITE;
/*!40000 ALTER TABLE `books` DISABLE KEYS */;
INSERT INTO `books` VALUES ('5676575467654','Bi İdam mahkumunun Son Günü',2,1,120,'2020-01-07 00:00:00',1,11,1,'2023-06-07 10:03:30'),('9780500295833','How to Understand Art',5,9,309,'2023-02-01 00:00:00',8,5,2,NULL),('9789750726439','Simyacı',7,1,188,'2019-01-01 00:00:00',4,6,1,NULL),('9789750739606','İnsancıklar',1,1,97,'2020-02-05 00:00:00',1,0,1,NULL),('9789753638029','Kürk Mantolu Madonna',3,1,180,'2013-02-06 00:00:00',6,9,1,'2023-06-03 21:45:33'),('9789756391471','Öteki',1,1,123,'2014-06-11 00:00:00',1,0,1,NULL),('9789944883146','Ezilenler',1,1,344,'2020-02-12 00:00:00',1,5,1,NULL);
/*!40000 ALTER TABLE `books` ENABLE KEYS */;
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
