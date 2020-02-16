namespace КурсоваяРабота
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наЭкранToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наЭкранToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вФайлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.добавитьТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продатьТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списатьТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выводТовараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продовольственныхТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.промышленныхТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыДляКнижныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продовольственныхТоваровToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.промышленныхТоваровToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.товаровДляКнижныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.печатьToolStripMenuItem,
            this.добавитьТоварToolStripMenuItem,
            this.продатьТоварToolStripMenuItem,
            this.списатьТоварToolStripMenuItem,
            this.запросыToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.наЭкранToolStripMenuItem,
            this.вФайлToolStripMenuItem});
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.печатьToolStripMenuItem.Text = "Печать";
            // 
            // наЭкранToolStripMenuItem
            // 
            this.наЭкранToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.наЭкранToolStripMenuItem1,
            this.вФайлToolStripMenuItem1});
            this.наЭкранToolStripMenuItem.Name = "наЭкранToolStripMenuItem";
            this.наЭкранToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.наЭкранToolStripMenuItem.Text = "Журнал";
            // 
            // наЭкранToolStripMenuItem1
            // 
            this.наЭкранToolStripMenuItem1.Name = "наЭкранToolStripMenuItem1";
            this.наЭкранToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.наЭкранToolStripMenuItem1.Text = "На экран";
            this.наЭкранToolStripMenuItem1.Click += new System.EventHandler(this.наЭкранToolStripMenuItem1_Click);
            // 
            // вФайлToolStripMenuItem1
            // 
            this.вФайлToolStripMenuItem1.Name = "вФайлToolStripMenuItem1";
            this.вФайлToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.вФайлToolStripMenuItem1.Text = "В файл";
            this.вФайлToolStripMenuItem1.Click += new System.EventHandler(this.вФайлToolStripMenuItem1_Click);
            // 
            // вФайлToolStripMenuItem
            // 
            this.вФайлToolStripMenuItem.Name = "вФайлToolStripMenuItem";
            this.вФайлToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.вФайлToolStripMenuItem.Text = "Товары";
            this.вФайлToolStripMenuItem.Click += new System.EventHandler(this.вФайлToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(935, 407);
            this.listBox1.TabIndex = 1;
            // 
            // добавитьТоварToolStripMenuItem
            // 
            this.добавитьТоварToolStripMenuItem.Name = "добавитьТоварToolStripMenuItem";
            this.добавитьТоварToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.добавитьТоварToolStripMenuItem.Text = "Добавить товар";
            this.добавитьТоварToolStripMenuItem.Click += new System.EventHandler(this.добавитьТоварToolStripMenuItem_Click);
            // 
            // продатьТоварToolStripMenuItem
            // 
            this.продатьТоварToolStripMenuItem.Name = "продатьТоварToolStripMenuItem";
            this.продатьТоварToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.продатьТоварToolStripMenuItem.Text = "Продать товар";
            this.продатьТоварToolStripMenuItem.Click += new System.EventHandler(this.продатьТоварToolStripMenuItem_Click);
            // 
            // списатьТоварToolStripMenuItem
            // 
            this.списатьТоварToolStripMenuItem.Name = "списатьТоварToolStripMenuItem";
            this.списатьТоварToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.списатьТоварToolStripMenuItem.Text = "Списать товар";
            this.списатьТоварToolStripMenuItem.Click += new System.EventHandler(this.списатьТоварToolStripMenuItem_Click);
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.количествоToolStripMenuItem,
            this.выводТовараToolStripMenuItem});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // количествоToolStripMenuItem
            // 
            this.количествоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.продовольственныхТоваровToolStripMenuItem,
            this.промышленныхТоваровToolStripMenuItem,
            this.товарыДляКнижныхToolStripMenuItem});
            this.количествоToolStripMenuItem.Name = "количествоToolStripMenuItem";
            this.количествоToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.количествоToolStripMenuItem.Text = "Количество";
            // 
            // выводТовараToolStripMenuItem
            // 
            this.выводТовараToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.продовольственныхТоваровToolStripMenuItem1,
            this.промышленныхТоваровToolStripMenuItem1,
            this.товаровДляКнижныхToolStripMenuItem});
            this.выводТовараToolStripMenuItem.Name = "выводТовараToolStripMenuItem";
            this.выводТовараToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выводТовараToolStripMenuItem.Text = "Вывод товара";
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // продовольственныхТоваровToolStripMenuItem
            // 
            this.продовольственныхТоваровToolStripMenuItem.Name = "продовольственныхТоваровToolStripMenuItem";
            this.продовольственныхТоваровToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.продовольственныхТоваровToolStripMenuItem.Text = "Продовольственных товаров";
            this.продовольственныхТоваровToolStripMenuItem.Click += new System.EventHandler(this.продовольственныхТоваровToolStripMenuItem_Click);
            // 
            // промышленныхТоваровToolStripMenuItem
            // 
            this.промышленныхТоваровToolStripMenuItem.Name = "промышленныхТоваровToolStripMenuItem";
            this.промышленныхТоваровToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.промышленныхТоваровToolStripMenuItem.Text = "Промышленных товаров";
            this.промышленныхТоваровToolStripMenuItem.Click += new System.EventHandler(this.промышленныхТоваровToolStripMenuItem_Click);
            // 
            // товарыДляКнижныхToolStripMenuItem
            // 
            this.товарыДляКнижныхToolStripMenuItem.Name = "товарыДляКнижныхToolStripMenuItem";
            this.товарыДляКнижныхToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.товарыДляКнижныхToolStripMenuItem.Text = "Товары для книжных";
            this.товарыДляКнижныхToolStripMenuItem.Click += new System.EventHandler(this.товарыДляКнижныхToolStripMenuItem_Click);
            // 
            // продовольственныхТоваровToolStripMenuItem1
            // 
            this.продовольственныхТоваровToolStripMenuItem1.Name = "продовольственныхТоваровToolStripMenuItem1";
            this.продовольственныхТоваровToolStripMenuItem1.Size = new System.Drawing.Size(234, 22);
            this.продовольственныхТоваровToolStripMenuItem1.Text = "Продовольственных товаров";
            this.продовольственныхТоваровToolStripMenuItem1.Click += new System.EventHandler(this.продовольственныхТоваровToolStripMenuItem1_Click);
            // 
            // промышленныхТоваровToolStripMenuItem1
            // 
            this.промышленныхТоваровToolStripMenuItem1.Name = "промышленныхТоваровToolStripMenuItem1";
            this.промышленныхТоваровToolStripMenuItem1.Size = new System.Drawing.Size(234, 22);
            this.промышленныхТоваровToolStripMenuItem1.Text = "Промышленных товаров";
            this.промышленныхТоваровToolStripMenuItem1.Click += new System.EventHandler(this.промышленныхТоваровToolStripMenuItem1_Click);
            // 
            // товаровДляКнижныхToolStripMenuItem
            // 
            this.товаровДляКнижныхToolStripMenuItem.Name = "товаровДляКнижныхToolStripMenuItem";
            this.товаровДляКнижныхToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.товаровДляКнижныхToolStripMenuItem.Text = "Товаров для книжных";
            this.товаровДляКнижныхToolStripMenuItem.Click += new System.EventHandler(this.товаровДляКнижныхToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 433);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Магазин";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наЭкранToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наЭкранToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вФайлToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьТоварToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продатьТоварToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списатьТоварToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выводТовараToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продовольственныхТоваровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem промышленныхТоваровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарыДляКнижныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продовольственныхТоваровToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem промышленныхТоваровToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem товаровДляКнижныхToolStripMenuItem;
    }
}

