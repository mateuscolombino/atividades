using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Vogal
    {
        public static void Contador(string j)
        {
            int total = 0;
            foreach (char c in j)
            {
                
                if (c == 'a' || c == 'e' || c == 'i' || c=='o' ||  c == 'u')
                {
                    total++;
                }
            }
            Console.WriteLine(total);
        }
    }
}
