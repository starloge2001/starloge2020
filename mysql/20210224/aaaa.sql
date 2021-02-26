-- --------------------------------------------------------
-- 호스트:                          127.0.0.1
-- 서버 버전:                        8.0.22 - MySQL Community Server - GPL
-- 서버 OS:                        Win64
-- HeidiSQL 버전:                  11.2.0.6213
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- test20201130 데이터베이스 구조 내보내기
CREATE DATABASE IF NOT EXISTS `test20201130` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `test20201130`;

-- 테이블 test20201130.student 구조 내보내기
CREATE TABLE IF NOT EXISTS `student` (
  `hakbeon` varchar(45) NOT NULL,
  `name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`hakbeon`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 테이블 데이터 test20201130.student:~2 rows (대략적) 내보내기
/*!40000 ALTER TABLE `student` DISABLE KEYS */;
INSERT IGNORE INTO `student` (`hakbeon`, `name`) VALUES
	('20201126', '서정빈'),
	('20201128', '짱정빈');
/*!40000 ALTER TABLE `student` ENABLE KEYS */;

-- 테이블 test20201130.student2 구조 내보내기
CREATE TABLE IF NOT EXISTS `student2` (
  `hakbeon` varchar(45) NOT NULL,
  `name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`hakbeon`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 테이블 데이터 test20201130.student2:~0 rows (대략적) 내보내기
/*!40000 ALTER TABLE `student2` DISABLE KEYS */;
/*!40000 ALTER TABLE `student2` ENABLE KEYS */;

-- 테이블 test20201130.test1 구조 내보내기
CREATE TABLE IF NOT EXISTS `test1` (
  `이름` varchar(10) DEFAULT NULL,
  `나이` varchar(45) DEFAULT NULL,
  `학번` varchar(8) NOT NULL,
  PRIMARY KEY (`학번`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 테이블 데이터 test20201130.test1:~0 rows (대략적) 내보내기
/*!40000 ALTER TABLE `test1` DISABLE KEYS */;
/*!40000 ALTER TABLE `test1` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
