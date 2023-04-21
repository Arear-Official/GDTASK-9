using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace gd9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input text");
            string s = Console.ReadLine();
            string result = new string(s.Select(c => (char)(c >= 'a' && c <= 'z' ? (c - 'a' + 13) % 26 + 'a' : c >= 'A' && c <= 'Z' ? (c - 'A' + 13) % 26 + 'A' : c)).ToArray());
            Console.WriteLine(result);
        }
    }
}
