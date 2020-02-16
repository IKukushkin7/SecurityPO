using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КурсоваяРабота
{
    class Industrial_product:Product
    {
        double quality;
        static Random rnd = new Random();
        public double Quality
        {
            get
            {
                return quality;
            }
            set
            {
                if (quality >= 0 && quality <= 1)
                {
                    quality = value;
                }
                else
                {
                    quality = 0;
                }
            }
        }
        private void Generation()
        {
            string[] Categories = { "Электрические_приборы", "Для_душа", "Для_огорода", "Канцелярия", "Мебель" };
            string[] Electric = { "Розетка", "Лампа", "Микроволновка", "Стиральные_машины", "Посудомойка" };
            string[] Water = { "Шампунь", "Мыло", "Мочалка", "Гель_для_душа", "Жидкое_мыло" };
            string[] garden = { "Лопата", "Семена", "Грабли", "Удобрения", "Теплица" };
            string[] Chancery = { "Ручка", "Карандаш", "Линейка", "Тетрадка", "Альбом" };
            string[] Furniture = { "Шкаф", "Стол", "Стул", "Комод", "Диван" };
            string s = Categories[rnd.Next(0, 4)];
            Category = s;
            if (s == "Электрические_приборы")
            {
                Name = Electric[rnd.Next(0, 4)];
            }
            if (s == "Для_душа")
            {
                Name = Water[rnd.Next(0, 4)];
            }
            if (s == "Для_огорода")
            {
                Name = garden[rnd.Next(0, 4)];
            }
            if (s == "Канцелярия")
            {
                Name = Chancery[rnd.Next(0, 4)];
            }
            if (s == "Мебель")
            {
                Name = Furniture[rnd.Next(0, 4)];
            }
            quality = double.Parse(rnd.Next(0)+","+rnd.Next(0, 10));
        }
        public Industrial_product()
            : base()
        {
            Generation();
        }
        public Industrial_product(string category, string name, double price, int quantity, double weight, double Quality)
            : base(price, quantity, weight, category, name)
        {
            this.Quality = Quality;
        }
        public override string ToString()
        {
            return "Категория: " + Category + " Название: " + Name + " Цена: " + Price + " Количество: " + Quantity + " Вес: " + Weight + " Качество: " + quality;
        }
    }
}
