# Set Working Directory
Split-Path $MyInvocation.MyCommand.Path | Push-Location
[Environment]::CurrentDirectory = $PWD

Remove-Item "$env:RELOADEDIIMODS/p3ppc.nighttimemusic/*" -Force -Recurse
dotnet publish "./p3ppc.nighttimemusic.csproj" -c Release -o "$env:RELOADEDIIMODS/p3ppc.nighttimemusic" /p:OutputPath="./bin/Release" /p:ReloadedILLink="true"

# Restore Working Directory
Pop-Location