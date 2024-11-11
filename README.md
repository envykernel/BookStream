# BookStream

BookStream is a book subscription service where clients can access books with a subscription. This project uses .NET 8 and follows the Domain-Driven Design (DDD) approach.

BookStream
│
├── src
│   ├── BookStream.Domain
│   │   ├── Books                // Fonctionnalité "Books" dans le domaine
│   │   │   ├── Entities         // Entités liées aux livres
│   │   │   ├── ValueObjects     // Objets de valeur spécifiques aux livres
│   │   │   ├── Interfaces       // Interfaces pour les livres (par ex., IBookRepository)
│   │   │   ├── Services         // Services métier propres aux livres
│   │   │   └── Events           // Événements liés aux livres
│   │   ├── Clients              // Fonctionnalité "Clients"
│   │   ├── Subscriptions        // Fonctionnalité "Subscriptions"
│   │   └── ...
│   │
│   ├── BookStream.Infrastructure
│   │   ├── Books                // Fonctionnalité "Books" dans l'infrastructure
│   │   │   ├── Repositories     // Implémentation des repositories spécifiques aux livres
│   │   │   ├── Configurations   // Configurations pour les entités "Books"
│   │   │   └── Services         // Services d'infrastructure propres aux livres (ex : external API, data caching)
│   │   ├── Clients              // Fonctionnalité "Clients"
│   │   ├── Subscriptions        // Fonctionnalité "Subscriptions"
│   │   └── ...
│   │
│   ├── BookStream.Application
│   │   ├── Books                // Fonctionnalité "Books" dans l'application
│   │   │   ├── DTOs             // DTOs propres aux livres
│   │   │   ├── Interfaces       // Interfaces de services d'application pour les livres
│   │   │   ├── Services         // Services d'application propres aux livres
│   │   │   └── Mappings         // Mappings pour la conversion entre entités et DTOs pour les livres
│   │   ├── Clients              // Fonctionnalité "Clients"
│   │   ├── Subscriptions        // Fonctionnalité "Subscriptions"
│   │   └── ...
│   │
│   ├── BookStream.Web
│   │   ├── Books                // Fonctionnalité "Books" dans la couche Web
│   │   │   ├── Controllers      // Contrôleurs liés aux livres
│   │   │   ├── Models           // Modèles pour la vue propres aux livres
│   │   │   ├── Views            // Vues pour les livres
│   │   │   └── wwwroot          // Fichiers statiques spécifiques aux livres (s'il y en a)
│   │   ├── Clients              // Fonctionnalité "Clients"
│   │   ├── Subscriptions        // Fonctionnalité "Subscriptions"
│   │   └── ...
│
├── BookStream.Tests
│   ├── Books                    // Tests pour la fonctionnalité "Books"
│   │   ├── DomainTests
│   │   ├── InfrastructureTests
│   │   ├── ApplicationTests
│   │   └── WebTests
│   ├── Clients                  // Tests pour la fonctionnalité "Clients"
│   └── Subscriptions            // Tests pour la fonctionnalité "Subscriptions"
│
└── BookStream.sln



## Steps to Set Up the Project

1. **Create the Project Structure**

    ```bash
    mkdir -p BookStream/src/BookStream.Domain/Books/{Entities,ValueObjects,Interfaces,Services,Events}
    mkdir -p BookStream/src/BookStream.Infrastructure/Books/{Data,Repositories,Configurations,Services}
    mkdir -p BookStream/src/BookStream.Application/Books/{DTOs,Interfaces,Services,Mappings}
    mkdir -p BookStream/src/BookStream.Web/Books/{Controllers,Models,Views,wwwroot}
    mkdir -p BookStream/src/BookStream.Tests/Books/{DomainTests,InfrastructureTests,ApplicationTests,WebTests}
    ```

2. **Create the Solution and Projects**

    ```bash
    dotnet new sln -o BookStream
    cd BookStream
    dotnet new classlib -n BookStream.Domain -o src/BookStream.Domain
    dotnet new classlib -n BookStream.Infrastructure -o src/BookStream.Infrastructure
    dotnet new classlib -n BookStream.Application -o src/BookStream.Application
    dotnet new webapi -n BookStream.Web -o src/BookStream.Web
    dotnet new xunit -n BookStream.Tests -o src/BookStream.Tests
    ```

3. **Add Projects to the Solution**

    ```bash
    dotnet sln add src/BookStream.Domain/BookStream.Domain.csproj
    dotnet sln add src/BookStream.Infrastructure/BookStream.Infrastructure.csproj
    dotnet sln add src/BookStream.Application/BookStream.Application.csproj
    dotnet sln add src/BookStream.Web/BookStream.Web.csproj
    dotnet sln add src/BookStream.Tests/BookStream.Tests.csproj
    ```

4. **References between layers**
dotnet add src/BookStream.Infrastructure/BookStream.Infrastructure.csproj reference src/BookStream.Domain/BookStream.Domain.csproj
dotnet add src/BookStream.Application/BookStream.Application.csproj reference src/BookStream.Domain/BookStream.Domain.csproj
dotnet add src/BookStream.Application/BookStream.Application.csproj reference src/BookStream.Infrastructure/BookStream.Infrastructure.csproj
dotnet add src/BookStream.Web/BookStream.Web.csproj reference src/BookStream.Application/BookStream.Application.csproj

5. **Essential NuGet packages**
dotnet add src/BookStream.Infrastructure/BookStream.Infrastructure.csproj package Microsoft.EntityFrameworkCore
dotnet add src/BookStream.Infrastructure/BookStream.Infrastructure.csproj package Npgsql.EntityFrameworkCore.PostgreSQL
dotnet add src/BookStream.Infrastructure/BookStream.Infrastructure.csproj package Microsoft.EntityFrameworkCore.Tools
dotnet add src/BookStream.Application/BookStream.Application.csproj package AutoMapper
dotnet add src/BookStream.Application/BookStream.Application.csproj package AutoMapper.Extensions.Microsoft.DependencyInjection
dotnet add src/BookStream.Web/BookStream.Web.csproj package Microsoft.Extensions.DependencyInjection
dotnet add src/BookStream.Web/BookStream.Web.csproj package Microsoft.AspNetCore.Mvc

# Restore packages
dotnet restore

6. **Restore and Build the Solution**

    ```bash
    dotnet restore
    dotnet build
    ```

7. **Run the Web Project**

    ```bash
    dotnet run --project src/BookStream.Web/BookStream.Web.csproj
    ```