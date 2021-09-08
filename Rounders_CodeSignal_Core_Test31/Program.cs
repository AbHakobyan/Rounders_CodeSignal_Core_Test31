using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounders_CodeSignal_Core_Test31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(rounders(n));
        }
        static int rounders(int n)
        {
            if (n < 10) return n;
            return rounders(n / 10 + (n % 10 >= 5 ? 1 : 0)) * 10;
        }

    }
}
