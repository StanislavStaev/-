using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad8
{
    internal class zad8
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi a ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("vuvedi b ");
            int b = int.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("a i b trqbva da sa razli4ni");
            }
            else
            {
                Console.Write("vuvedi n ");
                int n = int.Parse(Console.ReadLine());
                int s = 0;
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("vivei 4islo ");
                    int v = int.Parse(Console.ReadLine());
                    if (v % a == 0 && v % b != 0)
                    {
                        s++;
                    }
                }
                Console.WriteLine($"broqt na 4islat koito se delqt na {a}, no ne se delqt na {b}, e {s}");
            }
       }
    }
}
