using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_simboliai_atvirkštine_tvarka
{
    class Program
    {
        static void Main(string[] args)
        {
            char num;
            char num2;
            char num3;
            char tarpinis;

            Console.WriteLine("Įveksite x: ");
            num = (Console.ReadKey().KeyChar);
            Console.WriteLine();
            Console.WriteLine("Įveksite y: ");
            num2 = (Console.ReadKey().KeyChar);
            Console.WriteLine();
            Console.WriteLine("Įveksite z: ");
            num3 = (Console.ReadKey().KeyChar);

            tarpinis = num;
            num = num3;
            num3 = tarpinis;
            Console.WriteLine();
            Console.WriteLine("Simboliai yra {0}, {1}, {2}", num, num2, num3);
            Console.ReadLine();

        }
    }
}
