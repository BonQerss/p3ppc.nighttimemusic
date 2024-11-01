# Reloaded Project Configurations

This page hosts the common configurations for various parts of the Reloaded project.

This includes:

- `.editorconfig` files for configuring code style.
- `Tests.Build.props` for common project settings for tests.
- `NuGet.Build.props` for common project settings that target NuGet.
- `Directory.Build.props` for common project settings.

## Usage

To use this repository, add it as a submodule to your project.

```
git submodule add https://github.com/Reloaded-Project/Reloaded.Project.Configurations.git ./src/Reloaded.Project.Configurations
```

Periodically update the submodule to the latest version.

```
git submodule update --remote
```

### Tests.Build.props

For test projects, modify your `.csproj` to include `Tests.Build.props` as follows:

```xml
<Import Project="../Reloaded.Project.Configurations/Tests.Build.props" />
```

You'll also need to add a startup class for Dependency Injection somewhere in the project

```csharp
public class Startup
{
    public void ConfigureServices(IServiceCollection services) { }
}
```

### NuGet.Build.props

For packages that are shipped to NuGet, modify your `.csproj` to include `NuGet.Build.props` as follows:

```xml
<Import Project="../Reloaded.Project.Configurations/NuGet.Build.props" />
```

The following remaining properties should be manually specified per package:

```xml
<PackageProjectUrl>https://github.com/Reloaded-Project/Reloaded.Memory</PackageProjectUrl>
<Description>Package Description.</Description>
<Version>1.0.0</Version>
<Product>Cool Library Name</Product>
```

### Directory.Build.props

For any other projects, modify your `.csproj` to include `Directory.Build.props` as follows:

```xml
<Import Project="../Reloaded.Project.Configurations/Directory.Build.props" />
```

## Code Style

The code style is defined in the `.editorconfig` file in the root of the repo.

To apply this to your project, do the following:

- Enable symlinks for your current project by running `git config core.symlinks true`.
- Make symlink to `Reloaded.Project.Configurations/.editorconfig` in the root of your project.
- In PowerShell you can
  do `New-Item -Path ".editorconfig" -ItemType SymbolicLink -Value "Reloaded.Project.Configurations/.editorconfig"` as
  admin.
- Or on Linux, you can do `ln -s "Reloaded.Project.Configurations/.editorconfig" ".editorconfig"`.

If you are on Windows, you may need to enable `Developer Mode` to be allowed to make symlinks.

### .solutionItems

In each project you should make a `.solutionItems` folder and add any useful files (as existing files) from the folder
the `.sln` is contained in; such that it's visible from the IDE. For example: `GitHub Actions`.

## File Layout

The following is the expected file layout for your project:

```
- docs/
- src/
```

The `docs` folder should contain all documentation for your project (if present).  
The `src` folder should contain all source code for your project.

## CI/CD Runs

For CI runs, you can use the following composite steps to set up the required tools and SDKs:

```yaml
- name: "Setup Reloaded Library SDKs & Components"
- uses: Reloaded-Project/Reloaded.Project.Configurations/.github/actions/setup-sdks-components@main
```

```yaml
# Showing default values, not all inputs are mandatory.
# Refer to actual upload-coverage-packages file for descriptions.
- name: "Upload Codecov Coverage, Changelog & NuGet Packages"
- uses: Reloaded-Project/Reloaded.Project.Configurations/.github/actions/upload-coverage-packages@main
  with:
    code-coverage-path: './Coverage.xml'
    changelog-path: './Changelog.md'
    nupkg-glob: './src/*.nupkg'
    nuget-key: ${{ secrets.NUGET_KEY }}
    changelog-template: 'keepachangelog'
    is-release: ${{ startsWith(github.ref, 'refs/tags/') }} # if 'true' publishes to GitHub Actions and NuGet
```

Replace `@main` with appropriate version tag if you want to pin to a specific version.

### Cross Targeting CI/CD Runs

Use the following template to run CI/CD for multiple target frameworks:

```yaml
name: Build, Test and Publish
on:
  push:
    branches: [ main ]
    paths:
      - "src/**"
    tags:
      - '*'
  pull_request:
    branches: [ main ]
    paths:
      - "src/**"
  workflow_dispatch:

jobs:
  build:
    strategy:
      matrix:
        os:
          - windows-latest
          - ubuntu-latest
          - macos-latest
        targetFramework:
          - net7.0
          - net6.0
          - net5.0
          - netcoreapp3.1
        platform:
          - x64
        include:
          - os: windows-latest
            targetFramework: net48
            platform: x64
          - os: windows-latest
            targetFramework: net48
            platform: x86
          - os: windows-latest
            targetFramework: net7.0
            platform: x86
          - os: windows-latest
            targetFramework: net6.0
            platform: x86
          - os: windows-latest
            targetFramework: net5.0
            platform: x86
          - os: windows-latest
            targetFramework: netcoreapp3.1
            platform: x86
            
    runs-on: ${{ matrix.os }}
    steps:
      - name: Checkout Code
        uses: actions/checkout@v4
        with:
          fetch-depth: 0
          submodules: 'recursive'
      - name: Setup Reloaded Library SDKs & Components
        uses: Reloaded-Project/Reloaded.Project.Configurations/.github/actions/setup-sdks-components@main
      - name: Build Library
        run: dotnet build -c Release -f ${{ matrix.targetFramework }} ./src/Reloaded.<XXX>.Tests/Reloaded.<XXX>.Tests.csproj
      - name: Run Tests
        run: dotnet test -c Release -f ${{ matrix.targetFramework }} ./src/Reloaded.<XXX>.Tests/Reloaded.<XXX>.Tests.csproj --collect:"XPlat Code Coverage;Format=opencover;" --results-directory "Coverage"
      - name: "Upload Coverage"
        uses: actions/upload-artifact@v4
        with:
          name: coverage-${{ matrix.os }}-${{ matrix.targetFramework }}-${{ matrix.platform }}
          path: Coverage/*/coverage.cobertura.xml
  upload:
    needs: build
    runs-on: ubuntu-latest
    steps:
      - name: "Checkout Code"
        uses: actions/checkout@v4
        with:
          fetch-depth: 0
          submodules: 'recursive'
      - name: "Setup Reloaded Library SDKs & Components"
        uses: Reloaded-Project/Reloaded.Project.Configurations/.github/actions/setup-sdks-components@main
      - name: Build Library
        run: dotnet build -c Release ./src
      - name: "Install ReportGenerator"
        run: dotnet tool install --global dotnet-reportgenerator-globaltool
      - name: "Download Coverage Artifacts"
        uses: actions/download-artifact@v4
        with:
            path: artifacts
      - name: "Merge Coverage Files"
        run: |
            dotnet tool install --global dotnet-coverage
            dotnet-coverage merge ./artifacts/*.cobertura.xml --recursive --output ./Cobertura.xml --output-format xml
      - name: "Upload Coverage & Packages"
        uses: Reloaded-Project/Reloaded.Project.Configurations/.github/actions/upload-coverage-packages@main
        with:
          code-coverage-path: './Cobertura.xml'
          changelog-path: './Changelog.md'
          nupkg-glob: './src/*.nupkg'
          nuget-key: ${{ secrets.NUGET_KEY }}
          changelog-template: 'keepachangelog'
          is-release: ${{ startsWith(github.ref, 'refs/tags/') }}
          release-tag: ${{ github.ref_name }}
```

The required components for reporting coverage should already be there provided `NuGet.Build.props` is included as
instructed
in your test project.

## Documentation

If documentation is required, please follow the guidelines
for [Reloaded MkDocs Theme](https://reloaded-project.github.io/Reloaded.MkDocsMaterial.Themes.R2/Pages/)
on how to set up documentation.

## Auto Fix Public API Analyzer Warnings

!!! tip

    [Rider does not have a way to apply Roslyn code fixes in a larger scope](https://youtrack.jetbrains.com/issue/RIDER-18372),
    so working with [Public API Analyzer](https://github.com/dotnet/roslyn-analyzers/blob/main/src/PublicApiAnalyzers/PublicApiAnalyzers.Help.md) might be painful.

To work around this, a `Powershell` script `FixUndeclaredAPIs.ps1` is included in repo root.
Use like this:

```powershell
.\FixUndeclaredAPIs.ps1 ../Your.Project/Your.Project.csproj
```

If you ever run into: `Could not load file or assembly 'Microsoft.CodeAnalysis, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35'. The system cannot find the file specified.`, remove source generator project dependency temporarily.

## License

This repository is licensed under the LGPLv3 license; as per the license of the Reloaded Project (sans. Reloaded
II/Reloaded3).
