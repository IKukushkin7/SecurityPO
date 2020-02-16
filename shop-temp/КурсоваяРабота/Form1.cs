using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace КурсоваяРабота
{
    public partial class Form1 : Form
    {
        MyNewCollection shop;
        Journal j;
        public Form1()
        {
            InitializeComponent();
            shop = new MyNewCollection();
            j = new Journal();
            shop.CollectionCountChanged += new MyNewCollection.CollectionHandler(j.CollectionCountChanged);
            shop.CollectionReferenceChanged += new MyNewCollection.CollectionHandler(j.CollectionReferenceChanged);
            shop.Name = "Магазин № 1";
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                string[] Shop_file = File.ReadAllLines("Магазин.txt");
                shop.Shop.Clear();
                for (int i = 0; i < Shop_file.Length; i++)
                {
                    string[] s = Shop_file[i].Split();
                    Product obj = null;
                    if (s[10] == "Коллории:")
                    {
                        if (s[12] == "Свежее")
                        {
                            obj = new Food_product(s[1], s[3], double.Parse(s[5]), int.Parse(s[7]), int.Parse(s[9]), double.Parse(s[11]), true);
                        }
                        else
                        {
                            obj = new Food_product(s[1], s[3], double.Parse(s[5]), int.Parse(s[7]), int.Parse(s[9]), double.Parse(s[11]), false);
                        }
                    }
                    else
                    {
                        if (s[10] == "Год_публикации:")
                        {
                            obj = new Library_Product(s[1], s[3], double.Parse(s[5]), int.Parse(s[7]), double.Parse(s[9]), int.Parse(s[11]));
                        }
                        else
                        {
                            obj = new Industrial_product(s[1], s[3], double.Parse(s[5]), int.Parse(s[7]), double.Parse(s[9]), double.Parse(s[11]));
                        }
                    }
                    shop.Shop.Add(i, obj);
                }
                foreach (KeyValuePair<int, Product> p1 in shop.Shop)
                {
                    listBox1.Items.Add(p1.Value.ToString());
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл со всей информацией удалён");
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] s = new string[shop.Length];
            int i = 0;
            foreach (KeyValuePair<int, Product> p in shop.Shop)
            {
                s[i] = p.Value.ToString();
                i++;
            }
            File.WriteAllLines("Магазин.txt", s);
        }

        private void вФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (KeyValuePair<int, Product> p in shop.Shop)
            {
                listBox1.Items.Add(p.Value.ToString());
            }
        }

        private void наЭкранToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (JournalEntry p in j.list)
            {
                listBox1.Items.Add(p.ToString());
            }
        }

        private void вФайлToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string[] s = new string[j.list.Count];
            int i = 0;
            foreach (JournalEntry p in j.list)
            {
                s[i] = p.ToString();
                i++;
            }
            File.WriteAllLines("Журнал.txt", s);
        }

        private void добавитьСлучайныйТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void добавитьТоварToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void продатьТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string s = listBox1.SelectedItem.ToString();
                int i = 0;
                foreach (KeyValuePair<int, Product> p in shop.Shop)
                {
                    if (s == p.Value.ToString())
                    {
                        i = p.Key;
                        break;
                    }
                }
                shop.Sale_Event(i, s);
                listBox1.Items.Clear();
                foreach (KeyValuePair<int, Product> p in shop.Shop)
                {
                    listBox1.Items.Add(p.Value.ToString());
                }
            }
            else
            {
                MessageBox.Show("Необходимо выделить товар");
            }
        }

        private void списатьТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string s = listBox1.SelectedItem.ToString();
                int i = 0;
                foreach (KeyValuePair<int, Product> p in shop.Shop)
                {
                    if (s == p.Value.ToString())
                    {
                        i = p.Key;
                        break;
                    }
                }
                shop.Delete_Event(i, s);
                listBox1.Items.Clear();
                foreach (KeyValuePair<int, Product> p in shop.Shop)
                {
                    listBox1.Items.Add(p.Value.ToString());
                }
            }
            else
            {
                MessageBox.Show("Необходимо выделить товар");
            }
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            j.list.Clear();
            File.Delete("Журнал.txt");
            File.Delete("Магазин.txt");
            shop.Shop.Clear();
        }

        private void продовольственныхТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int food = (from elem in shop.Shop where (elem.Value is Food_product) select elem).Count();
            if (food != 0)
                MessageBox.Show("Продовольственных товаров: " + food.ToString(), "Количество продовольственных товаров");
            else
            {
                MessageBox.Show("Продовольственных товаров нет");
            }
        }

        private void промышленныхТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int food = (from elem in shop.Shop where (elem.Value is Industrial_product) select elem).Count();
            if (food != 0)
                MessageBox.Show("Промышленных товаров: " + food.ToString(), "Количество промышленных товаров");
            else
            {
                MessageBox.Show("Промышленных товаров нет");
            }
        }

        private void товарыДляКнижныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int food = (from elem in shop.Shop where (elem.Value is Library_Product) select elem).Count();
            if (food != 0)
                MessageBox.Show("Товаров для библеотеки: " + food.ToString(), "Количество товаров для библеотеки");
            else
            {
                MessageBox.Show("Товаров для библиотеки нет");
            }
        }

        private void продовольственныхТоваровToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var food = from Food in shop.Shop where Food.Value is Food_product select Food;
            if (food.Count() != 0)
            {
                listBox1.Items.Clear();
                foreach (var f in food)
                    listBox1.Items.Add(f.Value.ToString());
            }
            else
            {
                MessageBox.Show("Продовольственных товаров нет");
            }
        }

        private void промышленныхТоваровToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var food = from Food in shop.Shop where Food.Value is Industrial_product select Food;
            if (food.Count() != 0)
            {
                listBox1.Items.Clear();
                foreach (var f in food)
                    listBox1.Items.Add(f.Value.ToString());
            }
            else
            {
                MessageBox.Show("Промышленных товаров нет");
            }
        }

        private void товаровДляКнижныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var food = from Food in shop.Shop where Food.Value is Library_Product select Food;
            if (food.Count() != 0)
            {
                listBox1.Items.Clear();
                foreach (var f in food)
                    listBox1.Items.Add(f.Value.ToString());
            }
            else
            {
                MessageBox.Show("Товаров для библиотеки нет");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void добавитьТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shop.Add_Event();
            listBox1.Items.Clear();
            foreach (KeyValuePair<int, Product> p in shop.Shop)
            {
                listBox1.Items.Add(p.Value.ToString());
            }
        }
    }
}
