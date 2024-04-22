# MPXJ.Net


# Tests

.Net Framework Coverage:

```
dotnet test /p:AltCover=true /p:AltCoverAssemblyExcludeFilter="MPXJ.Net.Tests|AltCover.Monitor|NUnit3.TestAdapter" -f net472 && reportgenerator -reports:MPXJ.Net.Tests/coverage.net472.xml -targetdir:coverage
```

.Net Coverage:

```
dotnet test /p:AltCover=true /p:AltCoverAssemblyExcludeFilter="MPXJ.Net.Tests|AltCover.Monitor|NUnit3.TestAdapter|Microsoft|testhost" -f net6.0 && reportgenerator -reports:MPXJ.Net.Tests/coverage.net6.0.xml -targetdir:coverage
```