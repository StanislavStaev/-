using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad6
{
    internal class zad6
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi 4islo ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("vuvedi drugo ");
            int b = int.Parse(Console.ReadLine());
            int a1 = a, b1 = b;
            while (b != 0)
            {
                int i = a % b;
                a = b;
                b = i;
            }
            int sum = a1 + b1;
            Console.WriteLine("nai golqm bo6t delitel "+a);
            Console.WriteLine("sumata na 4islata " +sum);
        }
    }
}
