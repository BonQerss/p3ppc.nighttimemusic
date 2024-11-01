param (
    [Parameter(Mandatory = $true)]
    [string]$CsProj
)

$numTargetFrameworks = 8
$command = "dotnet"
$arguments = @("format", "analyzers", $CsProj, "--diagnostics", "RS0037", "RS0036", "RS0016", "RS0017")

for ($i = 1; $i -le $numTargetFrameworks; $i++)
{
    Write-Host "Executing command: $command $( $arguments -join ' ' ) (framework $i)"
    & $command $arguments
}
