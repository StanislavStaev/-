using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedi 4islo");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= n)
            {
                if (i % 4 != 0 && i % 8 != 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
         }
    }
}
                
            
   

