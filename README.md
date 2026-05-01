# 🌱 Sistema de Monitoramento Agrícola

> Plataforma completa em **.NET** para simulação, processamento e visualização em tempo real de dados de sensores de umidade do solo.

---

## 📖 Visão Geral

O **Sistema de Monitoramento Agrícola** foi projetado para simular um ambiente de agricultura inteligente, integrando sensores IoT, processamento de dados e visualização em tempo real.

A solução segue princípios de **arquitetura modular**, **separação de responsabilidades** e **boas práticas de desenvolvimento em .NET**, permitindo escalabilidade, manutenção facilitada e reuso de código.

---

## 🧱 Arquitetura do Sistema

A aplicação é composta por quatro projetos principais:

### 🔹 `ApiProcessamento`
API REST construída com **ASP.NET Core**, responsável por:
- Receber dados dos sensores simulados
- Processar e validar informações
- Persistir dados no banco de dados
- Expor endpoints para consumo

**Tecnologias:**
- ASP.NET Core
- Entity Framework Core
- SQLite
- Swagger (OpenAPI)

---

### 🔹 `SensorInterface`
Aplicação desktop desenvolvida em **WPF**, utilizando o padrão **MVVM (Model-View-ViewModel)**.

**Responsabilidades:**
- Exibição de dados em tempo real
- Interface visual para monitoramento
- Consumo da API

---

### 🔹 `SensorSimulator`
Aplicação Console que simula dispositivos IoT.

**Responsabilidades:**
- Geração automática de dados de umidade
- Envio contínuo de dados para a API
- Simulação de comportamento de sensores reais

---

### 🔹 `Shared`
Biblioteca compartilhada entre os projetos.

**Contém:**
- Modelos de domínio
- DTOs
- Regras de negócio reutilizáveis

**Objetivo:**
Garantir consistência e evitar duplicação de código.

---

## ⚙️ Tecnologias Utilizadas

| Categoria            | Tecnologia                     |
|---------------------|------------------------------|
| Linguagem           | C# (.NET)                    |
| Backend             | ASP.NET Core                 |
| ORM                 | Entity Framework Core        |
| Banco de Dados      | SQLite                       |
| Interface Desktop   | WPF                          |
| Arquitetura UI      | MVVM                         |
| Documentação API    | Swagger (OpenAPI)            |

---

