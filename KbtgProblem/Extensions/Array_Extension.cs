using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbtgProblem.Extensions
{
    public static class Array_Extension
    {
        public static string Print(this int[] array)
        {
            return $"[{string.Join(",", array)}]";
        }
    }
}
