﻿using Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck
{
    class Program
    {
        static void Main(string[] args)
        {
            RedheadDuck RD = new RedheadDuck();
            Console.WriteLine(RD.display());
            Console.WriteLine(RD.quack());
            Console.WriteLine(RD.swim());

            MallardDuck MD = new MallardDuck();
            Console.WriteLine(MD.display());
            Console.WriteLine(MD.quack());
            Console.WriteLine(MD.swim());

            Console.ReadKey();
        }
    }
}
