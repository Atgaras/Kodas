using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtd_lyginis_nelyginis
{
    class Program
    {
        static void Skaicius (int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine("Skaičius {0} yra lyginis", x);
            }
            else
            {
                Console.WriteLine("Skaičius {0} yra nelyginis", x);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Įrašykite skaičių X:");
            Skaicius(int.Parse(Console.ReadLine()));
            Console.ReadLine();
        }
    }
}
