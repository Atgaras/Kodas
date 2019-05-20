using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcija_gražina_simbolių_kiekį
{
    class Program
    {
        private static string PaverstiGrotelem(string name)
        {
            string result = "";
            for (int i = 0; i < name.Length; i++)
            {
                result = result + "#";
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite žodį:");
            string name = Console.ReadLine();
            string zodis = PaverstiGrotelem(name);
            Console.WriteLine(zodis);
            Console.ReadLine();
        }
    }
}
