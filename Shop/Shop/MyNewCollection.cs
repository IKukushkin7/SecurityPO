using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class MyNewCollection:MyCollection
    {
        public delegate void CollectionHandler(object source, CollectionHandlerEventArgs args);
        public event CollectionHandler CollectionCountChanged;
        public event CollectionHandler CollectionReferenceChanged;
        public string Name { get; set; }
        static Random rnd = new Random();
        public MyNewCollection()
            : base()
        {
        }

        public MyNewCollection(int capacity)
            : base(capacity)
        {
            Name = "Магазин № 1";
        }
        public void Add_Event_New(Product p)
        {
            Add_element(p);
            OnCollectionCountChanged(this, new CollectionHandlerEventArgs(this.Name, "Добавлен новый товар", p.ToString()));
        }

        public void Add_Event()
        {
            int key = rnd.Next(1, 4);
            Product p = null;
            switch (key)
            {
                case 1: p = new Food_product(); break;
                case 2: p = new Library_Product(); break;
                case 3: p = new Industrial_product(); break;
            }
            Add_element(p);
            OnCollectionCountChanged(this, new CollectionHandlerEventArgs(this.Name, "Добавлено", p.ToString()));

        }
       
        public void Delete_Event(int num,string s)
        {
            OnCollectionCountChanged(this, new CollectionHandlerEventArgs(this.Name, "Списано",s));
            Delete_element(num);
        }
        public void Sale_Event(int num,string s)
        {
            OnCollectionCountChanged(this, new CollectionHandlerEventArgs(this.Name, "Продано", s));
            Delete_element(num);
        }
        public virtual void OnCollectionCountChanged(object source, CollectionHandlerEventArgs arg)
        {
            if (CollectionCountChanged != null) CollectionCountChanged(source, arg);
        }

        public virtual void OnCollectionReferenceChanged(object source, CollectionHandlerEventArgs arg)
        {
            if (CollectionReferenceChanged != null) CollectionReferenceChanged(source, arg);
        }
    }
}
