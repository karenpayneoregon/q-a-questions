# About

Feeling out C# 11/.NET Core 7 and EF Core 7 and with that all works but may be a tad chaotic but all code works. All code except EF Core is in `Classes\Program`


# EF Core 7

Note on EF Core 7 `Encrypt defaults to true for SQL Server connections` so for prior versions of EF Core the following works but will fail with EF Core

```
Data Source=.\\SQLEXPRESS;Initial Catalog=CustomerDatabase1;Integrated Security=True;
```

The change is to add `Encrypt=False`

```
Data Source=.\\SQLEXPRESS;Initial Catalog=CustomerDatabase1;Integrated Security=True;Encrypt=False
```

:small_blue_diamond: [Mitigations](https://learn.microsoft.com/en-us/ef/core/what-is-new/ef-core-7.0/breaking-changes#mitigations)

Connections are done `without` *dependency injection* using the following [NuGet package](https://www.nuget.org/packages/ConfigurationLibrary/) by Karen Payne.

appsettings.json

```json
{
  "ConnectionsConfiguration": {
    "ActiveEnvironment": "Development",
    "Development": "Data Source=.\\SQLEXPRESS;Initial Catalog=CustomerDatabase1;Integrated Security=True;Encrypt=False",
    "Stage": "Stage connection string goes here",
    "Production": "Prod connection string goes here"
  }
}
```


# Console

- NuGet Package [Spectre.Console](https://www.nuget.org/packages/Spectre.Console/0.45.0)
- NuGet package [ConsoleHelperLibrary](https://www.nuget.org/packages/ConsoleHelperLibrary)


