using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class MyCollection
    {
        public Dictionary<int, Product> Shop;
        static Random rnd = new Random();
        public int Length
        {
            get
            {
                return Shop.Count;
            }
        }
        public MyCollection ()
        {
            Shop = new Dictionary<int, Product>();
        }
        public MyCollection(int capacity)
        {
            for(int i =0;i<capacity;i++)
            {
                Product p = null;
                switch(rnd.Next(0,4))
                {
                    case 1:
                        p = new Food_product();
                        break;
                    case 2:p = new Industrial_product();
                        break;
                    default:p = new Library_Product();
                        break;
                }
                Shop.Add(i, p);
            }
        }
        public void Add_element(Product p)
        {
            Shop.Add(Shop.Count, p);
        }
        public void Delete_element(int num)
        {
            Shop.Remove(num);
        }
    }
}
