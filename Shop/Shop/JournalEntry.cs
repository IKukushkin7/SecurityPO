using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class JournalEntry
    {
        public string Name { get; set; }
        public string Action { get; set; }
        public string Object { get; set; }
        public JournalEntry(string name, string action, string obj)
        {
            Name = name;
            Action = action;
            Object = obj;
        }

        public string CollectionName
        {
            get { return Name; }
            set { Name = value; }
        }

        public override string ToString()
        {
            return "\nНазвание коллекции: " + Name + " " + "Действие: " + Action + " Объект: " + "" + Object;
        }
    }
}
