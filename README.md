# Razor-EFCore
Razor avec Entity Framework Core

***DB Browser for SQLite
https://sqlitebrowser.org/


https://learn.microsoft.com/fr-fr/aspnet/core/data/ef-rp/intro?view=aspnetcore-9.0&tabs=visual-studio


Il s’agit du premier tutoriel d’une série qui montre comment utiliser Entity Framework (EF) Core dans une application Pages Razor ASP.NET Core. Dans ces tutoriels, un site web est créé pour une université fictive nommée Contoso. Le site comprend des fonctionnalités comme l’admission des étudiants, la création de cours et les affectations des formateurs. Le tutoriel utilise l’approche code first. Pour plus d’informations sur la façon de suivre ce tutoriel à l’aide de l’approche database first, consultez ce problème Github.

***** start 
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet tool install --global dotnet-ef
dotnet tool update --global dotnet-ef




***The Entity Framework Core tools help with design-time development tasks. They're primarily used to manage Migrations and to scaffold a DbContext and entity types by reverse engineering the schema of a database.This package, Microsoft.EntityFrameworkCore.Tools is for PowerShell tooling that works in the Visual Studio Package Manager Console (PMC).

dotnet add package Microsoft.EntityFrameworkCore.Tools

***ASP.NET Core middleware for Entity Framework Core error pages. Use this middleware to detect and diagnose errors with Entity Framework Core migrations.
dotnet add package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore


***** Sql Sqlite
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.EntityFrameworkCore.SqlServer


*****  Outil générateur de code ASP.NET Core

prérequis : dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design

dotnet tool install -g dotnet-aspnet-codegenerator
dotnet tool update -g dotnet-aspnet-codegenerator


générer les page correspondant au modèle 
export codegen_trace=1
dotnet aspnet-codegenerator razorpage -m Student -dc ContosoUniversity.Data.SchoolContext -udl -outDir Pages\Students --referenceScriptLibraries --databaseProvider sqlite


