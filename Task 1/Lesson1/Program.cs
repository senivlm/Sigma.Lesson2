using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product Sausage = new Product("Sausage", 99f, 1);
            Meat porkSausage = new Meat("Pork Sausage", 100, 0.5f, Meat.Category.First, Meat.MeatType.Pork);
            DairyProduct milkshake = new DairyProduct("Milkshake", 120, 0.3f, new DateTime(2022, 5, 28));
        }
    }

    
}
