using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeMachine.Entities;

namespace CoffeeMachine.PL
{
    internal class CoffeeConsole
    {
        internal void ProductShow(Product[] items, Action<int> selectedProduct)
        {
            Console.WriteLine("Здравствуйте! Вот ассортимент!");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Id}: {item.Name} - {item.Price}");
            }
            Console.WriteLine();
            //разбить логические части
            Console.WriteLine("Выберите продукт!");
            selectedProduct(int.Parse(Console.ReadLine()));
        }

        internal decimal Enter(string name, decimal price)
        {
            Console.WriteLine($"Почти начали готовить Ваш {name}, нужно только оплатить");
            Console.WriteLine($"Внесите оплату (0 из {price})");
            return decimal.Parse(Console.ReadLine());
        }

        internal decimal Buy(decimal current, decimal price)
        {
            
                Console.WriteLine($"Добавьте денежную сумму ({current} из {price})осталось доплатить {price - current}!");
                return decimal.Parse(Console.ReadLine());
           
            
            //if (current <= price)
            //{

            //    Console.WriteLine($"Добавьте денежную сумму ({current} из {price})осталось доплатить {price - current}!");
            //    return decimal.Parse(Console.ReadLine());
            //}
            //else
            //{
            //    Console.WriteLine($"Заберите Вашу сдачу {current - price}!");
            //}
            }
        internal void Final(string name, decimal current, decimal price)
        {

            if (current > price)
            {   Console.WriteLine($"Приятного дня! Ваш {name} готов! Заберите Вашу сдачу {current - price} рублей!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Приятного дня! Ваш {name} готов! ");
                Console.WriteLine();
            }
           // 
        }
    }

        
    }

