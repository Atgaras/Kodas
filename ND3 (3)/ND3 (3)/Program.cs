using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND3__3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parašykite skaičių:");
            int num = int.Parse(Console.ReadLine());
            
            if (num % 2 == 0)
            {
                Console.WriteLine("Skaičius yra lyginis");
            }
            else
            {
                Console.WriteLine("Skaičius yra nelyginis");
            }

            if (num < 0)
            {
                Console.WriteLine("Skaičius yra neigiamas");
            }
            if (num > 0)
            {
                Console.WriteLine("Skaičius yra teigiamas");
            }
            if (num == 0)
            {
                Console.WriteLine("Skaičius yra 0");
            }
            Console.ReadLine();
        }
    }
}
