using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND3_6_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pirmas kampas:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Antras kampas:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Trečias kampas:");
            int num3 = int.Parse(Console.ReadLine());

            if (num1+num2+num3 == 180)
            {
                Console.WriteLine("Trikampis gali būti sudarytas");
            }
            else
            {
                Console.WriteLine("Trikampis negali būti sudaytas");
            }

            Console.ReadLine();
        }
    }
}
