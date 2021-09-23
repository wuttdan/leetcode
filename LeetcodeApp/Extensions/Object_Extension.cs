using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp.Extensions
{
    public static class Object_Extension
    {
        public static void Dump<T>(this T data, bool is_console = false)
        {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            if (!is_console)
            {
                Debug.WriteLine(json); 
            }
            else
            {
                Console.WriteLine(json);
            }
        }
    }
}
