using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeMachine.Entities;

namespace CoffeeMachine.DAL
{
    internal class CoffeeDataBase : ICoffeeDataBase
    {
        private Product[] _currentProducts = new Product[]
        {
            new Product() { Id = 1, Name = "Эспрессо", Price=40 },
            new Product() { Id = 2, Name = "Американо", Price=50 },
            new Product() { Id = 3, Name = "Капучино", Price=70 },
            new Product() { Id = 4, Name = "Мокачино", Price=70 },
            new Product() { Id = 5, Name = "Латте", Price=80 },
            new Product() { Id = 6, Name = "Раф", Price=90 }
        };

        //public CoffeeDataBase()
        //{
        //    _currentProducts = new Product[] 
        //    {
        //        new Product() { Id = 1, Name = "Эспрессо" },
        //        new Product() { Id = 1, Name = "Американо" },
        //        new Product() { Id = 1, Name = "Капучино" },
        //        new Product() { Id = 1, Name = "Мокачино" },
        //        new Product() { Id = 1, Name = "Латте" },
        //        new Product() { Id = 1, Name = "Раф" }
        //    };
        //}
        public Product[] GetCurrentProducts()
        {
            return _currentProducts;
        }

        public Product GetProductById(int id)
        {
            return _currentProducts.FirstOrDefault(x=>x.Id==id);
        }
    } }
