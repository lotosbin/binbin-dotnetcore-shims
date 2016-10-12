dotnet restore
dotnet build .\src\binbin-dotnetcore-shims

dotnet test .\test\unittests

dotnet pack .\src\binbin-dotnetcore-shims

$project = Get-Content .\src\binbin-dotnetcore-shims\project.json | ConvertFrom-Json
$version = $project.version.Trim("-*")
nuget push .\src\binbin-dotnetcore-shims\bin\Debug\binbin-dotnetcore-shims.$version.nupkg -source nuget -apikey $env:NUGET_API_KEY