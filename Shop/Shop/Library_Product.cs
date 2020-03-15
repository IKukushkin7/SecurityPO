using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Library_Product:Product
    {
        int year_of_publication;
        static Random rnd = new Random();
        public int Year_of_publication
        {
            get
            {
                return year_of_publication;
            }
            set
            {
                if (value >= 1900 && value <= 2017)
                {
                    year_of_publication = value;
                }
                else
                {
                    year_of_publication = 1990;
                }
            }
        }
        private void Generation()
        {
            string[] Categories = { "Приключения", "Детективы", "Ужасы", "Наука", "Фантастика" };
            string[] Adventure = { "Человек-амфибия", "Том_Сойер", "Три_мушкетёра", "Остров_сокровищ", "Дети_капитана_Гранта" };
            string[] Detectives = { "Игра_без_козырей", "Умельцы", "Ртутная_ложь", "Ветеран", "Твердая_рука" };
            string[] Horrors = { "В_тихом_омуте", "Зелёная миля", "ОНО", "Над_пропастью_во_ржи", "Повелитель_мух" };
            string[] science = { "Автобиография", "Физика", "Химия", "История", "Философия" };
            string[] Fantastic = { "Жестокая_игра", "Темный_мир", "Трансформация", "Игра_на_нервах", "Доспехи_бога" };
            Category = Categories[rnd.Next(0, 4)];
            string s = Category;
            if (s == "Приключения")
            {
                Name = Adventure[rnd.Next(0, 4)];
            }
            if (s == "Детективы")
            {
                Name = Detectives[rnd.Next(0, 4)];
            }
            if (s == "Ужасы")
            {
                Name = Horrors[rnd.Next(0, 4)];
            }
            if (s == "Наука")
            {
                Name = science[rnd.Next(0, 4)];
            }
            if (s == "Фантастика")
            {
                Name = Fantastic[rnd.Next(0, 4)];
            }
        }
        public Library_Product()
            : base()
        {
            Generation();
            Year_of_publication = rnd.Next(1901, 2017);
        }
        public Library_Product(string name, string category, double price, int quantity, double weight, double year)
            : base(price, quantity, weight, category, name)
        {
            Year_of_publication = Convert.ToInt32(year);
        }
        public override string ToString()
        {
            return "Категория: " + Category + " Название: " + Name + " Цена: " + Price + " Количество: " + Quantity + " Вес: " + Weight + " Год_публикации: " + Year_of_publication;
        }
    }
}
