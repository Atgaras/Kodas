using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Pirmas skaičius: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Antras skaičius: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Plius vienas: {0}", ++num1);
            Console.WriteLine("Minus vienas: {0}", --num2);
            Console.ReadLine();
        }
    }
}
