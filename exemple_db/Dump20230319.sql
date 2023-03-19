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
-- Table structure for table `tb_authorization_staff`
--

DROP TABLE IF EXISTS `tb_authorization_staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_authorization_staff` (
  `login_authorization_staff` varchar(128) NOT NULL,
  `col_full_name_staff` varchar(128) NOT NULL,
  `id_privilege_level_staff` int NOT NULL,
  `col_password_staff` int NOT NULL,
  PRIMARY KEY (`login_authorization_staff`),
  UNIQUE KEY `idnew_table_UNIQUE` (`login_authorization_staff`),
  KEY `fk_id_privilege_level_staff_idx` (`id_privilege_level_staff`),
  CONSTRAINT `fk_id_privilege_level_staff` FOREIGN KEY (`id_privilege_level_staff`) REFERENCES `tb_privilege_level_staff` (`id_privilege_level_staff`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_authorization_staff`
--

LOCK TABLES `tb_authorization_staff` WRITE;
/*!40000 ALTER TABLE `tb_authorization_staff` DISABLE KEYS */;
INSERT INTO `tb_authorization_staff` VALUES ('1','Новик ВВ',0,1),('2','admin',1,2);
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
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_equipment_manufacturer`
--

LOCK TABLES `tb_equipment_manufacturer` WRITE;
/*!40000 ALTER TABLE `tb_equipment_manufacturer` DISABLE KEYS */;
INSERT INTO `tb_equipment_manufacturer` VALUES (12,'Ascer'),(7,'Asus'),(10,'Canon'),(3,'Cisco'),(6,'HP'),(5,'Kyocera'),(8,'Lenova'),(11,'OMNY'),(9,'Pavilion'),(4,'Xerox');
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
  CONSTRAINT `fk_equipment_manufacturer` FOREIGN KEY (`id_equipment_manufacturer`) REFERENCES `tb_equipment_manufacturer` (`id_equipment_manufacturer`),
  CONSTRAINT `fk_type_equipment` FOREIGN KEY (`id_type_equipment`) REFERENCES `tb_type_equipment` (`id_type_equipment`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_equipment_model`
--

LOCK TABLES `tb_equipment_model` WRITE;
/*!40000 ALTER TABLE `tb_equipment_model` DISABLE KEYS */;
INSERT INTO `tb_equipment_model` VALUES (' HP TFT 19\" LP1965',6,6),(' K52JT (A52J) 15.6',7,7),('22\"Wide LCD VW224T',7,6),('EliteDisplay E240',6,6),('EliteDisplay E242 24\" LED',6,6),('FS-920 A4 LPT/USB 2.0',5,3),('G550-4DCWi-COM-B 15',8,7),('i-SENSYS LBP6000',10,6),('iP4700',10,3),('K55VD 15,6',7,7),('Kyoсera М2035DN A4',5,3),('Laser Jet P2015D',6,3),('Laser Jet P2055DN',6,3),('OfficaJet  K7103.A3+',6,3),('OMNY 3000',11,9),('OMNY М14Е 2812',11,9),('One AOD270-268kk',12,7),('P24h G4 Monitor FHD',6,6),('Pavilion 15-cs2019ur',6,5),('PB EasyNote ENTE11HC',12,7),('Phaser 3100MFP/S',4,1),('Phaser 3250D',4,3),('ProBook 430G6',6,5),('ProDisplay P232',6,6),('ThinkPad 13 Intel Core i3',8,7),('ThinkVision T27M061C6MAT1EU',8,6),('Unified IP Phone CP-8841',3,2),('Unified IP Phone CP-8845',3,2),('Unified IP Phone CP-8851',3,2),('Unified IP Phone CP-8865',3,2),('Unified SIP Phone CP-3905',3,2),('Unified UC Phone CP-7821',3,2),('VW226T',7,6),('WorkCentre 3325DNI',4,1),('X501A-XX466H',7,7);
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
  CONSTRAINT `fk_equipment_model_name` FOREIGN KEY (`equipment_model_name`) REFERENCES `tb_equipment_model` (`equipment_model_name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_itam_number`
--

LOCK TABLES `tb_itam_number` WRITE;
/*!40000 ALTER TABLE `tb_itam_number` DISABLE KEYS */;
INSERT INTO `tb_itam_number` VALUES (101310024,' HP TFT 19\" LP1965'),(101310011,'EliteDisplay E240'),(101310010,'FS-920 A4 LPT/USB 2.0'),(101310001,'i-SENSYS LBP6000'),(101310004,'i-SENSYS LBP6000'),(101310002,'iP4700'),(101310005,'Laser Jet P2015D'),(101310008,'Laser Jet P2015D'),(101310007,'OfficaJet  K7103.A3+'),(101310030,'Pavilion 15-cs2019ur'),(101310020,'Phaser 3100MFP/S'),(101310025,'Phaser 3100MFP/S'),(101310014,'Phaser 3250D'),(101310017,'Phaser 3250D'),(101318227,'Phaser 3250D'),(101310012,'ProBook 430G6'),(101310018,'ProDisplay P232'),(101310029,'ProDisplay P232'),(101310009,'ThinkPad 13 Intel Core i3'),(101310019,'ThinkPad 13 Intel Core i3'),(101310021,'ThinkVision T27M061C6MAT1EU'),(101310006,'Unified IP Phone CP-8841'),(101310028,'Unified IP Phone CP-8845'),(101310015,'Unified IP Phone CP-8851'),(101310027,'Unified IP Phone CP-8851'),(101310000,'Unified IP Phone CP-8865'),(101310003,'Unified SIP Phone CP-3905'),(101310022,'Unified SIP Phone CP-3905'),(101310026,'Unified SIP Phone CP-3905'),(101310023,'VW226T'),(101310013,'X501A-XX466H'),(101310016,'X501A-XX466H');
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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_location`
--

LOCK TABLES `tb_location` WRITE;
/*!40000 ALTER TABLE `tb_location` DISABLE KEYS */;
INSERT INTO `tb_location` VALUES (1,'Центральная котельная'),(3,'Южная котельная'),(4,'Восточная котельная'),(5,'Отдел сбыта');
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
  `col_date` date DEFAULT NULL,
  `mol_department` varchar(45) NOT NULL,
  `item_number` int NOT NULL,
  `login_authorization_staff` varchar(45) NOT NULL,
  PRIMARY KEY (`invent_number`),
  UNIQUE KEY `invent_number_UNIQUE` (`invent_number`),
  KEY `fk_id_col_location_idx` (`id_col_location`),
  KEY `fk_mol_department_idx` (`mol_department`),
  KEY `fk_item_number_idx` (`item_number`),
  KEY `fk_login_authorization_staff_idx` (`login_authorization_staff`),
  CONSTRAINT `fk_id_col_location` FOREIGN KEY (`id_col_location`) REFERENCES `tb_location` (`id_col_location`),
  CONSTRAINT `fk_item_number` FOREIGN KEY (`item_number`) REFERENCES `tb_itam_number` (`item_number`),
  CONSTRAINT `fk_login_authorization_staff` FOREIGN KEY (`login_authorization_staff`) REFERENCES `tb_authorization_staff` (`login_authorization_staff`),
  CONSTRAINT `fk_mol_department` FOREIGN KEY (`mol_department`) REFERENCES `tb_mol` (`mol_department`)
) ENGINE=InnoDB AUTO_INCREMENT=40 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_main`
--

LOCK TABLES `tb_main` WRITE;
/*!40000 ALTER TABLE `tb_main` DISABLE KEYS */;
INSERT INTO `tb_main` VALUES (5,1,'2023-03-19','Бухгалтерия',101318227,'1'),(6,3,'2023-03-19','КТЦ',101310029,'1'),(7,4,'2023-03-19','Отдел сбыта',101310014,'1'),(8,3,'2023-03-19','Отдел сбыта',101310026,'1'),(9,1,'2023-03-19','ОППР',101310000,'1'),(10,4,'2023-03-19','Отдел сбыта',101310003,'1'),(11,4,'2023-03-19','ОППР',101310003,'1'),(12,4,'2023-03-19','ОППР',101310015,'2'),(13,3,'2023-03-09','Бухгалтерия',101310027,'1'),(14,4,'2023-03-19','Электроцех',101310003,'1'),(15,5,'2023-03-19','Отдел сбыта',101310006,'1'),(16,5,'2023-03-19','СИСТ',101310022,'1'),(17,5,'2023-03-19','Юротдел',101310022,'1'),(18,3,'2023-03-19','ОППР',101310003,'1'),(19,1,'2023-03-19','СИСТ',101310003,'1'),(20,1,'2023-03-19','Отдел сбыта',101310003,'1'),(21,1,'2023-03-19','ЦТС',101310026,'1'),(22,5,'2023-03-19','ТАИ',101310026,'1'),(23,1,'2023-03-19','КТЦ',101310010,'1'),(24,1,'2023-03-19','Бухгалтерия',101310010,'1'),(25,1,'2023-03-19','Бухгалтерия',101310023,'1'),(26,1,'2023-03-19','ЦТС',101310010,'1'),(27,1,'2023-03-19','Бухгалтерия',101310023,'1'),(28,3,'2023-03-19','ЦТС',101310011,'1'),(29,1,'2023-03-19','Бухгалтерия',101310010,'1'),(30,1,'2023-03-19','ОППР',101310005,'1'),(31,1,'2023-03-19','Юротдел',101310024,'1'),(32,1,'2023-03-19','ТАИ',101310011,'1'),(33,1,'2023-03-19','Бухгалтерия',101310000,'1'),(34,1,'2023-03-19','Бухгалтерия',101310022,'1'),(35,3,'2023-03-19','КТЦ',101310017,'1'),(36,1,'2023-03-19','Бухгалтерия',101310022,'1'),(37,3,'2023-03-19','Отдел сбыта',101310028,'1'),(38,1,'2023-03-19','ЦТС',101310026,'1'),(39,3,'2023-03-19','ЦТС',101310005,'1');
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
INSERT INTO `tb_mol` VALUES ('Бухгалтерия','Попов С.И.'),('КТЦ','Иванов И.И.'),('ОППР','Михайлов А.С.'),('Отдел сбыта','Васильев А.А.'),('СИСТ','Кузнецов А.И.'),('ТАИ','Соколов Ю.В.'),('ЦТС','Петров А.С.'),('Электроцех','Петров А.А.'),('Юротдел','Смирнов А.П.');
/*!40000 ALTER TABLE `tb_mol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_privilege_level_staff`
--

DROP TABLE IF EXISTS `tb_privilege_level_staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_privilege_level_staff` (
  `id_privilege_level_staff` int NOT NULL,
  `col_privilege_staff_name` varchar(45) NOT NULL,
  PRIMARY KEY (`id_privilege_level_staff`),
  UNIQUE KEY `id_privilege_level_staff_UNIQUE` (`id_privilege_level_staff`),
  UNIQUE KEY `col_privilege_staff_name_UNIQUE` (`col_privilege_staff_name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_privilege_level_staff`
--

LOCK TABLES `tb_privilege_level_staff` WRITE;
/*!40000 ALTER TABLE `tb_privilege_level_staff` DISABLE KEYS */;
INSERT INTO `tb_privilege_level_staff` VALUES (0,'admin'),(1,'user');
/*!40000 ALTER TABLE `tb_privilege_level_staff` ENABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_type_equipment`
--

LOCK TABLES `tb_type_equipment` WRITE;
/*!40000 ALTER TABLE `tb_type_equipment` DISABLE KEYS */;
INSERT INTO `tb_type_equipment` VALUES (8,'веб-камера'),(9,'видеокамера'),(5,'компьютер'),(6,'монитор'),(1,'МФУ'),(7,'ноутбук'),(3,'принетр'),(4,'сканер'),(2,'телефон');
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

-- Dump completed on 2023-03-19 20:11:15
