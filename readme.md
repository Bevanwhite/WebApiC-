-   to create a webapi project
    -   `dotnet new webapi -n <project-name> -f net6.0`
-   to add project to the solution
    -   `dotnet sln YourSolution.sln add path/to/YourProject.csproj`
-   to remove a project from a solution
    -   `dotnet sln YourSolution.sln remove path/to/YourProject.csproj`
-   how to create project reference using .net cli
    -   `dotnet add <your_project>.csproj reference <path_to_other_project>.csproj`
-   how to add multiple project to the project file
    -   `dotnet add reference ../Lib1/Lib1.csproj ../Lib2/Lib2.csproj`
-   how to add class library
    -   `dotnet new classlib -n <project-name> -f net6.0`
-   how to add a dotnet package
    -   `dotnet add package NLog.Extensions.Logging --version 1.7.4`
    -   `dotnet add ./MyApp/MyApp.csproj package NLog.Extensions.Logging --version 1.7.4`
-   how to add a migration
    -   `dotnet ef migrations add DatabaseCreation`
    -   `dotnet ef migrations add DatabaseCreation --project MyApp.Data --startup-project MyApp.Web`
-   how to update the database
    -   `dotnet ef database update`
    -   `dotnet ef database update --project MyApp.Data --startup-project MyApp.Web`
