using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace зад7
{
    internal class зад7
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi 4islo ");
            int n = int.Parse(Console.ReadLine());
            var a = true;
            if (n <= 1)
            {
                a = false;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n%i==0)
                    {
                        a = false;
                        break;
                    }
                }
            }
            if (a)
            {
                Console.WriteLine("e prosto ");
            }
            else
            {
                Console.WriteLine("ne e prosto ");
            }
        }
    }
}
