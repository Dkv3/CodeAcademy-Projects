<#
.SYNOPSIS
Get-SchoolNumber retrieves a school name from a provided school number.
.DESCRIPTION
Get-SchoolNumber checks for a valid 4 digit number and returns the AD name of the result.
If the number entered does not exist, a prompt will be displayed to ask for another.
If the -SchoolNumber paramater is provided with a four digit number, the command skips all prompts.
If the -SchoolNumber parameter is provided with anything else, it will keep prompting for a four
digit number, regardless of whether it is valid.
.PARAMETER -SchoolNumber
The school number that should be used. Using this param skips all prompts.
.INPUTS
A four digit school number provided by the user.
.OUTPUTS
This command returns the following cmdlet:
Get-ADOrganizationalUnit -filter "Name -like '*$SchoolNumber'" | Select -ExpandProperty "Name",
$SchoolNumber is supplied by the user, either through the -SchoolNumber param or the prompt if 
that's not provided.
.EXAMPLE
Get-SchoolNumber
Get-SchoolNumber -SchoolNumber 2731
.NOTES
Name: Get-SchoolNumber.ps1
Author: Connor Thompson
Last Modified: 3/17/2023 05:57
#>
# Using "Active" and "Inactive" since true/false don't explicitly exist

Function Get-SchoolNumber
{
Param(
[parameter(Mandatory = $false)]
[int]$SchoolNumber = 0000
)

# Check to see if a param was supplied; doing so skips all of the prompts
if ($SchoolNumber -ne 0000)
{
	$operation = "Inactive"
	if ($SchoolNumber -match '\b\d{4}\b')
	{
		Get-ADOrganizationalUnit -filter "Name -like '*$SchoolNumber'" | Select -ExpandProperty "Name"
	}
	else
	{
		Write-Error -message 'A proper four digit school number was not supplied.'
	}
}
else
{
	$operation = "Active"
	do
	{
		$input = Read-Host -Prompt 'Enter a four digit school number'
		if ($input -match '\b\d{4}\b')
		{
			$output = Get-ADOrganizationalUnit -filter "Name -like '*$input'" | Select -ExpandProperty "Name"
			if ($output -eq $null)
			{
				$response = "Inactive"
				Write-Output "That school number does not exist. Please enter another."
			}
			else
			{
				Write-Output $output
				$response = "Active"
			}

			if ($response -eq "Active")
			{
				do
				{
					$response = Read-Host -Prompt "Enter another number? (Y / N)"
					if ($response -eq "Y")
					{
						$operation = "Active"
						$response = "Inactive"
					}
					elseif ($response -eq "N")
					{
						$operation = "Inactive"
						$response = "Inactive"
					}
					else
					{
						Write-Output "You must enter either Y or N."
						$operation = "Active"
						$response = "Active"
					}
				}
				While($response -eq "Active")
			}
	}
	else
	{
		Write-Output "You must enter a 4 digit number!"
	}
	}
	While($operation -eq "Active")
}
}
$VerbosePreference = "silentlyContinue"
$DebugPreference = "silentlyContinue"
Export-ModuleMember -Function 'Get-SchoolNumber'