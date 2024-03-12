# mpxj.net

Coverage:

```
dotnet test /p:AltCover=true /p:AltCoverAssemblyExcludeFilter="mpxj.net.tests|AltCover.Monitor|NUnit3.TestAdapter" -f net462 && reportgenerator -reports:mpxj.net.tests/coverage.net462.xml -targetdir:coverage
```