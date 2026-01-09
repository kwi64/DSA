### Creating projects

```bash
# new console project
dotnet new console --name '<StepNumber>_<StepTitle>'

# new test project
dotnet new nunit --name '<StepNumber>_<StepTitle>.Test'
```

### Adding projects to solution
```bash
dotnet sln add '<StepNumber>_<StepTitle>' -s src
dotnet sln add '<StepNumber>_<StepTitle>.Tests' -s test
```

### Working with project references
```bash
cd '<StepNumber>_<StepTitle>.Tests'
dotnet add reference '../<StepNumber>_<StepTitle>'
dotnet remove reference '../<StepNumber>_<StepTitle>.csproj'
```


### A usual Console csproj config
```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <RootNamespace><!-- _<StepNumber>_<StepTitle> --></RootNamespace>
    <ImplicitUsings>disable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <StartupObject><!-- _<StepNumber>_<StepTitle>.LC_<QuestionNumber>_<Question> --></StartupObject>
  </PropertyGroup>

  <ItemGroup>
    <InternalsVisibleTo Include="<StepNumber>_<StepTitle>.Tests" />
  </ItemGroup>

</Project>
```
