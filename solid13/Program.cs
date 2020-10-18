using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid13
{

    class Animal { }

    class Dog : Animal { }

    class Program
    {
        static void PrintTypes(Animal a)
        {
            Console.WriteLine(a.GetType() == typeof(Animal)); // false 
            Console.WriteLine(a is Animal);                  // true 
            Console.WriteLine(a.GetType() == typeof(Dog));   // true
        }

        static void Main(string[] args)
        {
            Dog spot = new Dog();
            PrintTypes(spot);
        }
    }
}
