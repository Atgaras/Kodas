using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įrašykite pirmą skaičių: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Įrašykite antrą skaičių: ");
            double num2 = double.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Skaičiai yra vienodi!");
            }
            else
            {
                Console.WriteLine("Skaičiai yra nevienodi!");
            }
            Console.ReadLine();
        }
    }
}
