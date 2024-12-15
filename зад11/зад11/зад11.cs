using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace зад11
{
    internal class зад11
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi 4islo ");
            int n = int.Parse(Console.ReadLine());
            if (n < 3 || n > 20)
            {
                Console.WriteLine("");  
            }
            Console.Write("vuvedi simvol ");
            char symbol = char.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(symbol);
                    if (k < i)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
