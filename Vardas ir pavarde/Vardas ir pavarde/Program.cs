using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vardas_ir_pavarde
{
    class Program
    {
        private static void Name(string name = "Edgaras", string surname= "Goferis")
        {
            Console.WriteLine("{0}, {1}", name, surname);
        }

        static void Main(string[] args)
        {

            Name();
            Console.ReadLine();
        }
    }
}
