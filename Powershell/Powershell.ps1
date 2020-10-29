cd ".."
cd "YellowBucket1"
dotnet tool install --global dotnet-ef
dotnet tool update --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef
dotnet ef migrations list -v
dotnet ef migrations add InitialCreate -v
dotnet ef migrations script | Out-File -FilePath Migrations\InitialCreateSQL.txt
dotnet ef database update
Write-Host "Press any key to continue ....."
$x = $host.UI.RawUI.ReadKey("NoEcho,IncludeKeyDown")
