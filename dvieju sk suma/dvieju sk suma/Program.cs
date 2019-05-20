using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dvieju_sk_suma
{
    class Program
    {
        static string Sum (int x = 5, int y = 8)
        {
            int suma = x+y;
            return suma;
        }
        static void Main(string[] args)
        {
            /*Console.WriteLine("X= ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Y= ");
            int y = int.Parse(Console.ReadLine());
            */
            Console.WriteLine("X ir Y suma yra = {0}", suma);
            //return suma;
            Console.ReadLine();
        }
    }
}
