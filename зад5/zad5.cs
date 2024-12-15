using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace зад5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi 4islo       ");
            int n = int.Parse(Console.ReadLine());
            var i = "  ";
            if (n == 0)
            {
                i = "0";
            }
            else
            { 
                while (n > 0)
                {
                    int a = n % 2;
                    i = a + i;
                    n /= 2; 
                }
            }
            Console.WriteLine("dvoi4na sistema    "+i);
        }
    }
}
