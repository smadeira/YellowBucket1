dotnet tool install --global dotnet-ef
dotnet tool update --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef
dotnet ef migrations list -v
dotnet ef migrations add InitialCreate -v
Write-Host "Press any key to continue ....."
$x = $host.UI.RawUI.ReadKey("NoEcho,IncludeKeyDown")