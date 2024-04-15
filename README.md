# mpxj.net

.Net Framework Coverage:

```
dotnet test /p:AltCover=true /p:AltCoverAssemblyExcludeFilter="mpxj.net.tests|AltCover.Monitor|NUnit3.TestAdapter" -f net462 && reportgenerator -reports:mpxj.net.tests/coverage.net462.xml -targetdir:coverage
```

.Net Coverage:

```
dotnet test /p:AltCover=true /p:AltCoverAssemblyExcludeFilter="mpxj.net.tests|AltCover.Monitor|NUnit3.TestAdapter|Microsoft|testhost" -f net8.0 && reportgenerator -reports:mpxj.net.tests/coverage.net8.0.xml -targetdir:coverage
```