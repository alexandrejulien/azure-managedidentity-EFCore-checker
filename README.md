# Azure Managed Identity EF Core Checker

This application is dummy tester for a EF6 / EF7 issue with Azure Managed Identity on Azure AppService.

On EF6, the connectionstring works very well but with EF7 and the SQL Client dependancy fails on this tests.

## Usage

```powershell
AzureManagedIdentityEFCoreTester.EF6 "<connectionstring>"

AzureManagedIdentityEFCoreTester.EF7 "<connectionstring>"
```
