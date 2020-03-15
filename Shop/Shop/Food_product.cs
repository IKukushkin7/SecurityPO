using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Food_product:Product
    {
        double caloricity;
        bool freshness;
        static Random rnd = new Random();
        private void Generation()
        {
            string[] categories = { "Молочные", "Овощи", "Фрукты", "Мясо", "Рыба", "Сладости" };
            string[] Milk = { "Кефир", "Молоко", "Ряженка", "Творог" };
            string[] Vegetables = { "Помидор", "Огурец", "Морковь", "Перец", "Капуста" };
            string[] fruit = { "Яблоко", "Груша", "Банан", "Персик", "Апельсин" };
            string[] Meat = { "Курица", "Свинина", "Говядина", "Индейка", "Утка" };
            string[] Fish = { "Щука", "Налим", "Горбуша", "Судак", "Лосось" };
            string[] Sweets = { "Конфеты", "Шоколад", "Джем", "Повидло", "Пастила" };
            string categori = categories[rnd.Next(0, 5)];
            this.Category = categori;
            if (categori == "Молочные")
            {
                this.Name = Milk[rnd.Next(0, 3)];
            }
            if (categori == "Овощи")
            {
                this.Name = Vegetables[rnd.Next(0, 4)];
            }
            if (categori == "Фрукты")
            {
                this.Name = fruit[rnd.Next(0, 4)];
            }
            if (categori == "Мясо")
            {
                this.Name = Meat[rnd.Next(0, 4)];
            }
            if (categori == "Рыба")
            {
                this.Name = Fish[rnd.Next(0, 4)];
            }
            if (categori == "Сладости")
            {
                this.Name = Sweets[rnd.Next(0, 4)];
            }
            Caloricity = rnd.Next(50, 1000);
            int n = rnd.Next(0, 100);
            if (n % 2 != 0)
                freshness = false;
            else freshness = true;
        }
        public double Caloricity
        {
            get
            {
                return caloricity;
            }
            set
            {
                if (value <= 0)
                {
                    caloricity = 0;
                }
                else
                {
                    caloricity = value;
                }
            }
        }
        public bool Freshness
        {
            get
            {
                return freshness;
            }
        }
        public Food_product()
            : base()
        {
            Generation();
        }
        public Food_product(string category, string name, double price, int quantity, double weight, double caloricity, bool freshness)
            : base(price, quantity, weight, category, name)
        {
            this.Caloricity = caloricity;
            this.freshness = freshness;
        }
        public override string ToString()
        {
            if (freshness == true)
            {
                return "Категория: " + Category + " Название: " + Name + " Цена: " + Price + " Количество: " + Quantity + " Вес: " + Weight + " Калории: " + caloricity + " Свежий";
            }
            else
            {
                return "Категория: " + Category + " Название: " + Name + " Цена: " + Price + " Количество: " + Quantity + " Вес: " + Weight + " Калории: " + caloricity + " Протухший";
            }
        }
        public override bool Equals(object obj)
        {
            return this.Name == ((Food_product)obj).Name && this.Category == ((Food_product)obj).Category && this.Price == ((Food_product)obj).Price && this.Quantity == ((Food_product)obj).Quantity && this.Weight == ((Food_product)obj).Weight && this.freshness == ((Food_product)obj).freshness;
        }
    }
}
