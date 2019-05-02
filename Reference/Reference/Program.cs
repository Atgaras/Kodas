using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference
{
    class Human
    {
        public string Name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();
            human1.Name = "Batman";

            Human human2 = human1;

            Console.WriteLine("Human1.Name: " + human1.Name);
            Console.WriteLine("Human2.Name: " + human2.Name);

            human1.Name = "Joker";

            Console.WriteLine("Human1.Name: " + human1.Name);
            Console.WriteLine("Human2.Name: " + human2.Name);

            Console.ReadLine();
        }
    }
}
