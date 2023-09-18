using System;

namespace Ffs.Utils
{
    public class OSUtils
    {
        public static bool IsUnix
        {
            get
            {
                int p = (int)Environment.OSVersion.Platform;

                return (p == 4) || (p == 6) || (p == 128);
            }
        }
    }
}