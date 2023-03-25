<#
.SYNOPSIS
Get-Site retrieves a site name from a site number or vice versa.
.DESCRIPTION
Get-Site checks for a valid 4 digit number or site name and returns the AD name of the result.
If the site name/number entered does not exist, a prompt will be displayed to ask for another.
.PARAMETER -Site
The site that should be used. Using this param returns a single output,
whereas using just 'Get-Site' will keep prompting for info until termination.
.INPUTS
None. Other commands are not meant to be piped to Get-Site.
.OUTPUTS
System.String. Get-Site returns a string that represents the name of an Active Directory OU.
.EXAMPLE
PS> Get-Site -Site 2731
CrosspointeES 2731
.EXAMPLE
Get-Site -Site Technical
9231TechnicalOperations
.NOTES
Name: Get-Site.ps1
Author: Connor Thompson
Last Modified: 3/23/2023 08:37
#>

function Get-Site
{
Param(
[parameter(Mandatory = $false)]
$site
)
	if ($null -ne $site)
	{
		$operation = "Inactive"
		$output = Get-ADOrganizationalUnit -filter "Name -like '*$site*'"  | Select-Object -ExpandProperty "name" -First 1
		Write-Output $output
	}
	else
	{
		Write-Output "Press Ctrl + C at anytime to stop this script."
		$operation = "Active"
		do{
		Write-Output ""
		$userInput = Read-Host -Prompt 'Enter a four digit site number or a site name'
		if ($userInput -match '\b\d{4}\b')
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
		elseif ($userInput -match '^\w[a-zA-Z@#.]*$')
		{
			$output = Get-ADOrganizationalUnit -filter "Name -like '*$userInput*'"  | Select-Object -ExpandProperty "name" -First 1
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
			Write-Output "You must enter either a 4 digit number or valid site name!"
			Write-Output "Site names should only be letters; no spaces or numbers."
		}
		}
		While($operation -eq "Active")
	}
}

$VerbosePreference = "silentlyContinue"
$DebugPreference = "silentlyContinue"

Export-ModuleMember -Function Get-Site