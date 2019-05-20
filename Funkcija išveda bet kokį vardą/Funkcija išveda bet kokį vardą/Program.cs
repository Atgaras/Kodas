using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcija_išveda_bet_kokį_vardą
{
    class Program
    {
        private static void Vardas(int kartai, string name)
        {
            for (int i = 0; i < kartai; i++)
            {
                Console.WriteLine(name);
            }
        }

        static void Main(string[] args)
        {
            string n = "Edgaras";
            int x = 5;
            Vardas(x, n);
            Console.ReadLine();
        }
    }
}
