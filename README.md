# OperationsPortal.Classic

## Overview
Sistema de chamados (Tickets) para Service Desk / suporte ao cliente.

## Description
Criei este sistema para estruturar o desenvolvimento de uma aplicação em camadas, com o objetivo de construir uma solução escalável e segura para suporte a solicitações de atendimento. Além do uso de boas práticas estruturais e operacionais para banco de dados.  

Durante a construção, quero mostrar um pouco do meu trabalho como dev e exemplificar formas de montar esse tipo de projeto com uma estrutura robusta e uma stack usual.

![preview](https://i.pinimg.com/originals/96/25/1e/96251e36ce717d55f4c61a081ab9180a.gif)

## Tech stack / Architecture (Planned)
- Front-end: ASP.NET MVC 5, Bootstrap, jQuery
- Back-end: C# / ASP.NET Web API 2
- Authentication: JWT Bearer (planned)
- Layers: Domain, Data, Shared
- ORM: Entity Framework 6
- Database evolution: Migrations
- Modeling strategy: Database First
- Database: SQL Server
- DB Tool: SSMS
- IDE: Visual Studio 2022

## Solution Structure
- OperationsPortal.Api
- OperationsPortal.MVC
- OperationsPortal.Data
- OperationsPortal.Domain
- OperationsPortal.Shared

## How to Run Locally
1. Restore NuGet packages.
2. Configure the local connection string.
3. Set the startup project.
4. Run using IIS Express.

## Notes
- Real database credentials are not versioned for security.
- JWT authentication will be added in a later phase.
