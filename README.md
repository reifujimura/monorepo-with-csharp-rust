# Rust FFI and .NET Core P/Invoke demo

Call Rust function from .NET using Rust FFI and .NET P/Invoke.

## Run Test

When you run the "dotnet test" command in the "dotnet" directory, Rust library and .NET Standard library are automatically built and run test.

```sh
dotnet test (-c Release)
```

## Run Sample App

```sh
dotnet run --project csharp/MonorepoWithCSharpRust.App
```
