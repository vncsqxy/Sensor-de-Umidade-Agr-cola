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

## 🔄 Fluxo de Dados

```text
SensorSimulator → ApiProcessamento → SQLite → SensorInterface

🚀 Como Executar o Projeto

Pré-requisitos:

.NET SDK instalado (versão compatível com o projeto)
1. Clonar o repositório
git clone <url-do-repositorio>
cd <nome-do-projeto>

2. Iniciar a API
cd ApiProcessamento
dotnet run


A API estará disponível em:

http://localhost:<porta>


Swagger:

http://localhost:<porta>/swagger

3. Iniciar a Interface (WPF)

Abra um novo terminal:

cd SensorInterface
dotnet run

4. Iniciar o Simulador de Sensores

Abra outro terminal:

cd SensorSimulator
dotnet run

📊 Funcionalidades
📡 Simulação de sensores IoT
📥 Ingestão de dados em tempo real
💾 Persistência em banco de dados relacional
📈 Visualização de dados via dashboard desktop
🔄 Atualização contínua e sincronizada
🧩 Arquitetura modular e reutilizável
📐 Boas Práticas Aplicadas
Separação de responsabilidades (SRP)
Arquitetura em camadas
Padrão MVVM no frontend
Reutilização de código via biblioteca compartilhada
Uso de ORM para abstração de dados
Documentação automática com Swagger
🔮 Possíveis Evoluções
Deploy em nuvem (Azure / AWS)
Uso de banco de dados distribuído
Autenticação e autorização (JWT)
Integração com dispositivos IoT reais
Dashboard web (Blazor ou React)
Sistema de alertas baseado em thresholds
👨‍💻 Autor

Vinícius Augusto

Projeto desenvolvido como entrega final da Situação de Aprendizagem (SA) de Programação em C#.
