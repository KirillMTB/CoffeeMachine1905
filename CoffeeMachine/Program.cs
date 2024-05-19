using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeMachine.PL;

namespace CoffeeMachine
{
    internal class Program
    {
        internal static void Start()
        {
            CoffeeUIConsole coffeeUIConsole = new CoffeeUIConsole();
            coffeeUIConsole.Run();

        }
    }
}
