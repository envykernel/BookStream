# BookStream

BookStream is a book subscription service where clients can access books with a subscription. This project uses .NET 8 and follows the Domain-Driven Design (DDD) approach.

BookStream │ ├── src │ ├── BookStream.Domain │ │ ├── Entities │ │ ├── ValueObjects │ │ ├── Interfaces │ │ ├── Services │ │ └── Events │ │ │ ├── BookStream.Infrastructure │ │ ├── Data │ │ ├── Repositories │ │ ├── Configurations │ │ └── Services │ │ │ ├── BookStream.Application │ │ ├── DTOs │ │ ├── Interfaces │ │ ├── Services │ │ └── Mappings │ │ │ ├── BookStream.Web │ │ ├── Controllers │ │ ├── Models │ │ ├── Views │ │ └── wwwroot │ │ │ └── BookStream.Tests │ ├── DomainTests │ ├── InfrastructureTests │ ├── ApplicationTests │ └── WebTests │ ├── BookStream.sln └── README.md


## Steps to Set Up the Project

1. **Create the Project Structure**

    ```bash
    mkdir -p BookStream/src/BookStream.Domain/{Entities,ValueObjects,Interfaces,Services,Events}
    mkdir -p BookStream/src/BookStream.Infrastructure/{Data,Repositories,Configurations,Services}
    mkdir -p BookStream/src/BookStream.Application/{DTOs,Interfaces,Services,Mappings}
    mkdir -p BookStream/src/BookStream.Web/{Controllers,Models,Views,wwwroot}
    mkdir -p BookStream/src/BookStream.Tests/{DomainTests,InfrastructureTests,ApplicationTests,WebTests}
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

4. **Restore and Build the Solution**

    ```bash
    dotnet restore
    dotnet build
    ```

5. **Run the Web Project**

    ```bash
    dotnet run --project src/BookStream.Web/BookStream.Web.csproj
    ```