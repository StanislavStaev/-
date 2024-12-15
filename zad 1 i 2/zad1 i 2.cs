using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace домашна1
{
    internal class zad1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nechetni                  chetni");
            int i = 10;
            while (i <= 25)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("                 nechetni " + i+"   "+i*i*i);
                   
                }
                else
                {
                 Console.Write("chetni "+i+"   "+i*i);
                  
                }
                i++;
            }
        }
    }
}
