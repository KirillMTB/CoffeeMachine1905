using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeMachine.Entities;

namespace CoffeeMachine.DAL
{
    internal class CoffeeDataBase2 : ICoffeeDataBase
    {
        private Product[] _currentProducts = new Product[]
        {
            new Product() { Id = 1, Name = "Эспрессо", Price=40 },
            new Product() { Id = 2, Name = "Американо", Price=50 },
            new Product() { Id = 3, Name = "Капучино", Price=70 },
            new Product() { Id = 4, Name = "Мокачино", Price=70 },
            new Product() { Id = 5, Name = "Двойной эспрессо", Price=80 },
            new Product() { Id = 6, Name = "Какао", Price=90 }
        };

       
        public Product[] GetCurrentProducts()
        {
            return _currentProducts;
        }
        public Product GetProductById(int id)
        {
            return _currentProducts.FirstOrDefault(x => x.Id == id);
        }
    }
}