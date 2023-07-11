-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 10/07/2023 às 20:14
-- Versão do servidor: 10.4.28-MariaDB
-- Versão do PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `estacionamento`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `cartao`
--

CREATE TABLE `cartao` (
  `Id` int(11) NOT NULL,
  `Codigo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `cartao`
--

INSERT INTO `cartao` (`Id`, `Codigo`) VALUES
(1, 1),
(2, 2);

-- --------------------------------------------------------

--
-- Estrutura para tabela `estacionamento`
--

CREATE TABLE `estacionamento` (
  `Id` int(11) NOT NULL,
  `QtdVagas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `estacionamento`
--

INSERT INTO `estacionamento` (`Id`, `QtdVagas`) VALUES
(1, 100),
(2, 150);

-- --------------------------------------------------------

--
-- Estrutura para tabela `movimentacao`
--

CREATE TABLE `movimentacao` (
  `Id` int(11) NOT NULL,
  `IdEstacionamento` int(11) NOT NULL,
  `DataEntrada` datetime NOT NULL,
  `DataSaida` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `movimentacao`
--

INSERT INTO `movimentacao` (`Id`, `IdEstacionamento`, `DataEntrada`, `DataSaida`) VALUES
(1, 1, '2023-07-10 14:00:00', '2023-07-10 15:04:45'),
(2, 1, '2023-07-10 15:05:30', '2023-07-10 17:05:30');

-- --------------------------------------------------------

--
-- Estrutura para tabela `tipoveiculo`
--

CREATE TABLE `tipoveiculo` (
  `Id` int(11) NOT NULL,
  `Descricao` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `tipoveiculo`
--

INSERT INTO `tipoveiculo` (`Id`, `Descricao`) VALUES
(1, 'Veículo pequeno'),
(2, 'Veículo grande'),
(3, 'Moto');

-- --------------------------------------------------------

--
-- Estrutura para tabela `turno`
--

CREATE TABLE `turno` (
  `Id` int(11) NOT NULL,
  `Periodo` varchar(50) NOT NULL,
  `Escala` int(11) NOT NULL,
  `IdEstacionamento` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `turno`
--

INSERT INTO `turno` (`Id`, `Periodo`, `Escala`, `IdEstacionamento`) VALUES
(1, 'Matutino', 8, 1),
(2, 'Vespertino', 8, 1),
(3, 'Noturno', 8, 1);

-- --------------------------------------------------------

--
-- Estrutura para tabela `usuario`
--

CREATE TABLE `usuario` (
  `Id` int(11) NOT NULL,
  `Nome` varchar(75) NOT NULL,
  `CPF` varchar(16) NOT NULL,
  `PIS` varchar(11) NOT NULL,
  `Permissao` varchar(20) NOT NULL,
  `Senha` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `usuario`
--

INSERT INTO `usuario` (`Id`, `Nome`, `CPF`, `PIS`, `Permissao`, `Senha`) VALUES
(1, 'eduardo', '123.456.789-12', '12345678901', 'ADM', '123'),
(2, 'roberto', '111.111.111-11', '11111111111', 'padrao', '123');

-- --------------------------------------------------------

--
-- Estrutura para tabela `veiculo`
--

CREATE TABLE `veiculo` (
  `Id` int(11) NOT NULL,
  `Placa` varchar(20) NOT NULL,
  `IdMovimentacao` int(11) NOT NULL,
  `IdTipo` int(11) NOT NULL,
  `IdCartao` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `veiculo`
--

INSERT INTO `veiculo` (`Id`, `Placa`, `IdMovimentacao`, `IdTipo`, `IdCartao`) VALUES
(1, 'LKJ4N33', 1, 1, 1),
(2, 'RRP2V11', 2, 2, 2);

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `cartao`
--
ALTER TABLE `cartao`
  ADD PRIMARY KEY (`Id`);

--
-- Índices de tabela `estacionamento`
--
ALTER TABLE `estacionamento`
  ADD PRIMARY KEY (`Id`);

--
-- Índices de tabela `movimentacao`
--
ALTER TABLE `movimentacao`
  ADD PRIMARY KEY (`Id`);

--
-- Índices de tabela `tipoveiculo`
--
ALTER TABLE `tipoveiculo`
  ADD PRIMARY KEY (`Id`);

--
-- Índices de tabela `turno`
--
ALTER TABLE `turno`
  ADD PRIMARY KEY (`Id`);

--
-- Índices de tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`Id`);

--
-- Índices de tabela `veiculo`
--
ALTER TABLE `veiculo`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cartao`
--
ALTER TABLE `cartao`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `estacionamento`
--
ALTER TABLE `estacionamento`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `movimentacao`
--
ALTER TABLE `movimentacao`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `tipoveiculo`
--
ALTER TABLE `tipoveiculo`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `turno`
--
ALTER TABLE `turno`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `usuario`
--
ALTER TABLE `usuario`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `veiculo`
--
ALTER TABLE `veiculo`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
