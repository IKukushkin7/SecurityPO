using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Journal
    {
        public List<JournalEntry> list;
        public Journal()
        {
            list = new List<JournalEntry>();
        }
        public int Length
        {
            get
            {
                return list.Count;
            }
        }
        public override string ToString()
        {
            string s = "";
            foreach (JournalEntry i in list)
                s += i.ToString() + "\n";
            if (s.Length == 0)
                s = "Журнал пуст.";
            return s;
        }

        public void CollectionCountChanged(object source, CollectionHandlerEventArgs e)
        {
            JournalEntry je = new JournalEntry(e.Name, e.Action, e.Object.ToString());
            list.Add(je);
        }

        public void CollectionReferenceChanged(object source, CollectionHandlerEventArgs e)
        {
            JournalEntry je = new JournalEntry(e.Name, e.Action, e.Object.ToString());
            list.Add(je);
        }
    }
}
