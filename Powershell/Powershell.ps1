cd ".."
cd "YellowBucket1"

dotnet tool uninstall --global dotnet-ef 
dotnet tool install --global dotnet-ef --version 3.1.9

dotnet ef
dotnet ef migrations list -v --context MoviesContext

dotnet ef migrations add InitialCreateV4.2 -v --context MoviesContext
dotnet ef migrations script --context MoviesContext | Out-File -FilePath Migrations\InitialCreateSQL.txt
dotnet ef database update --context MoviesContext

Write-Host "Press any key to continue ....."
$x = $host.UI.RawUI.ReadKey("NoEcho,IncludeKeyDown")
