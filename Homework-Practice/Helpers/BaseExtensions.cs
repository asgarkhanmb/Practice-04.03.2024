 using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Homework_Practice.Helpers
{
    internal static class BaseExtensions
    {
        public static bool CheckTextWithRegex(this string str,string pattern)
        {
            return Regex.IsMatch(str,pattern);
        }
       
    }
}
