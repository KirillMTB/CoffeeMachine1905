using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeMachine.DAL;
using CoffeeMachine.Entities;

namespace CoffeeMachine.BLL
{
    internal class CoffeeManager
    {
        private ICoffeeDataBase _database;

        public CoffeeManager(ICoffeeDataBase dataBase)
        {
            _database = dataBase;
        }
        internal Product[] GetAssortment()
        {
            return _database.GetCurrentProducts();
        }

        internal Product SelectProduct(int id) //строку специально поставили, чтобы использовать его в консоле в CoffeeUIConsole в методе ентер
        {
            var item=_database.GetProductById(id);
            return item;
        }

        internal bool BuyProduct(int id, decimal money) //строку специально поставили, чтобы использовать его в консоле в CoffeeUIConsole в методе ентер
        {
            var item = _database.GetProductById(id);
            return money >= item.Price;
            
        }
    }
}
