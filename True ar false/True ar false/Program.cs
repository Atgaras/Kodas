using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace True_ar_false
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Pirmas skaičius:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Antras skaičius:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1==num2);
            Console.ReadLine();
        }
    }
}
