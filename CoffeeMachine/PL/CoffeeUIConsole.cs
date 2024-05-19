using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeMachine.BLL;
using CoffeeMachine.DAL;

namespace CoffeeMachine.PL
{
    internal class CoffeeUIConsole
    {
        private ICoffeeDataBase _dataBase;
        private CoffeeManager _manager;
        private CoffeeConsole _console;
        public CoffeeUIConsole()
        {
            _dataBase = new CoffeeDataBase();//_manager = new CoffeeManager(new CoffeeDataBase()); в этом месте при идменении CoffeeDataBase2 и CoffeeDataBase, можно вывести данные по выбору, то есть можно подключить любую базу
            _manager = new CoffeeManager(_dataBase);
            _console = new CoffeeConsole();
        }

        internal void Run()
        {
            while (true)
            {
                var items = _manager.GetAssortment();
                _console.ProductShow(items, StartCooking);
            }
        }

        private void StartCooking(int number)
        {
            var product = _manager.SelectProduct(number);
            decimal money = _console.Enter(product.Name, product.Price);
            while (money < product.Price)
            {
                money += _console.Buy(money, product.Price);
            }
            _console.Final(product.Name, money, product.Price);
        }
    }


}


