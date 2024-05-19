using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeMachine.Entities;

namespace CoffeeMachine.DAL
{
    internal interface ICoffeeDataBase
    {
        Product[] GetCurrentProducts();
        Product GetProductById(int id);
    }
}
