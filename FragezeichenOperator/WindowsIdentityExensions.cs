using System;
using System.Security.Principal;

static internal class WindowsIdentityExensions
{
    static internal string SafelyGetName(this WindowsIdentity windowsIdentity) 
        => windowsIdentity?.Name?.ToString() ?? string.Empty;
}