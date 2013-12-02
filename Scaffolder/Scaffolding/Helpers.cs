using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scaffolder.Scaffolding
{
    public static class Helpers
    {
        public static string UppercaseFirst(string s)
        {
            {
                if (string.IsNullOrEmpty(s))
                {
                    return string.Empty;
                }
                return char.ToUpper(s[0]) + s.Substring(1);
            }
        }
    }
}