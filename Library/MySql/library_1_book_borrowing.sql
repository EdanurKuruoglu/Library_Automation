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
-- Table structure for table `book_borrowing`
--

DROP TABLE IF EXISTS `book_borrowing`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `book_borrowing` (
  `borrowing_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `user_name` varchar(45) NOT NULL,
  `user_surname` varchar(45) NOT NULL,
  `book_name` varchar(45) NOT NULL,
  `book_ISBN` varchar(13) NOT NULL,
  `book_lending_date` datetime NOT NULL,
  `book_due_date` datetime NOT NULL,
  `borrowing_state` char(15) DEFAULT NULL,
  `penalty` int NOT NULL,
  PRIMARY KEY (`borrowing_id`),
  KEY `fk_books_username_idx` (`user_name`),
  KEY `fk_books_user_surname` (`user_surname`),
  KEY `fk_books_name` (`book_name`),
  KEY `fk_books_isbn` (`book_ISBN`),
  KEY `fk__books_users_id` (`user_id`),
  KEY `idx_book_lending_date` (`book_lending_date`),
  KEY `idx_book_due_date` (`book_due_date`),
  KEY `idx_borrowing_state` (`borrowing_state`),
  CONSTRAINT `fk__books_users_id` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`),
  CONSTRAINT `fk_books_isbn` FOREIGN KEY (`book_ISBN`) REFERENCES `books` (`book_ISBN`),
  CONSTRAINT `fk_books_name` FOREIGN KEY (`book_name`) REFERENCES `books` (`book_name`),
  CONSTRAINT `fk_books_user_name` FOREIGN KEY (`user_name`) REFERENCES `users` (`user_name`),
  CONSTRAINT `fk_books_user_surname` FOREIGN KEY (`user_surname`) REFERENCES `users` (`user_surname`)
) ENGINE=InnoDB AUTO_INCREMENT=72 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `book_borrowing`
--

LOCK TABLES `book_borrowing` WRITE;
/*!40000 ALTER TABLE `book_borrowing` DISABLE KEYS */;
/*!40000 ALTER TABLE `book_borrowing` ENABLE KEYS */;
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
