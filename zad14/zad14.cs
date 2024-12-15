using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad14
{
    internal class zad14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedi duljina na stranata ot 3 do 13");
            int b = int .Parse(Console.ReadLine());
            Console.WriteLine("vuvedi simvol za vutre6nosta");
            string c = Console.ReadLine();
            for (int i = 0; i < b; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int i = 0; i < b - 2; i++)
            {
                Console.Write("*");
                for (int j = 0; j<b-2; j++)
                {
                    Console.Write(c);
                }
                Console.WriteLine("*");
            }
                for (int i = 0; i < b; i++)
            {
                Console.Write("*");
            }
                Console.WriteLine();
           }
       }
}
