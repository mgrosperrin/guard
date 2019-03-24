MGR.Guard documentation
===

`MGR.Guard` is small library to check the validity of arguments, parameters, variables...

## To install the latest stable version:

Via the dotnet CLI:
```
> dotnet add package MGR.Guard
```
Via the package manager (in Visual Studio):
```powershell
PM> Install-Package MGR.Guard
```

## How to use it
The entry point of the library is the static propery `MGR.Guard.Guardian.ChecksThat`.
The methods allow you to guard against null value, lower or upper bound, file existence.
If the check fails, an exception is thrown.

All built-in methods exists in two flavors:

1. The first takes the value to check and the name of the value (to provide to the thrown exection),
2. The second takes [an expression](guard-expression.md) from which the value and its name are extracted.

*The first form is much more performant (~600x), but the second one is more maintenable.**

You can find all [built-in methods here](guard.md), or [browse the API](/api).

## What if the provided methods are not enough?

Unlike many other libraries, `MGR.Guard` is built with extensibility in mind:
all methods are extensions methods, which means you can add your owns.
Please [read this](extensibility.md) if you want to add your own check.

## Alternate installation method
Also, in order to limit the dependency (specially if you are building a domain), the library is available as a [Source Code Only NuGet package](https://medium.com/@attilah/source-code-only-nuget-packages-8f34a8fb4738):
 [MAF.Guard.Sources](guard-sources.md).
