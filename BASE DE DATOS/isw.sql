-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 13-12-2023 a las 01:43:54
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `isw`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ctl_asistencia`
--

CREATE TABLE `ctl_asistencia` (
  `ID_Asistencia` char(10) NOT NULL,
  `ID_Clase` char(10) NOT NULL,
  `ID_Alumno` char(10) NOT NULL,
  `ID_Profesor` char(10) NOT NULL,
  `ID_Horario` char(10) NOT NULL,
  `ID_Lab` char(2) NOT NULL,
  `ID_Maquina` char(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ctl_grupo`
--

CREATE TABLE `ctl_grupo` (
  `ID_Grupo` char(10) NOT NULL,
  `Grupo` char(5) DEFAULT NULL,
  `Periodo` char(1) DEFAULT NULL,
  `Anio` year(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ctl_lab`
--

CREATE TABLE `ctl_lab` (
  `ID_Lab` char(2) NOT NULL,
  `Laboratorio` char(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ctl_maqui`
--

CREATE TABLE `ctl_maqui` (
  `ID_Maquina` char(1) NOT NULL,
  `Maquina` char(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ctl_materia`
--

CREATE TABLE `ctl_materia` (
  `ID_Materia` char(10) NOT NULL,
  `Nombre_de_la_Materia` char(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tlb_alumnos`
--

CREATE TABLE `tlb_alumnos` (
  `ID_Alumno` char(20) NOT NULL,
  `Nombre_del_Alumno` char(20) DEFAULT NULL,
  `Numero_de_Boleta` char(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tlb_clase`
--

CREATE TABLE `tlb_clase` (
  `ID_Clase` char(10) NOT NULL,
  `ID_Grupo` char(10) NOT NULL,
  `ID_Materia` char(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tlb_horario`
--

CREATE TABLE `tlb_horario` (
  `ID_Horario` char(20) NOT NULL,
  `Fecha` date DEFAULT NULL,
  `Horario` time DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tlb_profesor`
--

CREATE TABLE `tlb_profesor` (
  `ID_Profesor` char(10) NOT NULL,
  `Nombre_del_Profesor` char(30) DEFAULT NULL,
  `Numero_del_empleado` char(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `ctl_asistencia`
--
ALTER TABLE `ctl_asistencia`
  ADD PRIMARY KEY (`ID_Asistencia`),
  ADD KEY `ID_Clase` (`ID_Clase`),
  ADD KEY `ID_Alumno` (`ID_Alumno`),
  ADD KEY `ID_Profesor` (`ID_Profesor`),
  ADD KEY `ID_Horario` (`ID_Horario`),
  ADD KEY `ID_Lab` (`ID_Lab`),
  ADD KEY `ID_Maquina` (`ID_Maquina`);

--
-- Indices de la tabla `ctl_grupo`
--
ALTER TABLE `ctl_grupo`
  ADD PRIMARY KEY (`ID_Grupo`);

--
-- Indices de la tabla `ctl_lab`
--
ALTER TABLE `ctl_lab`
  ADD PRIMARY KEY (`ID_Lab`);

--
-- Indices de la tabla `ctl_maqui`
--
ALTER TABLE `ctl_maqui`
  ADD PRIMARY KEY (`ID_Maquina`);

--
-- Indices de la tabla `ctl_materia`
--
ALTER TABLE `ctl_materia`
  ADD PRIMARY KEY (`ID_Materia`);

--
-- Indices de la tabla `tlb_alumnos`
--
ALTER TABLE `tlb_alumnos`
  ADD PRIMARY KEY (`ID_Alumno`);

--
-- Indices de la tabla `tlb_clase`
--
ALTER TABLE `tlb_clase`
  ADD PRIMARY KEY (`ID_Clase`),
  ADD KEY `ID_Grupo` (`ID_Grupo`),
  ADD KEY `ID_Materia` (`ID_Materia`);

--
-- Indices de la tabla `tlb_horario`
--
ALTER TABLE `tlb_horario`
  ADD PRIMARY KEY (`ID_Horario`);

--
-- Indices de la tabla `tlb_profesor`
--
ALTER TABLE `tlb_profesor`
  ADD PRIMARY KEY (`ID_Profesor`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `ctl_asistencia`
--
ALTER TABLE `ctl_asistencia`
  ADD CONSTRAINT `ctl_asistencia_ibfk_1` FOREIGN KEY (`ID_Clase`) REFERENCES `tlb_clase` (`ID_Clase`),
  ADD CONSTRAINT `ctl_asistencia_ibfk_2` FOREIGN KEY (`ID_Alumno`) REFERENCES `tlb_alumnos` (`ID_Alumno`),
  ADD CONSTRAINT `ctl_asistencia_ibfk_3` FOREIGN KEY (`ID_Profesor`) REFERENCES `tlb_profesor` (`ID_Profesor`),
  ADD CONSTRAINT `ctl_asistencia_ibfk_4` FOREIGN KEY (`ID_Horario`) REFERENCES `tlb_horario` (`ID_Horario`),
  ADD CONSTRAINT `ctl_asistencia_ibfk_5` FOREIGN KEY (`ID_Lab`) REFERENCES `ctl_lab` (`ID_Lab`),
  ADD CONSTRAINT `ctl_asistencia_ibfk_6` FOREIGN KEY (`ID_Maquina`) REFERENCES `ctl_maqui` (`ID_Maquina`);

--
-- Filtros para la tabla `tlb_clase`
--
ALTER TABLE `tlb_clase`
  ADD CONSTRAINT `tlb_clase_ibfk_1` FOREIGN KEY (`ID_Grupo`) REFERENCES `ctl_grupo` (`ID_Grupo`),
  ADD CONSTRAINT `tlb_clase_ibfk_2` FOREIGN KEY (`ID_Materia`) REFERENCES `ctl_materia` (`ID_Materia`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
