<#
.SYNOPSIS
Get-Site retrieves a site name from a site number or vice versa.
.DESCRIPTION
Get-Site checks for a valid 4 digit number or site name and returns the AD name of the result.
If the site name/number entered does not exist, a prompt will be displayed to ask for another.
.NOTES
Name: Get-Site.ps1
Author: Connor Thompson
Last Modified: 3/23/2023 08:37
See GetSite.psm1 for the Powershell Module file variant of this script.
#>

Write-Output "Press Ctrl + C at anytime to stop this script."
$operation = "Active"
do{
Write-Output ""
$userInput = Read-Host -Prompt 'Enter a four digit site number or a site name'
if ($userInput -match '^\d{4}$')
{
	$output = Get-ADOrganizationalUnit -filter "Name -like '*$userInput*'"  | Select-Object -ExpandProperty "name" -First 1
	if ($null -eq $output)
	{
		Write-Output "That site number does not exist."
	}
	else
	{
		Write-Output $output
	}
}
elseif ($userInput -match '^[a-zA-Z]+$')
{
	$output = Get-ADOrganizationalUnit -filter "Name -like '*$userInput*'"  | Select-Object -ExpandProperty "name" -First 3
	if ($null -eq $output)
	{
		Write-Output "That site name does not exist."
	}
	else
	{
		Write-Output $output
	}
}
else
{
	Write-Output "You must enter either a 4 digit number or valid site name."
	Write-Output "Site names must only contain letters - no spaces, numbers, or symbols."
}
}
While($operation -eq "Active")

$VerbosePreference = "silentlyContinue"
$DebugPreference = "silentlyContinue"