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
-- Table structure for table `tb_authorization_staff`
--

DROP TABLE IF EXISTS `tb_authorization_staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_authorization_staff` (
  `login_authorization_staff` varchar(128) NOT NULL,
  `col_full_name_staff` varchar(128) NOT NULL,
  `id_status_level_staff` int NOT NULL,
  `col_password_staff` varchar(45) NOT NULL,
  PRIMARY KEY (`login_authorization_staff`),
  UNIQUE KEY `idnew_table_UNIQUE` (`login_authorization_staff`),
  KEY `fk_id_status_level_staff_idx` (`id_status_level_staff`),
  CONSTRAINT `fk_id_status_level_staff` FOREIGN KEY (`id_status_level_staff`) REFERENCES `tb_status_level_staff` (`id_status_level_staff`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_authorization_staff`
--

LOCK TABLES `tb_authorization_staff` WRITE;
/*!40000 ALTER TABLE `tb_authorization_staff` DISABLE KEYS */;
INSERT INTO `tb_authorization_staff` VALUES ('1','admin',0,'1'),('123123','123123',2,'123123'),('123123123','321321123',1,'123123');
/*!40000 ALTER TABLE `tb_authorization_staff` ENABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_equipment_manufacturer`
--

LOCK TABLES `tb_equipment_manufacturer` WRITE;
/*!40000 ALTER TABLE `tb_equipment_manufacturer` DISABLE KEYS */;
INSERT INTO `tb_equipment_manufacturer` VALUES (7,'Asus'),(10,'Canon'),(6,'HP'),(5,'Kyocera'),(8,'Lenova'),(11,'OMNY'),(9,'Pavilion'),(4,'Xerox');
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
INSERT INTO `tb_equipment_model` VALUES (' HP TFT 19\" LP1965',6,6),(' K52JT (A52J) 15.6',7,7),('22\"Wide LCD VW224T',7,6),('EliteDisplay E240',6,6),('EliteDisplay E242 24\" LED',6,6),('i-SENSYS LBP6000',10,6),('K55VD 15,6',7,7),('OMNY 3000',11,9),('OMNY М14Е 2812',11,9),('P24h G4 Monitor FHD',6,6),('Pavilion 15-cs2019ur',6,5),('Phaser 3100MFP/S',4,1),('ProBook 430G6',6,5),('ProDisplay P232',6,6),('ThinkPad 13 Intel Core i3',8,7),('ThinkVision T27M061C6MAT1EU',8,6),('WorkCentre 3325DNI',4,1),('X501A-XX466H',7,7);
/*!40000 ALTER TABLE `tb_equipment_model` ENABLE KEYS */;
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
INSERT INTO `tb_itam_number` VALUES (101310001,'i-SENSYS LBP6000'),(101310004,'i-SENSYS LBP6000'),(101310030,'Pavilion 15-cs2019ur'),(101310020,'Phaser 3100MFP/S'),(101310025,'Phaser 3100MFP/S'),(101310012,'ProBook 430G6'),(101310018,'ProDisplay P232'),(101310029,'ProDisplay P232'),(101310009,'ThinkPad 13 Intel Core i3'),(101310019,'ThinkPad 13 Intel Core i3'),(101310021,'ThinkVision T27M061C6MAT1EU'),(101310013,'X501A-XX466H'),(101310016,'X501A-XX466H');
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
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb3;
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
-- Table structure for table `tb_main`
--

DROP TABLE IF EXISTS `tb_main`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_main` (
  `invent_number` int NOT NULL AUTO_INCREMENT,
  `id_col_location` int NOT NULL,
  `col_date` date NOT NULL,
  `mol_department` varchar(45) NOT NULL,
  `item_number` int NOT NULL,
  `login_authorization_staff` varchar(45) NOT NULL,
  PRIMARY KEY (`invent_number`),
  UNIQUE KEY `invent_number_UNIQUE` (`invent_number`),
  KEY `fk_id_col_location_idx` (`id_col_location`),
  KEY `fk_mol_department_idx` (`mol_department`),
  KEY `fk_item_number_idx` (`item_number`),
  KEY `fk_login_authorization_staff_idx` (`login_authorization_staff`),
  CONSTRAINT `fk_id_col_location` FOREIGN KEY (`id_col_location`) REFERENCES `tb_location` (`id_col_location`) ON DELETE CASCADE,
  CONSTRAINT `fk_item_number` FOREIGN KEY (`item_number`) REFERENCES `tb_itam_number` (`item_number`) ON DELETE CASCADE,
  CONSTRAINT `fk_login_authorization_staff` FOREIGN KEY (`login_authorization_staff`) REFERENCES `tb_authorization_staff` (`login_authorization_staff`) ON DELETE CASCADE,
  CONSTRAINT `fk_mol_department` FOREIGN KEY (`mol_department`) REFERENCES `tb_mol` (`mol_department`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=42 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_main`
--

LOCK TABLES `tb_main` WRITE;
/*!40000 ALTER TABLE `tb_main` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_main` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_mol`
--

DROP TABLE IF EXISTS `tb_mol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_mol` (
  `mol_department` varchar(128) NOT NULL,
  `col_mol_full_name` varchar(128) NOT NULL,
  PRIMARY KEY (`mol_department`),
  UNIQUE KEY `tb_mol_department_UNIQUE` (`mol_department`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_mol`
--

LOCK TABLES `tb_mol` WRITE;
/*!40000 ALTER TABLE `tb_mol` DISABLE KEYS */;
INSERT INTO `tb_mol` VALUES ('Бухгалтерия','Попов С.И.'),('КТЦ','Иванов И.И.'),('ОППР','Михайлов А.С.'),('Отдел сбыта','Васильев А.А.'),('ТАИ','Соколов Ю.В.'),('ЦТС','Петров А.С.'),('Электроцех','Петров А.А.');
/*!40000 ALTER TABLE `tb_mol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_status_level_staff`
--

DROP TABLE IF EXISTS `tb_status_level_staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_status_level_staff` (
  `id_status_level_staff` int NOT NULL,
  `col_status_staff_name` varchar(45) NOT NULL,
  PRIMARY KEY (`id_status_level_staff`),
  UNIQUE KEY `id_privilege_level_staff_UNIQUE` (`id_status_level_staff`),
  UNIQUE KEY `col_privilege_staff_name_UNIQUE` (`col_status_staff_name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_status_level_staff`
--

LOCK TABLES `tb_status_level_staff` WRITE;
/*!40000 ALTER TABLE `tb_status_level_staff` DISABLE KEYS */;
INSERT INTO `tb_status_level_staff` VALUES (0,'admin'),(1,'user'),(2,'Уволен');
/*!40000 ALTER TABLE `tb_status_level_staff` ENABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_type_equipment`
--

LOCK TABLES `tb_type_equipment` WRITE;
/*!40000 ALTER TABLE `tb_type_equipment` DISABLE KEYS */;
INSERT INTO `tb_type_equipment` VALUES (8,'веб-камера'),(9,'видеокамера'),(5,'компьютер'),(6,'монитор'),(1,'МФУ'),(7,'ноутбук'),(4,'сканер'),(2,'телефон');
/*!40000 ALTER TABLE `tb_type_equipment` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-03-26 19:53:55
