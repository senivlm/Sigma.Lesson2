using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    /// <summary>
    /// Загальний батьківський клас продуктів
    /// </summary>
    public class Product
    {
        private string name;
        private float price;
        private float weight;

        public string Name { get { return name; } protected set { this.name = value; } }
        public float Price { get { return price; } protected set { this.price = value; } }
        public float Weight { get { return weight; } protected set { this.weight = value; } }

        public Product()
        {

        }
        public Product(string name, float price, float weight)
        {
            this.name = name;
            this.price = price;
            this.weight = weight;
        }

        /// <summary>
        /// Метод знижки для продукту. Його можна перевизначити в дочірніх класах
        /// </summary>
        /// <param name="discount">Надана знижка</param>
        public virtual void ChangePrice(float discount)
        {
            
            price *= (100f - discount) / 100f;
        }

        public override string ToString()
        {
            string info = "";
            info += "Найменування товару: " + Name + "\n";
            info += "Ціна за одиницю товару: " + Price + "\n";
            info += "Маса однієї одиниці товару: " + Weight + "\n";
            return info;
        }
    }

    public class Meat : Product
    {
        public enum Category : ushort
        {
            Highest = 0,
            First = 10,
            Second = 30
        }
        public enum MeatType
        {
            Mutton,
            Beef,
            Pork,
            Chicken
        }

        private Category category;
        private MeatType meatType;


        public Meat()
        {

        }

        public Meat(string name, float price, float weight, Category category, MeatType meat) : base(name, price, weight)
        {
            this.category = category;
            meatType = meat;
            
        }

        public override void ChangePrice(float discount)
        {
            base.ChangePrice(discount + (ushort)category);
        }
        public override string ToString()
        {
            string info = "";
            info += "Найменування товару: " + Name + "\n";
            info += "Ціна за одиницю товару: " + Price + "\n";
            info += "Маса однієї одиниці товару: " + Weight + "\n";
            info += "Ґатунок: " + category + "\n";
            info += "Вид м'яса: " + meatType + "\n";
            return info;
        }
    }
    public class DairyProduct : Product
    {
        private DateTime bestBefore;
        public DairyProduct()
        {

        }
        public DairyProduct(string name, ushort price, float weight, DateTime date) : base(name, price, weight)
        {
            bestBefore = date;
        }
        public override void ChangePrice(float discount)
        {
            base.ChangePrice(discount + GetExtraDiscount());
        }
        private ushort GetExtraDiscount()
        {
            DateTime now = DateTime.Now;
            

            return bestBefore.Day - now.Day <=1 ? (ushort)30 : (ushort)0;
        }

        public override string ToString()
        {
            string info = "";
            info += "Найменування товару: " + Name + "\n";
            info += "Ціна за одиницю товару: " + Price + "\n";
            info += "Маса однієї одиниці товару: " + Weight + "\n";
            info += "Строк придатності: " + bestBefore + "\n";
            return info;
        }

    }
}
