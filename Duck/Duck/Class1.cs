using Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duckk[] ducks = new Duckk[]
            {
                new MallardDuck(),
                new RedheadDuck(), 
                new RubberDuck(),
                new DecoyDuck()
            };
            foreach (Duckk duck in ducks)
            {
                Console.WriteLine(duck.swim());
                Console.WriteLine(duck.display());
                if (duck is Flyable)
                {
                    Console.WriteLine((duck as Flyable).fly());
                }
                if (duck is Quackable)
                {
                    Console.WriteLine((duck as Quackable).quack());
                }
            }
            Console.ReadKey();
        }
    }
}
//1
