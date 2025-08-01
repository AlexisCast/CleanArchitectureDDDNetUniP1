# CleanArchitectureDDDNetUniP1

## Branches - Sections of Course:

Section 2 - Domain Layer
-
- feat/1: Domain Layer - Create Solution and Project Domain
  - download [https://versionsof.net/core/8.0/8.0.0-rc.2/](https://versionsof.net/core/8.0/8.0.0-rc.2/)
  - Commands used:
    - ```
      dotnet --version
      dotnet --info
      dotnet new globaljson --sdk-version 8.0.100-rc.2.23502.2 --force
      dotnet new sln --name CleanArchitecture
      dotnet new classlib -o src/CleanArchitecture/CleanArchitecture.Domain
      dotnet sln add .\src\CleanArchitecture\CleanArchitecture.Domain\CleanArchitecture.Domain.csproj
    ``` 

## Course:

- [ASP.NET Core y Clean Architecture con Domain Driven Design P1](https://www.udemy.com/course/clean-architecture)

## Notes: 