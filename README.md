# CqrsSample

Projeto de estudo e referência para implementação do padrão **CQRS (Command Query Responsibility Segregation)** utilizando **.NET**, **MediatR** e **ASP.NET Core Web API**.

O objetivo deste repositório é servir como base didática e evolutiva para aplicações modernas, com separação clara de responsabilidades, foco em manutenção e boas práticas de arquitetura.

---

## 📌 Objetivos do Projeto

- Demonstrar o uso do **CQRS**
- Utilizar **MediatR** para desacoplamento entre camadas
- Estrutura inspirada em **Clean Architecture**
- Código simples, legível e evolutivo
- Base preparada para futura inclusão de **Infraestrutura (EF Core, Repositórios, etc.)**

---

## 🚀 Tecnologias

- [.NET SDK](https://dotnet.microsoft.com/)
- ASP.NET Core Web API
- MediatR
- C#
- Swagger (OpenAPI)

---

## ▶️ Como Executar

### Pré-requisitos
- .NET SDK instalado (8, 9 ou 10)

### Rodar a aplicação
```bash
dotnet restore
dotnet build
dotnet run --project CqrsSample/1.Api
