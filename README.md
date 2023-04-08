# Flyingdarts.Utility.Templates
Contains project templates for the dotnet-new tools
## Installation
Install from NuGet
```pwsh
dotnet new install Flyingdarts.Utility.Templates
```
## Usage
Generate a `flyinglambda` template 

### Parameters
- (Required) `--name` 
- (Required) `--command` 

### Example
```pwsh
dotnet new flyinglambda --name Flyingdarts.Backend.Signalling.OnConnect --command OnConnectCommand
```
