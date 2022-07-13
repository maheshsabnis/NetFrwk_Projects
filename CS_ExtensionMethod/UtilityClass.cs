using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ExtensionMethod
{
    public sealed class StringUtility
    {
        public string ChangeCase(string str, char c)
        {
            if (c == 'u' || c == 'U') return str.ToUpper();
            if (c == 'l' || c == 'L') return str.ToLower();
            return str;
        }
        public int GetLength(string str)
        {
            // Check for non-empty and not null
            if(!String.IsNullOrEmpty(str))
                return str.Length;
            return 0;
        }
    }
}
