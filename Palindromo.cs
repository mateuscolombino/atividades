using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Palindromo
    {
        public static string Reverse(string x)
        {
            char[] xstring = x.ToCharArray();

            for(int i=0, j= xstring.Length - 1; i<j; i++, j--)
            {
                xstring[i] = xstring[j];
                xstring[j] = xstring[i];
            }

            return new string (xstring);

        }
    }
}
