using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    abstract public class Product:IComparable<Product>
    {
        double price;
        int quantity;
        double weight;
        string category;
        string name;
        static Random rnd = new Random();
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value <= 0)
                {
                    price = 0;
                }
                else
                {
                    price = value;
                }
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value <= 0)
                {
                    price = 0;
                }
                else
                {
                    quantity = value;
                }
            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value <= 0)
                {
                    weight = 0;
                }
                else
                {
                    weight = value;
                }
            }
        }
        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }
        public Product()
        {
            price = rnd.Next(50, 10000);
            quantity = rnd.Next(1, 100);
            weight = rnd.Next(1, 100);
        }
        public Product(double price, int quantity, double weight, string category, string name)
        {
            Category = category;
            Name = name;
            Price = price;
            Quantity = quantity;
            Weight = weight;
        }
        public override string ToString()
        {
            return ("Цена : " + Price + " Количество : " + Quantity + " Вес : " + Weight);
        }
        public int CompareTo(Product other)
        {
            if (string.Compare(this.Category, other.Category) == 1)
                return 1;
            else if (string.Compare(this.Category, other.Category) == -1)
                return -1;
            else if (string.Compare(this.Name, other.name) == 1)
                return 1;
            else if (string.Compare(this.Name, other.name) == -1)
                return -1;
            else if (this.price > other.price)
                return 1;
            else if (this.price < other.price)
                return -1;
            else if (this.Quantity > other.Quantity)
                return 1;
            else if (this.Quantity < other.Quantity)
                return -1;
            else if (this.Weight > other.Weight)
                return 1;
            else if (this.Weight < other.Weight)
                return -1;
            else return 0;
        }
        public bool Find_Atribute(string s)
        {
            if (s == "Цена" || s == "цена")
            {
                return true;
            }
            if (s == "Количество" || s == "количество")
            {
                return true;
            }
            if (s == "Вес" || s == "вес")
            {
                return true;
            }
            if (s == "Категория" || s == "категория")
            {
                return true;
            }
            if (s == "Имя" || s == "имя")
            {
                return true;
            }
            return false;
        }
    }
}
