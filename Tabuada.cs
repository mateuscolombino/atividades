using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Tabuada
    {
        public static void X(int x)
        {
            for (int i = 1; i<11;i++)
            {
                int resul = i * x;
                Console.WriteLine((i) +"x"+ (x) + "=" + resul) ;
            }
        }
    }
}
