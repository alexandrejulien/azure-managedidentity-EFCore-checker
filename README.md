# Azure Managed Identity EF Core Checker

This application is dummy tester for a EF6 / EF7 issue with Azure Managed Identity on Azure AppService.

On EF6, the connectionstring works very well but with EF7 and the SQL Client dependancy fails on this tests.

## Usage

```powershell
AzureManagedIdentityEFCoreTester.EF6 "Server=tcp:<hostname>,<port>;Initial Catalog=mydb;Authentication=Active Directory Managed Identity;User ID=<principal-id>;MultipleActiveResultSets=True;Encrypt=True;Connection Timeout=300;"

AzureManagedIdentityEFCoreTester.EF7 "Server=tcp:<hostname>,<port>;Initial Catalog=mydb;Authentication=Active Directory Managed Identity;User ID=<principal-id>;MultipleActiveResultSets=True;Encrypt=True;Connection Timeout=300;"
```

The request works well with EF6 and it's raise a 400 HTTP Code error with EF7.