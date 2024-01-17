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
-- Temporary view structure for view `borrowing_show`
--

DROP TABLE IF EXISTS `borrowing_show`;
/*!50001 DROP VIEW IF EXISTS `borrowing_show`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `borrowing_show` AS SELECT 
 1 AS `borrowing_id`,
 1 AS `user_id`,
 1 AS `user_name`,
 1 AS `user_surname`,
 1 AS `book_name`,
 1 AS `book_ISBN`,
 1 AS `book_lending_date`,
 1 AS `book_due_date`,
 1 AS `borrowing_state`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `istatik_view`
--

DROP TABLE IF EXISTS `istatik_view`;
/*!50001 DROP VIEW IF EXISTS `istatik_view`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `istatik_view` AS SELECT 
 1 AS `personel_count`,
 1 AS `user_count`,
 1 AS `kitap_count`,
 1 AS `yazar_count`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `borrowing_show`
--

/*!50001 DROP VIEW IF EXISTS `borrowing_show`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `borrowing_show` AS select `book_borrowing`.`borrowing_id` AS `borrowing_id`,`book_borrowing`.`user_id` AS `user_id`,`book_borrowing`.`user_name` AS `user_name`,`book_borrowing`.`user_surname` AS `user_surname`,`book_borrowing`.`book_name` AS `book_name`,`book_borrowing`.`book_ISBN` AS `book_ISBN`,`book_borrowing`.`book_lending_date` AS `book_lending_date`,`book_borrowing`.`book_due_date` AS `book_due_date`,`book_borrowing`.`borrowing_state` AS `borrowing_state` from `book_borrowing` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `istatik_view`
--

/*!50001 DROP VIEW IF EXISTS `istatik_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `istatik_view` AS select (select count(0) from `personels`) AS `personel_count`,(select count(0) from `users`) AS `user_count`,(select count(0) from `books`) AS `kitap_count`,(select count(0) from `authors`) AS `yazar_count` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-17 14:36:29
