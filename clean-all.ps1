# Uninstall the template if it's already installed
dotnet new uninstall Flyingdarts.Utility.Templates -v m

# Build the project
dotnet pack

# Install the template from the package
$packageName = "bin\Debug\Flyingdarts.Utility.Templates.1.0.5.nupkg"
dotnet new install $packageName