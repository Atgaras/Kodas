using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ar_lyginiai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite pirmą skaičių: ");
            int pirmas = int.Parse(Console.ReadLine());
            Console.WriteLine("Įveskite antrą skaičių: ");
            int antras = int.Parse(Console.ReadLine());
            if (pirmas % 2 == antras % 2)
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }

            Console.ReadLine();
        }
    }
}
