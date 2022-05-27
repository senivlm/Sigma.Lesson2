using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Buy
    {
        private Product prod;
        private ushort count;
        static public List<Buy> listOfProducts = new List<Buy>();

        public Buy()
        {

        }

        public Buy(Product prod, ushort count)
        {
            this.prod = prod;
            this.count = count;
            listOfProducts.Add(this);
        }

        public Product Prod { get { return prod; } }
        public ushort numCount { get { return count; } }
    }

    sealed class Check : Buy
    {
        public override string ToString()
        {
            Console.WriteLine("CHECK TOV SHUMARA GROUP");
            string message = "";
            float TotalPrice = 0;
            for (int i = 0; i < listOfProducts.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {listOfProducts[i].Prod.Name}, {listOfProducts[i].numCount}kg, " +
                    $"{listOfProducts[i].Prod.Price * listOfProducts[i].numCount}");
                TotalPrice += listOfProducts[i].Prod.Price * listOfProducts[i].numCount;
            }
            Console.WriteLine($"\nTOTAL: {TotalPrice} UAH");
            return message;
        }
    }
}
