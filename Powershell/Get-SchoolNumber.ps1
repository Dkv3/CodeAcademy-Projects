<#
.SYNOPSIS
Get-SchoolNumber retrieves a school name from a provided school number.
.DESCRIPTION
Get-SchoolNumber checks for a valid 4 digit number and returns the AD name of the result.
If the number entered does not exist, a prompt will be displayed to ask for another.
.PARAMETER -SchoolNumber
The school number that should be used. Using this param skips all prompts.
.EXAMPLE
Get-SchoolNumber -schoolnumber 2731
.NOTES
Name: Get-SchoolNumber.ps1
Author: Connor Thompson
Last Modified: 3/16/2023 08:37
#>
# Using "Active" and "Inactive" since true/false don't explicitly exist
# To do:
# - Add a param option to skip prompts that accepts a school number
# - Add an if statement to filter by the 9000+ numbers

$operation = "Active"
do{
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
		do{
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

$VerbosePreference = "silentlyContinue"
$DebugPreference = "silentlyContinue"