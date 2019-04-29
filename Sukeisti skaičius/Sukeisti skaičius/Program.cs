using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sukeisti_skaičius
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb1;
            int numb2;
            int tarpinis; 
            Console.WriteLine("Įrašyti pirmą skaičių:");
            numb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įrašyti antrą skaičių:");
            numb2 = Convert.ToInt32(Console.ReadLine());
            tarpinis = numb1;
            numb1 = numb2;
            numb2 = tarpinis;
            Console.WriteLine("Skaičiai {0}, {1}", numb1, numb2);
            Console.ReadLine();
        }
    }
}
