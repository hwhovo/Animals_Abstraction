using Project1.Models.Implementations;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;



namespace Project1
{
    

    class Program
    {

        static void Main(string[] args)
        {
            Animal sharik = new Dog();

            FastFood KFC = new FastFood();

            sharik.Move(KFC.address.coordinate);

            KFC.Enter(sharik);
            
            var food = KFC.BuyFood("Kebab");

            sharik.Eat(food.Food);

        }
    }
}
