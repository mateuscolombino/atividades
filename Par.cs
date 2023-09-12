using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Par
    {
        public static void ParCheck(double x)
        {
            
            if (x%2 == 0)
            {
                Console.WriteLine("É par!");
            }
            else Console.WriteLine("É ímpar!");
        }
    }
}
