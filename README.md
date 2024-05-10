# MPXJ.Net


## Deploy

```
dotnet clean MPXJ.Net.sln
dotnet build --configuration Release MPXJ.Net.sln
dotnet nuget push MPXJ.Net\bin\Release\MPXJ.Net.12.9.3-alpha.8.nupkg --api-key $env:NUGETTEST_API_KEY --source https://apiint.nugettest.org/v3/index.json
```



## Tests

.Net Framework Coverage:

```
dotnet test /p:AltCover=true /p:AltCoverAssemblyExcludeFilter="MPXJ.Net.Tests|AltCover.Monitor|NUnit3.TestAdapter" -f net472 && reportgenerator -reports:MPXJ.Net.Tests/coverage.net472.xml -targetdir:coverage
```

.Net Coverage:

```
dotnet test /p:AltCover=true /p:AltCoverAssemblyExcludeFilter="MPXJ.Net.Tests|AltCover.Monitor|NUnit3.TestAdapter|Microsoft|testhost" -f net6.0 && reportgenerator -reports:MPXJ.Net.Tests/coverage.net6.0.xml -targetdir:coverage
```