using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    internal class Product
    {
        public string Name { get; set; }
        public Money Amount { get; set; }
        public void ProductInfo()
        {
            Console.WriteLine($"The info about the product: the name is {Name}, the cost is {Amount.Uah} uah {Amount.Kop} kop");
            PriceReducing();
        }
        public void PriceReducing()
        {
            Console.WriteLine("How much would you like to reduce the price?");
            var IfDouble = double.TryParse(Console.ReadLine(), out double reduce);
            if (IfDouble==false)
            {
                throw new Exception("Sorry, enter the double number through coma");
            }
            var reduceInt = Math.Truncate(reduce);
            Amount.Uah -= Convert.ToInt32(reduceInt);
            var reduceDouble = reduce - reduceInt;
            reduceDouble *= 100;
            Amount.Kop -= Convert.ToInt32(reduceDouble);
            Console.WriteLine($"The new price is {Amount.Uah} uah {Amount.Kop} kop");
        }
    }
}
