# Test work

This is a project for a specific test work.

## Description

The application uses in-memory database to keep the test work and it's setup simple. For real application persistent database would be used.

The test work does not have any authentication or authorization that would be essential for real application. Exceptions can be done for internal applications with secure infrastructure.

For more complex business logic there would be also some unit tests.

The application generates it's own documentation and is available at https://localhost:7181/swagger/index.html when running in local computer.

## Requires

 * [.NET 6.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

## Build

Use your favourite .NET IDE and build the project or run from terminal:

```
dotnet build
```

## Run


Run from your favourite .NET IDE or from terminal:

```
dotnet run --project TestWork
```

The application opens up it's Swagger documentation page automatically when started.

Note: when stopping the application it's content is cleared due to in-memory database.