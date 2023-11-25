# Pathfinder: Kingmaker mod template

This is a minimal C# project template for Pathfinder: Kingmaker mods. Expects the `Kingmaker_Data`
directory to be symlinked or copied to a sibling directory of the mod (see the
[csproj](PFKModTemplate.csproj)).


## Instalation

Clone this repository, then from the repository root:
```
dotnet new install .
```

## Usage

Create a new mod with:
```
dotnet new pfkmod -n ModName --au AuthorName
```

This will leave several fields set as "TODO" in the `Info.json` file. Alternatively, these can be
set on creation with the parameters documented in the help text:
```
dotnet new pfkmod --help
```
