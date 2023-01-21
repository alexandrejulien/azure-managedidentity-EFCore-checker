using AzureManagedIdentityEFCoreTester.EF6.Data;
using Microsoft.EntityFrameworkCore;

string efVersion = typeof(DbContext).Assembly.GetName().Version.ToString();
string[] commandLineArgs = Environment.GetCommandLineArgs();

if (commandLineArgs.Length != 2)
{
    throw new ArgumentException("You have to pass connection String at the first argument");
}

string connectionString = commandLineArgs[1];

Console.WriteLine($"Testing EF Core with {efVersion} and with the follow connectionstring : \n {connectionString}");

var tester = new DatabaseAccessTester(connectionString);
tester.TestDbConnection();


