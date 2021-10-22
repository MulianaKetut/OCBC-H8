/*
SQLyog Community v13.1.7 (64 bit)
MySQL - 10.4.21-MariaDB : Database - finalprojectcs
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`finalprojectcs` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `finalprojectcs`;

/*Table structure for table `__efmigrationshistory` */

DROP TABLE IF EXISTS `__efmigrationshistory`;

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `__efmigrationshistory` */

insert  into `__efmigrationshistory`(`MigrationId`,`ProductVersion`) values 
('20211021113953_Initial Migrations','5.0.11');

/*Table structure for table `aspnetroleclaims` */

DROP TABLE IF EXISTS `aspnetroleclaims`;

CREATE TABLE `aspnetroleclaims` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `RoleId` varchar(255) NOT NULL,
  `ClaimType` longtext DEFAULT NULL,
  `ClaimValue` longtext DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`),
  CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `aspnetroleclaims` */

/*Table structure for table `aspnetroles` */

DROP TABLE IF EXISTS `aspnetroles`;

CREATE TABLE `aspnetroles` (
  `Id` varchar(255) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(256) DEFAULT NULL,
  `ConcurrencyStamp` longtext DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `RoleNameIndex` (`NormalizedName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `aspnetroles` */

/*Table structure for table `aspnetuserclaims` */

DROP TABLE IF EXISTS `aspnetuserclaims`;

CREATE TABLE `aspnetuserclaims` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UserId` varchar(255) NOT NULL,
  `ClaimType` longtext DEFAULT NULL,
  `ClaimValue` longtext DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_AspNetUserClaims_UserId` (`UserId`),
  CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `aspnetuserclaims` */

/*Table structure for table `aspnetuserlogins` */

DROP TABLE IF EXISTS `aspnetuserlogins`;

CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(255) NOT NULL,
  `ProviderKey` varchar(255) NOT NULL,
  `ProviderDisplayName` longtext DEFAULT NULL,
  `UserId` varchar(255) NOT NULL,
  PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  KEY `IX_AspNetUserLogins_UserId` (`UserId`),
  CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `aspnetuserlogins` */

/*Table structure for table `aspnetuserroles` */

DROP TABLE IF EXISTS `aspnetuserroles`;

CREATE TABLE `aspnetuserroles` (
  `UserId` varchar(255) NOT NULL,
  `RoleId` varchar(255) NOT NULL,
  PRIMARY KEY (`UserId`,`RoleId`),
  KEY `IX_AspNetUserRoles_RoleId` (`RoleId`),
  CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `aspnetuserroles` */

/*Table structure for table `aspnetusers` */

DROP TABLE IF EXISTS `aspnetusers`;

CREATE TABLE `aspnetusers` (
  `Id` varchar(255) NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(256) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(256) DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` longtext DEFAULT NULL,
  `SecurityStamp` longtext DEFAULT NULL,
  `ConcurrencyStamp` longtext DEFAULT NULL,
  `PhoneNumber` longtext DEFAULT NULL,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` datetime(6) DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  KEY `EmailIndex` (`NormalizedEmail`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `aspnetusers` */

insert  into `aspnetusers`(`Id`,`UserName`,`NormalizedUserName`,`Email`,`NormalizedEmail`,`EmailConfirmed`,`PasswordHash`,`SecurityStamp`,`ConcurrencyStamp`,`PhoneNumber`,`PhoneNumberConfirmed`,`TwoFactorEnabled`,`LockoutEnd`,`LockoutEnabled`,`AccessFailedCount`) values 
('0aeed100-00ea-4561-b6c4-88c0b9bcf776','User6','USER6','user6@example.com','USER6@EXAMPLE.COM',0,'AQAAAAEAACcQAAAAEJ56usCzMwseXra1vfiL9R7IS0VJnMLw5uqitkTZLewkirGwdg5ducodZNs9SoOULg==','M5TBR7YD7BM5LTQ7PBPFK7PLMRZIGLDN','a041cb71-90bf-4c7a-a915-d2e9389ba4aa',NULL,0,0,NULL,1,0),
('0f554a95-018b-47c8-b92b-b26cb2c6b6e9','User3','USER3','user3@example.com','USER3@EXAMPLE.COM',0,'AQAAAAEAACcQAAAAEDTLufRnXgDbJwQZUaGDZKNAfGYHW22AYN3FXG+XPHFFS7Lf7kOCmm+64OFyT5mOdw==','2Z7GQJVT6OY2BSD3PNVPPBTI7LT7CHKQ','0a179d4b-d606-4951-a0ae-d0ad5af244be',NULL,0,0,NULL,1,0),
('6e4c1683-16b8-4487-b24c-fd55eac174b3','User4','USER4','user4@example.com','USER4@EXAMPLE.COM',0,'AQAAAAEAACcQAAAAEKF+TYhAGq3jce0P7BDJe/JeJSVj/bAHFrfRwsj8eIWL06TbhzHXnDGVAvsJvypkqw==','WXBUUB5B2ZW23FN62AYGFEQOOBKKTRY5','e52ba2c2-a334-481b-a9a5-9600b715c4e9',NULL,0,0,NULL,1,0),
('a5424a1b-81c7-46d9-bc52-a5695e47fb5b','User1','USER1','user1@example.com','USER1@EXAMPLE.COM',0,'AQAAAAEAACcQAAAAEIgAiIR0IMkPHVnkQ+suy9NY++r6ODmG65CRjQLTpOlk8UM9CIpCCantJ24Y4MEcVQ==','UW7KZBPCJ7MMJ3C2JMQYRHRVNB2YRZFN','4c8fc5de-ee26-4a93-80ad-8ead8bea1bac',NULL,0,0,NULL,1,0),
('a916ea5a-7fa8-44b8-bd9b-59345f6d8175','User2','USER2','user2@example.com','USER2@EXAMPLE.COM',0,'AQAAAAEAACcQAAAAEJZLSDQLuGSK+xMwIRznBnDYmYiSsif65o+U8KlIZ1rJJJA1i4DCbc0dDGmmWAlbbA==','F3GBZ3HPDK5LUM7ZQT2XIYT4XXJRWFIZ','8e8b3dd1-68cb-46d3-a9c2-b730419bf7c7',NULL,0,0,NULL,1,0),
('e5456750-f480-4222-b046-c938c59d2d4e','string','STRING','user@example.com','USER@EXAMPLE.COM',0,'AQAAAAEAACcQAAAAEMvawvvIkzmD5tTsCv9OMNhAwqZktw4YIgKVrKLhHxvK3cZ0Och20Utn2Dq7HxefGg==','WIZP62F64DHHMKKLGUVMZO6OBS5LHDDJ','d855078c-63e5-46f7-9a65-3b9414129231',NULL,0,0,NULL,1,0),
('efb7609a-90a1-468c-ada1-0aaef8794b2e','User7','USER7','user7@example.com','USER7@EXAMPLE.COM',0,'AQAAAAEAACcQAAAAEFRZkFyLTLVCf29KAl6GSqInhPMXkOJy3U/1Dpf43zrY1fLm0AVCqyMS6OgXok6YbQ==','4EIBDWOLQ4JNL2MBRRN7IDFL72MXI563','3361b973-4ad7-4df9-8681-7a08f1508e44',NULL,0,0,NULL,1,0),
('fb15fd00-a5c3-4110-823d-2333d56f0ccc','User5','USER5','user5@example.com','USER5@EXAMPLE.COM',0,'AQAAAAEAACcQAAAAEDlh9W6rjvRSSyt6A2i/haIqnhDS/unFP5dP3llg3Si4SXx/ZhHG0emwJEHs/iDmyQ==','SLOJ3XSC7DAACK4WIRL6DIPVNXXDPBUK','bbeaa3c2-bc99-4abd-a2dc-7dfad4272f03',NULL,0,0,NULL,1,0);

/*Table structure for table `aspnetusertokens` */

DROP TABLE IF EXISTS `aspnetusertokens`;

CREATE TABLE `aspnetusertokens` (
  `UserId` varchar(255) NOT NULL,
  `LoginProvider` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Value` longtext DEFAULT NULL,
  PRIMARY KEY (`UserId`,`LoginProvider`,`Name`),
  CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `aspnetusertokens` */

/*Table structure for table `paymentdetails` */

DROP TABLE IF EXISTS `paymentdetails`;

CREATE TABLE `paymentdetails` (
  `PaymentDetailId` int(11) NOT NULL AUTO_INCREMENT,
  `CardOwnerName` longtext DEFAULT NULL,
  `CardNumber` longtext DEFAULT NULL,
  `ExpirationDate` datetime(6) NOT NULL,
  `SecurityCode` longtext DEFAULT NULL,
  PRIMARY KEY (`PaymentDetailId`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

/*Data for the table `paymentdetails` */

insert  into `paymentdetails`(`PaymentDetailId`,`CardOwnerName`,`CardNumber`,`ExpirationDate`,`SecurityCode`) values 
(2,'string2','string2','2021-10-22 00:35:03.280000','string2');

/*Table structure for table `refreshtoken` */

DROP TABLE IF EXISTS `refreshtoken`;

CREATE TABLE `refreshtoken` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UserId` varchar(255) DEFAULT NULL,
  `Token` longtext DEFAULT NULL,
  `JwtId` longtext DEFAULT NULL,
  `IsUsed` tinyint(1) NOT NULL,
  `IsRevoked` tinyint(1) NOT NULL,
  `AddedDate` datetime(6) NOT NULL,
  `ExpiryDate` datetime(6) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_RefreshToken_UserId` (`UserId`),
  CONSTRAINT `FK_RefreshToken_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4;

/*Data for the table `refreshtoken` */

insert  into `refreshtoken`(`Id`,`UserId`,`Token`,`JwtId`,`IsUsed`,`IsRevoked`,`AddedDate`,`ExpiryDate`) values 
(1,'0f554a95-018b-47c8-b92b-b26cb2c6b6e9','HALBV3MA81PMQJC9IV1GJR6K66D1PIBXSTM760ce38c-c583-4b16-a85a-1bea59ab1e8f','9da5c548-cfb5-4359-bd07-d16c241d8b2f',0,0,'2021-10-21 18:27:33.872519','2022-04-21 18:27:33.872547'),
(2,'0f554a95-018b-47c8-b92b-b26cb2c6b6e9','LY8E052ZA4ZFSVAYH5H7ZDHL3L246EK3JBR9e790aa9-aae4-4c8f-b935-c2aabd140273','e196cd09-b938-4016-8e14-d77179f932a6',0,0,'2021-10-21 18:34:37.052839','2022-04-21 18:34:37.052867'),
(3,'a5424a1b-81c7-46d9-bc52-a5695e47fb5b','KKJXCCGNAZH5JN714PNQ8GF2UR3CH31FJM14035dda8-0678-45f5-8250-ea40751f3944','e0d725b9-847e-45bf-b4d9-0da212283718',0,0,'2021-10-21 18:36:23.973653','2022-04-21 18:36:23.973685'),
(4,'a5424a1b-81c7-46d9-bc52-a5695e47fb5b','V7PA8WRH3QN4KZYNGU1H57V0VS6YDXMKVEC713241b3-404e-4806-aa95-6e007345f30d','9214d359-26bc-41fd-b0b8-0ef19432b617',0,0,'2021-10-21 18:47:57.591600','2022-04-21 18:47:57.591630'),
(5,'a5424a1b-81c7-46d9-bc52-a5695e47fb5b','1I1ZNL9YFC44ICG1L769WVDI0QYMCHZTIA711d0cec7-1fcb-47e4-9dec-c98cb45c64f2','f7d43dff-3e1b-4638-b131-d9e1c6f345f5',0,0,'2021-10-21 18:57:11.408125','2022-04-21 18:57:11.408152'),
(6,'a5424a1b-81c7-46d9-bc52-a5695e47fb5b','VJQGD7VDEROT9EECS5VP5IFEE5UAB4P9PNFd46cc08a-5e2d-4791-a171-2222f48fd262','40ad2346-63e4-488c-86cc-40c88b1f513b',0,0,'2021-10-21 19:03:20.916482','2022-04-21 19:03:20.916509'),
(7,'a916ea5a-7fa8-44b8-bd9b-59345f6d8175','OKA64CED3V2ZOJD30I7INJ89VC8LKEECCDPf0241ee2-c16f-44a9-827a-d398d85beeb5','11a505fd-f1c6-41ba-88de-0ab336720e45',0,0,'2021-10-21 19:08:16.188549','2022-04-21 19:08:16.188578'),
(8,'6e4c1683-16b8-4487-b24c-fd55eac174b3','YHACG53FJX3LP99CBD7GB2YCWZ930M3CNJIb7a2cd93-b2e1-4352-aa93-bd9abc94d62e','005b3036-5a0d-439f-921f-0873891cdb5b',0,0,'2021-10-21 19:21:51.421804','2021-11-21 19:21:51.421832'),
(9,'6e4c1683-16b8-4487-b24c-fd55eac174b3','SGA07Y4UGKXPZULQXB3PV1OMJK0FUSLNYKV879dd92e-baeb-4b1a-a5f9-f7515fe90a99','32cb9177-e940-4f90-972b-9e3842d75ea9',0,0,'2021-10-21 19:25:11.901232','2021-11-21 19:25:11.901261'),
(10,'6e4c1683-16b8-4487-b24c-fd55eac174b3','AW1K6JZA0L7WAQLZYAHQHG6D17DZSOMKFXY3a45bbaf-9583-4877-ae1f-e75b1e1c3867','86ce6470-1163-4983-bbf9-6057e421caf1',0,0,'2021-10-21 19:28:04.158951','2021-11-21 19:28:04.158951'),
(11,'6e4c1683-16b8-4487-b24c-fd55eac174b3','W9KJ8051NI0JKTP3WNAAIPAM9MTRON95M58f83048b9-8573-442f-919c-a9e952d2633f','bc6b8a1e-5f92-47d9-bed4-1261ab8241d5',0,0,'2021-10-21 19:28:05.164249','2021-11-21 19:28:05.164249'),
(12,'e5456750-f480-4222-b046-c938c59d2d4e','ELWUTLSFV2OQMGE5CYW4H4RHXSHLFE6WWF86ec29a9d-95e7-44bb-bdd9-661c07683cfb','3cb483dd-0a81-4fec-bd91-ece51f90982c',0,0,'2021-10-21 19:30:53.339130','2022-04-21 19:30:53.339159'),
(13,'6e4c1683-16b8-4487-b24c-fd55eac174b3','U4Y9KGOR7SUGHG2TTLMCMLSWNO30FD34EJS5f1cde2f-aa91-41fa-81f8-80b504ff6162','a5bf5571-15de-4b93-8612-a19f5bae9c97',0,0,'2021-10-21 19:43:02.102820','2022-04-21 19:43:02.102848'),
(14,'6e4c1683-16b8-4487-b24c-fd55eac174b3','2GVAISLOB0W30LCX6H0KN8I4B4LEKMY8YD8825b4ff0-25b3-4920-9e56-e802b1a2bea5','938f069d-55d0-49ab-8bfd-e65487f0effe',0,0,'2021-10-21 19:47:52.278039','2022-04-21 19:47:52.278067'),
(15,'6e4c1683-16b8-4487-b24c-fd55eac174b3','6BT5GZP67T4RZGRHCPRV2GQQACPSSVASHYMa6843854-e088-4107-a2b4-a507a0b8cb69','34c93356-aa07-4762-850d-c44e4b36a2a8',0,0,'2021-10-21 19:51:16.819942','2022-04-21 19:51:16.819972'),
(16,'6e4c1683-16b8-4487-b24c-fd55eac174b3','KFEFRM1YPDPX6QGG159RLWSBNRXHD9P5K06c64e98b2-f016-428f-bde7-a65d15738127','1791b11d-3725-42ab-b9d8-e8cdf706d53a',0,0,'2021-10-21 19:57:53.614124','2022-04-21 19:57:53.614152'),
(17,'fb15fd00-a5c3-4110-823d-2333d56f0ccc','JM5U8Y2SYAHKBM4HPJ5FKC1PG8GV2KIVJO20f539d9d-c299-4da5-bc4b-a1966b260468','beff0a72-8fad-4390-abd6-7c3e0ee5f01c',0,0,'2021-10-21 20:11:46.635979','2022-04-21 20:11:46.636008'),
(18,'fb15fd00-a5c3-4110-823d-2333d56f0ccc','IZSSTBNGGDPHRE1WDYVVVLAP82QPTBUIJ2Odd280924-30b7-4ad3-a7c6-660c6fd63e57','6e5a92bc-9405-43d5-8f4d-65f1be08ef04',0,0,'2021-10-21 20:17:28.144017','2022-04-21 20:17:28.144045'),
(19,'a916ea5a-7fa8-44b8-bd9b-59345f6d8175','WDQ1RHBLIB9YXSOR3F4QF4KWEKMNUMENC4Wc36d1b39-6468-47ed-bd24-f231221d81ee','b0463a8b-9686-4449-84c9-1d3bb4694b34',0,0,'2021-10-22 00:01:37.844009','2022-04-22 00:01:37.844039'),
(20,'a916ea5a-7fa8-44b8-bd9b-59345f6d8175','X9ZGZ50LSF4336FWUFEAZ08O093X72FF8OR5885a50f-7d13-43e2-b97a-bf52153f6906','5e0285cd-6010-4acd-9bc0-925e98345bdd',0,0,'2021-10-22 00:05:35.699311','2022-04-22 00:05:35.699340'),
(21,'0aeed100-00ea-4561-b6c4-88c0b9bcf776','KHU8MWZKV14ZT61MQ42WSMLVL3QJJG0O2DNba612104-01af-4a12-99c8-3e6025945345','1f08fc01-ef7c-4e9a-89f5-3a756bd02c2e',0,0,'2021-10-22 00:14:10.387993','2022-04-22 00:14:10.388022'),
(22,'efb7609a-90a1-468c-ada1-0aaef8794b2e','H04QRRDDBG3N6T2TTQ8OHS63VZI38J7RLW2c94885ad-534a-4417-9d46-c5bbca28b983','10aad72c-8145-42f8-a5d6-5cd650bbf51a',0,0,'2021-10-22 00:27:31.571068','2022-04-22 00:27:31.571097');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
