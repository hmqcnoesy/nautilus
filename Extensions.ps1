
$src = 'C:\dev\Nautilus\Nautilus.Extensions\bin\Release'
$target = ''

$publishTo = Read-Host 'Publish to local, vm, test or prod?'

if ($publishTo -eq "local")
{
    $target = 'c:\program files (x86)\thermo\nautilus'
}
elseif ($publishTo -eq "vm") 
{
	$target = '\\vm\nautilus'
}
elseif ($publishTo -eq "test")
{
    $target = '\\test'
}
elseif ($publishTo -eq "prod")
{
    $areYouSure = Read-Host 'Are you sure you want to publish to prod?  Type "yes" if you really mean it.'
    
    if ($areYouSure -eq "yes")
    {
        $target = '\\prodextensions'
    } else {
        Break
    }
}
else 
{
    Break
}

robocopy $src $target /E 