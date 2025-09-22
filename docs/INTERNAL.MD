```bash
cd src
dotnet new console -n Program --use-program-main
dotnet new classlib -n Library
# Referencias
cd Program
dotnet add Program.csproj reference ../Library/Library.csproj
cd ../..
mkdir test
cd test
dotnet new nunit -n Library.Tests
cd Library.Tests
dotnet add Library.Tests.csproj reference ../../src/Library/Library.csproj
cd ../..
dotnet sln add src/Library/Library.csproj
dotnet sln add src/Program/Program.csproj
dotnet sln add test/Library.Tests/Library.Tests.csproj
```