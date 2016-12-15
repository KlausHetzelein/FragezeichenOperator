using System.Security.Principal;

namespace FragezeichenOperator
{
    internal static class WindowsIdentityHelper
    {
        public static string GetNameTheClassicalWay(WindowsIdentity windowsIdentity)
        {
            // the classic way
            if (null != windowsIdentity)
            {
                if (null != windowsIdentity.User)
                {
                    return windowsIdentity.User.ToString();
                }
            }

            return null;
        }
        public static string GetNameUsingQmOperator(WindowsIdentity windowsIdentity)
        {
            return windowsIdentity?.Name?.ToString() ?? string.Empty;
        }
    }
}
