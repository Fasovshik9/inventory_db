CREATE DATABASE  IF NOT EXISTS `inventory` /*!40100 DEFAULT CHARACTER SET utf8mb3 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `inventory`;
-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: inventory
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
-- Temporary view structure for view `main_report`
--

DROP TABLE IF EXISTS `main_report`;
/*!50001 DROP VIEW IF EXISTS `main_report`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `main_report` AS SELECT 
 1 AS `invent_number`,
 1 AS `col_location_name`,
 1 AS `col_date`,
 1 AS `col_mol_full_name`,
 1 AS `mol_department`,
 1 AS `item_number`,
 1 AS `equipment_model_name`,
 1 AS `col_equipment_manufacturer_name`,
 1 AS `col_type_equipment_name`,
 1 AS `col_full_name_staff`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `tb_authorization_staff`
--

DROP TABLE IF EXISTS `tb_authorization_staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_authorization_staff` (
  `login_authorization_staff` varchar(128) NOT NULL,
  `col_full_name_staff` varchar(128) NOT NULL,
  `col_status_level_staff` varchar(128) NOT NULL,
  `col_password_staff` varchar(45) NOT NULL,
  PRIMARY KEY (`login_authorization_staff`),
  UNIQUE KEY `idnew_table_UNIQUE` (`login_authorization_staff`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_authorization_staff`
--

LOCK TABLES `tb_authorization_staff` WRITE;
/*!40000 ALTER TABLE `tb_authorization_staff` DISABLE KEYS */;
INSERT INTO `tb_authorization_staff` VALUES ('1','admin','Администратор','1'),('123123','123123','Администратор','123123'),('123123123','321321123','Уволен','123123'),('qweqwe','qweqwe','Пользователь','qweqwe');
/*!40000 ALTER TABLE `tb_authorization_staff` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_department`
--

DROP TABLE IF EXISTS `tb_department`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_department` (
  `mol_department` varchar(128) NOT NULL,
  `col_mol_full_name` varchar(128) NOT NULL,
  PRIMARY KEY (`mol_department`),
  UNIQUE KEY `tb_mol_department_UNIQUE` (`mol_department`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_department`
--

LOCK TABLES `tb_department` WRITE;
/*!40000 ALTER TABLE `tb_department` DISABLE KEYS */;
INSERT INTO `tb_department` VALUES ('123123','321123'),('Бухгалтерия','Попов С.И.'),('КТЦ','Иванов И.И.'),('ОППР','Михайлов А.С.'),('Отдел сбыта','Васильев А.А.'),('ТАИ','Соколов Ю.В.'),('ЦТС','Петров А.С.'),('Электроцех','Петров А.А.');
/*!40000 ALTER TABLE `tb_department` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_equipment_manufacturer`
--

DROP TABLE IF EXISTS `tb_equipment_manufacturer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_equipment_manufacturer` (
  `id_equipment_manufacturer` int NOT NULL AUTO_INCREMENT,
  `col_equipment_manufacturer_name` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`id_equipment_manufacturer`),
  UNIQUE KEY `id_equipment_manufacturer_UNIQUE` (`id_equipment_manufacturer`),
  UNIQUE KEY `col_equipment_manufacturer_name_UNIQUE` (`col_equipment_manufacturer_name`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_equipment_manufacturer`
--

LOCK TABLES `tb_equipment_manufacturer` WRITE;
/*!40000 ALTER TABLE `tb_equipment_manufacturer` DISABLE KEYS */;
INSERT INTO `tb_equipment_manufacturer` VALUES (15,'123321'),(7,'Asus'),(10,'Canon'),(6,'HP'),(5,'Kyocera'),(8,'Lenova'),(11,'OMNY'),(9,'Pavilion'),(4,'Xerox');
/*!40000 ALTER TABLE `tb_equipment_manufacturer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_equipment_model`
--

DROP TABLE IF EXISTS `tb_equipment_model`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_equipment_model` (
  `equipment_model_name` varchar(128) NOT NULL,
  `id_equipment_manufacturer` int NOT NULL,
  `id_type_equipment` int NOT NULL,
  PRIMARY KEY (`equipment_model_name`),
  UNIQUE KEY `equipment_model_name_UNIQUE` (`equipment_model_name`),
  KEY `fk_id_equipment_manufacturer_idx` (`id_equipment_manufacturer`),
  KEY `fk_type_equipment_idx` (`id_type_equipment`),
  CONSTRAINT `fk_equipment_manufacturer` FOREIGN KEY (`id_equipment_manufacturer`) REFERENCES `tb_equipment_manufacturer` (`id_equipment_manufacturer`) ON DELETE CASCADE,
  CONSTRAINT `fk_type_equipment` FOREIGN KEY (`id_type_equipment`) REFERENCES `tb_type_equipment` (`id_type_equipment`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_equipment_model`
--

LOCK TABLES `tb_equipment_model` WRITE;
/*!40000 ALTER TABLE `tb_equipment_model` DISABLE KEYS */;
INSERT INTO `tb_equipment_model` VALUES (' HP TFT 19\" LP1965',6,6),(' K52JT (A52J) 15.6',7,7),('123123',8,1),('22\"Wide LCD VW224T',7,6),('34325345',15,11),('EliteDisplay E240',6,6),('EliteDisplay E242 24\" LED',6,6),('i-SENSYS LBP6000',10,6),('K55VD 15,6',7,7),('OMNY 3000',11,9),('OMNY М14Е 2812',11,9),('P24h G4 Monitor FHD',6,6),('Pavilion 15-cs2019ur',6,5),('Phaser 3100MFP/S',4,1),('ProBook 430G6',6,5),('ProDisplay P232',6,6),('ThinkPad 13 Intel Core i3',8,7),('ThinkVision T27M061C6MAT1EU',8,6),('WorkCentre 3325DNI',4,1),('X501A-XX466H',7,7);
/*!40000 ALTER TABLE `tb_equipment_model` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_equipment_report`
--

DROP TABLE IF EXISTS `tb_equipment_report`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_equipment_report` (
  `invent_number` int NOT NULL AUTO_INCREMENT,
  `id_col_location` int NOT NULL,
  `col_date` date NOT NULL,
  `mol_department` varchar(45) NOT NULL,
  `item_number` int NOT NULL,
  `login_authorization_staff` varchar(45) NOT NULL,
  PRIMARY KEY (`invent_number`),
  UNIQUE KEY `invent_number_UNIQUE` (`invent_number`),
  KEY `fk_id_col_location_idx` (`id_col_location`),
  KEY `fk_item_number_idx` (`item_number`),
  KEY `fk_login_authorization_staff_idx` (`login_authorization_staff`),
  KEY `fk_mol_department_idx` (`mol_department`),
  CONSTRAINT `fk_id_col_location` FOREIGN KEY (`id_col_location`) REFERENCES `tb_location` (`id_col_location`) ON DELETE CASCADE,
  CONSTRAINT `fk_item_number` FOREIGN KEY (`item_number`) REFERENCES `tb_itam_number` (`item_number`) ON DELETE CASCADE,
  CONSTRAINT `fk_login_authorization_staff` FOREIGN KEY (`login_authorization_staff`) REFERENCES `tb_authorization_staff` (`login_authorization_staff`) ON DELETE CASCADE,
  CONSTRAINT `fk_mol_department` FOREIGN KEY (`mol_department`) REFERENCES `tb_department` (`mol_department`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=50 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_equipment_report`
--

LOCK TABLES `tb_equipment_report` WRITE;
/*!40000 ALTER TABLE `tb_equipment_report` DISABLE KEYS */;
INSERT INTO `tb_equipment_report` VALUES (46,3,'2023-03-27','Отдел сбыта',101310030,'1'),(47,4,'2023-03-27','ОППР',101310020,'1');
/*!40000 ALTER TABLE `tb_equipment_report` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_itam_number`
--

DROP TABLE IF EXISTS `tb_itam_number`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_itam_number` (
  `item_number` int NOT NULL,
  `equipment_model_name` varchar(128) NOT NULL,
  PRIMARY KEY (`item_number`),
  UNIQUE KEY `ittem_number_UNIQUE` (`item_number`),
  KEY `fk_equipment_model_name_idx` (`equipment_model_name`),
  CONSTRAINT `fk_equipment_model_name` FOREIGN KEY (`equipment_model_name`) REFERENCES `tb_equipment_model` (`equipment_model_name`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_itam_number`
--

LOCK TABLES `tb_itam_number` WRITE;
/*!40000 ALTER TABLE `tb_itam_number` DISABLE KEYS */;
INSERT INTO `tb_itam_number` VALUES (123123123,'34325345'),(5325,'EliteDisplay E240'),(12332,'EliteDisplay E240'),(12343,'EliteDisplay E240'),(123321,'EliteDisplay E240'),(345345,'EliteDisplay E240'),(111111111,'EliteDisplay E240'),(123245678,'EliteDisplay E240'),(123,'EliteDisplay E242 24\" LED'),(123213,'EliteDisplay E242 24\" LED'),(123123232,'EliteDisplay E242 24\" LED'),(123123321,'EliteDisplay E242 24\" LED'),(123456666,'EliteDisplay E242 24\" LED'),(999999999,'EliteDisplay E242 24\" LED'),(101310001,'i-SENSYS LBP6000'),(101310004,'i-SENSYS LBP6000'),(234,'P24h G4 Monitor FHD'),(324,'P24h G4 Monitor FHD'),(345,'P24h G4 Monitor FHD'),(1234,'P24h G4 Monitor FHD'),(235432,'P24h G4 Monitor FHD'),(111111112,'P24h G4 Monitor FHD'),(657,'Pavilion 15-cs2019ur'),(101310030,'Pavilion 15-cs2019ur'),(345345345,'Pavilion 15-cs2019ur'),(101310020,'Phaser 3100MFP/S'),(101310025,'Phaser 3100MFP/S'),(343466491,'Phaser 3100MFP/S'),(101310012,'ProBook 430G6'),(101310018,'ProDisplay P232'),(101310029,'ProDisplay P232'),(101310009,'ThinkPad 13 Intel Core i3'),(101310019,'ThinkPad 13 Intel Core i3'),(101310021,'ThinkVision T27M061C6MAT1EU'),(123456789,'WorkCentre 3325DNI'),(101310013,'X501A-XX466H'),(101310016,'X501A-XX466H');
/*!40000 ALTER TABLE `tb_itam_number` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_location`
--

DROP TABLE IF EXISTS `tb_location`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_location` (
  `id_col_location` int NOT NULL AUTO_INCREMENT,
  `col_location_name` varchar(128) NOT NULL,
  PRIMARY KEY (`id_col_location`),
  UNIQUE KEY `id_location_UNIQUE` (`id_col_location`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_location`
--

LOCK TABLES `tb_location` WRITE;
/*!40000 ALTER TABLE `tb_location` DISABLE KEYS */;
INSERT INTO `tb_location` VALUES (1,'Центральная котельная'),(3,'Южная котельная'),(4,'Восточная котельная');
/*!40000 ALTER TABLE `tb_location` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_type_equipment`
--

DROP TABLE IF EXISTS `tb_type_equipment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_type_equipment` (
  `id_type_equipment` int NOT NULL AUTO_INCREMENT,
  `col_type_equipment_name` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`id_type_equipment`),
  UNIQUE KEY `id_type_equipment_UNIQUE` (`id_type_equipment`),
  UNIQUE KEY `col_type_equipment_name_UNIQUE` (`col_type_equipment_name`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_type_equipment`
--

LOCK TABLES `tb_type_equipment` WRITE;
/*!40000 ALTER TABLE `tb_type_equipment` DISABLE KEYS */;
INSERT INTO `tb_type_equipment` VALUES (11,'1233'),(8,'веб-камера'),(9,'видеокамера'),(5,'компьютер'),(6,'монитор'),(1,'МФУ'),(7,'ноутбук'),(4,'сканер'),(2,'телефон');
/*!40000 ALTER TABLE `tb_type_equipment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Final view structure for view `main_report`
--

/*!50001 DROP VIEW IF EXISTS `main_report`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `main_report` AS select `tb_equipment_report`.`invent_number` AS `invent_number`,`tb_location`.`col_location_name` AS `col_location_name`,`tb_equipment_report`.`col_date` AS `col_date`,`tb_department`.`col_mol_full_name` AS `col_mol_full_name`,`tb_department`.`mol_department` AS `mol_department`,`tb_itam_number`.`item_number` AS `item_number`,`tb_equipment_model`.`equipment_model_name` AS `equipment_model_name`,`tb_equipment_manufacturer`.`col_equipment_manufacturer_name` AS `col_equipment_manufacturer_name`,`tb_type_equipment`.`col_type_equipment_name` AS `col_type_equipment_name`,`tb_authorization_staff`.`col_full_name_staff` AS `col_full_name_staff` from (((((((`tb_equipment_report` join `tb_location` on((`tb_equipment_report`.`id_col_location` = `tb_location`.`id_col_location`))) join `tb_department` on((`tb_equipment_report`.`mol_department` = `tb_department`.`mol_department`))) join `tb_itam_number` on((`tb_equipment_report`.`item_number` = `tb_itam_number`.`item_number`))) join `tb_equipment_model` on((`tb_itam_number`.`equipment_model_name` = `tb_equipment_model`.`equipment_model_name`))) join `tb_equipment_manufacturer` on((`tb_equipment_model`.`id_equipment_manufacturer` = `tb_equipment_manufacturer`.`id_equipment_manufacturer`))) join `tb_type_equipment` on((`tb_equipment_model`.`id_type_equipment` = `tb_type_equipment`.`id_type_equipment`))) join `tb_authorization_staff` on((`tb_equipment_report`.`login_authorization_staff` = `tb_authorization_staff`.`login_authorization_staff`))) */;
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

-- Dump completed on 2023-03-28 20:19:03
