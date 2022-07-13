using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ExtensionMethod
{
    public static class StringExtensions
    {
        /// <summary>
        /// Rever() method is an extesnion method for the StringUtility class
        /// </summary>
        /// <param name="utility"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Reverse(this StringUtility utility, string str)
        {
            string reverse = String.Empty;

            for (int i = str.Length-1; i >= 0; i--)
            {
                reverse+= str[i];
            }

            return reverse;
        }

        /// <summary>
        /// Extension method for the .NET String class
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReverseString(this string str)
        {
            string reverse = String.Empty;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i];
            }

            return reverse;
        }
    }
}
