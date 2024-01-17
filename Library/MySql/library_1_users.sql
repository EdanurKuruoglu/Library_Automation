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
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `user_id` int NOT NULL AUTO_INCREMENT,
  `user_name` varchar(45) NOT NULL,
  `user_surname` varchar(45) NOT NULL,
  `user_birthday` datetime NOT NULL,
  `user_gender` text,
  `user_number` varchar(11) NOT NULL,
  `user_mail` varchar(45) NOT NULL,
  `user_address` varchar(200) NOT NULL,
  `username` varchar(45) NOT NULL,
  `user_password` varchar(20) NOT NULL,
  `user_update` datetime DEFAULT NULL,
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `username_UNIQUE` (`username`),
  UNIQUE KEY `user_mail_UNIQUE` (`user_mail`),
  UNIQUE KEY `user_number_UNIQUE` (`user_number`),
  UNIQUE KEY `user_password_UNIQUE` (`user_password`),
  KEY `idx_user_surname` (`user_surname`),
  KEY `idx_user_name` (`user_name`),
  KEY `idx_user_id` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=54 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'Edanur','Kuruoğlu','2003-06-27 00:00:00','Kadın','05432344556','kuruogluedanur@gmail.com','Sakarya Adapazarı','eda','1234eda','2023-06-03 13:13:57'),(2,'Yahya','Kuruoğlu','1972-05-15 00:00:00','Erkek','05234765453','yahyakuruoglu@gmail.com','Sakarya Adapazarı','yahya123','3333',NULL),(3,'Ali','Kar','2000-02-02 21:29:01','Erkek','02345678908','alikar@gmail.com','Manisa Akşehir','ali23','2323',NULL),(6,'Selin','Karaca','2004-06-16 09:43:30','Kadın','02345678765','karacaselin@gmail.com','İstanbul Beyoğlu','selinn2','4433',NULL),(7,'Seher','Korkmaz','1989-01-02 20:09:24','Kadın','04567897665','korkmazseher@gmail.com','Manisa Akşehir','seher4554','4554',NULL),(8,'Mustafa','Manavlı','1999-06-09 20:14:09','Erkek','08765432345','manavmustafa16@gmail.com',' Bursa Osmangazi','mustafa1661','1661','2023-06-03 13:11:52'),(9,'Hülya','Yoldaşçı','1993-01-04 13:00:43','Kadın','05463456435','hulyayoldas@gmail.com','Kars Sarıkamış','hulya23','11113','2023-06-03 00:06:44'),(10,'Elif ','Ersan','1994-06-15 13:03:19','Kadın','09543234455','elifersan12@gmail.com','Nevşehir Gülşehir','elifersan1234','elif45',NULL),(20,'Heidi','Karaca','2004-02-04 19:43:02','Kadın','5465677688','karacaheidi23@gmail.com','Kastamonu Merkez','heidi234','23434',NULL),(35,'Can','Kaya','2000-02-02 12:15:38','Erkek','05654334554','kayacan56@gmail.com','Manisa Merkez','cankaya78','78cankaya78','2023-09-11 21:10:41'),(36,'Yunus','Girik','1993-06-16 10:51:16','Erkek','8549385858','yunusgirik95gmail.com','İstanbul ','yunusgirik95','girik95yunus',NULL),(38,'Yaren','Gündoğdu','2000-02-09 16:53:18','Kadın','04676788787','gundogduyaren64@gmail.com',' Manisa','yaren093','34yaren90','2023-12-25 18:30:17'),(41,'Ekrem','Şan','2000-02-09 20:36:08','Erkek','0875656564','sanekrem34@gmail.com',' Mersin ','ekremsan533','435ekremsan45',NULL),(42,'Sedanur','Lale','1994-07-13 15:16:24','Kadın','3345345354','lalesedanur@gmail.com','Niğde','eee','2221',NULL),(43,'Sami','Yüksek','1994-10-12 21:06:30','Erkek','05643456564','yukseksami453@gmail.com','Bursa','samiyuksel23','23samisami',NULL),(46,'Burak','Can','1999-02-02 11:31:33','Erkek','05689008544','canburak45@gmail.com','Van','canburak','23canbur',NULL),(48,'Ceren ','Kalben','1993-06-19 19:30:56','Kadın','05456767654','kalbenceren98@gmail.com',' Denizli','cerenkalben98','98cerjsk',NULL),(50,'derya','deniz','1989-06-13 21:21:46','Kadın','6878754453','denizderay3487@gmail.com','Antalya','denizderyakfe','derya48deur',NULL),(51,'','','2023-10-25 12:34:29','Kadın','','','','','',NULL);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
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
