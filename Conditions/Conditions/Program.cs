using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite grupės pavadinimą:");
            string grupesPavadinimas = Console.ReadLine();

            Console.WriteLine("Įveskite grupės narių skaičių:");
            int nariuSkaicius; //= int.Parse(Console.ReadLine());
            if(!int.TryParse(Console.ReadLine(), out nariuSkaicius))
            {
                Console.WriteLine("Įvestas blogas skaičius");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("Grupės pavadinimas yra: {0}, narių skaičius yra {1}", grupesPavadinimas, nariuSkaicius);
            Console.ReadLine();
        }
    }
}
