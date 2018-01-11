#Set the screen resolution on the VM
$keys = Get-ChildItem -Path "HKLM:\System\CurrentControlSet\Control\Video" | % Name | foreach {"$_\0000"}
$paths = ForEach ($key in $keys) { $key -replace "HKEY_LOCAL_MACHINE", "HKLM:" }

ForEach ($path in $paths)
{
    IF (!(Test-Path $path))
    {
        New-Item -Path $path
    }

    # We've ensured that the path exists.  Now look for the specific key.
    $item = Get-Item -LiteralPath $path

    # First take care of DefaultSettings.XResolution
	IF ($item.GetValue("DefaultSettings.XResolution", $null) -ne $null)
    {
        # Setting already exists, so delete it and recreate it
        Remove-ItemProperty $path -Name "DefaultSettings.XResolution" -ErrorAction SilentlyContinue
        New-ItemProperty $path -Name "DefaultSettings.XResolution" -Value 1600 -PropertyType "DWord" -ErrorAction SilentlyContinue
    }
    ELSE
    {
        # Setting doesn't exist, so create it
        New-ItemProperty $path -Name "DefaultSettings.XResolution" -Value 1600 -PropertyType "DWord" -ErrorAction SilentlyContinue
    }

    # Now take care of DefaultSettings.YResolution
	IF ($item.GetValue("DefaultSettings.YResolution", $null) -ne $null)
    {
        # Setting already exists, so delete it and recreate it
        Remove-ItemProperty $path -Name "DefaultSettings.YResolution" -ErrorAction SilentlyContinue
        New-ItemProperty $path -Name "DefaultSettings.YResolution" -Value 1200 -PropertyType "DWord" -ErrorAction SilentlyContinue
    }
    ELSE
    {
        # Setting doesn't exist, so create it
        New-ItemProperty $path -Name "DefaultSettings.YResolution" -Value 1200 -PropertyType "DWord" -ErrorAction SilentlyContinue
    }
}