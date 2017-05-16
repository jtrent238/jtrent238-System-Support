Write-Output 'Getting a list of all installed programs on your pc, please wait....'

if (([Security.Principal.WindowsPrincipal][Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole] "Administrator"))
{Write-Output 'Running as Administrator!'}
else
{Write-Output 'Running Limited!'}

Get-WmiObject -Class Win32_Product | Select-Object -Property Name > installedapps.txt