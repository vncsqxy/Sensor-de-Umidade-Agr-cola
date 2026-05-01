SISTEMA DE MONITORAMENTO AGRICOLA

Sistema desenvolvido em .NET para simulação, processamento e exibição de dados de sensores de umidade agrícola em tempo real.

ESTRUTURA DO PROJETO

ApiProcessamento: API REST em ASP.NET Core com persistência em banco de dados SQLite via Entity Framework.

SensorInterface: Dashboard desktop em WPF estruturado no padrão MVVM para exibição visual dos dados.

SensorSimulator: Aplicação Console que atua como hardware IoT, gerando e enviando dados.

Shared: Biblioteca compartilhada de modelos e regras de negócio para manter a consistência entre as aplicações.

TECNOLOGIAS UTILIZADAS

Linguagem: C# (.NET)

Banco de Dados: SQLite com Entity Framework Core

Interface Visual: WPF com padrão MVVM

Documentação da API: Swagger

COMO EXECUTAR O PROJETO

Abra o terminal do seu computador e execute os projetos na seguinte ordem:

Iniciar o Banco e a API
Navegue até a pasta "ApiProcessamento" e digite o comando: dotnet run

Iniciar o Dashboard Visual
Abra um novo terminal, navegue até a pasta "SensorInterface" e digite o comando: dotnet run

Iniciar o Simulador de Sensores
Abra um terceiro terminal, navegue até a pasta "SensorSimulator" e digite o comando: dotnet run

Desenvolvido por Vinícius como entrega final da SA de Programação C#.
