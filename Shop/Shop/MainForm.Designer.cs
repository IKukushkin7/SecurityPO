namespace Shop
{
    partial class MainForm
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
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наЭкранToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.InFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SellProdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CountOfFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IndustrialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выводТовараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FoodToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.IndustrialToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OutSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainField = new System.Windows.Forms.ListBox();
            this.InSystem = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelErorIn = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.печатьToolStripMenuItem,
            this.AddProductToolStripMenuItem,
            this.SellProdToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.запросыToolStripMenuItem,
            this.ClearToolStripMenuItem,
            this.OutSystemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveFileToolStripMenuItem_Click);
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
            this.DisplayToolStripMenuItem1,
            this.InFileToolStripMenuItem1});
            this.наЭкранToolStripMenuItem.Name = "наЭкранToolStripMenuItem";
            this.наЭкранToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.наЭкранToolStripMenuItem.Text = "Журнал";
            // 
            // DisplayToolStripMenuItem1
            // 
            this.DisplayToolStripMenuItem1.Name = "DisplayToolStripMenuItem1";
            this.DisplayToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.DisplayToolStripMenuItem1.Text = "На экран";
            this.DisplayToolStripMenuItem1.Click += new System.EventHandler(this.LogDisplayToolStripMenuItem1_Click);
            // 
            // InFileToolStripMenuItem1
            // 
            this.InFileToolStripMenuItem1.Name = "InFileToolStripMenuItem1";
            this.InFileToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.InFileToolStripMenuItem1.Text = "В файл";
            this.InFileToolStripMenuItem1.Click += new System.EventHandler(this.LogInFileToolStripMenuItem1_Click);
            // 
            // вФайлToolStripMenuItem
            // 
            this.вФайлToolStripMenuItem.Name = "вФайлToolStripMenuItem";
            this.вФайлToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.вФайлToolStripMenuItem.Text = "Товары";
            this.вФайлToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // AddProductToolStripMenuItem
            // 
            this.AddProductToolStripMenuItem.Name = "AddProductToolStripMenuItem";
            this.AddProductToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.AddProductToolStripMenuItem.Text = "Добавить товар";
            this.AddProductToolStripMenuItem.Click += new System.EventHandler(this.AddProductToolStripMenuItem_Click);
            // 
            // SellProdToolStripMenuItem
            // 
            this.SellProdToolStripMenuItem.Name = "SellProdToolStripMenuItem";
            this.SellProdToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.SellProdToolStripMenuItem.Text = "Продать товар";
            this.SellProdToolStripMenuItem.Click += new System.EventHandler(this.SellProductToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.DeleteToolStripMenuItem.Text = "Списать товар";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteProductToolStripMenuItem_Click);
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
            this.CountOfFoodToolStripMenuItem,
            this.IndustrialToolStripMenuItem,
            this.BooksToolStripMenuItem});
            this.количествоToolStripMenuItem.Name = "количествоToolStripMenuItem";
            this.количествоToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.количествоToolStripMenuItem.Text = "Количество";
            // 
            // CountOfFoodToolStripMenuItem
            // 
            this.CountOfFoodToolStripMenuItem.Name = "CountOfFoodToolStripMenuItem";
            this.CountOfFoodToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.CountOfFoodToolStripMenuItem.Text = "Продовольственных товаров";
            this.CountOfFoodToolStripMenuItem.Click += new System.EventHandler(this.CountOfFoodProductToolStripMenuItem_Click);
            // 
            // IndustrialToolStripMenuItem
            // 
            this.IndustrialToolStripMenuItem.Name = "IndustrialToolStripMenuItem";
            this.IndustrialToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.IndustrialToolStripMenuItem.Text = "Промышленных товаров";
            this.IndustrialToolStripMenuItem.Click += new System.EventHandler(this.CountIndustrialProductToolStripMenuItem_Click);
            // 
            // BooksToolStripMenuItem
            // 
            this.BooksToolStripMenuItem.Name = "BooksToolStripMenuItem";
            this.BooksToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.BooksToolStripMenuItem.Text = "Товары для книжных";
            this.BooksToolStripMenuItem.Click += new System.EventHandler(this.CountBooksToolStripMenuItem_Click);
            // 
            // выводТовараToolStripMenuItem
            // 
            this.выводТовараToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FoodToolStripMenuItem1,
            this.IndustrialToolStripMenuItem1,
            this.BookToolStripMenuItem});
            this.выводТовараToolStripMenuItem.Name = "выводТовараToolStripMenuItem";
            this.выводТовараToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.выводТовараToolStripMenuItem.Text = "Вывод товара";
            // 
            // FoodToolStripMenuItem1
            // 
            this.FoodToolStripMenuItem1.Name = "FoodToolStripMenuItem1";
            this.FoodToolStripMenuItem1.Size = new System.Drawing.Size(234, 22);
            this.FoodToolStripMenuItem1.Text = "Продовольственных товаров";
            this.FoodToolStripMenuItem1.Click += new System.EventHandler(this.OutputOfFoodProductToolStripMenuItem1_Click);
            // 
            // IndustrialToolStripMenuItem1
            // 
            this.IndustrialToolStripMenuItem1.Name = "IndustrialToolStripMenuItem1";
            this.IndustrialToolStripMenuItem1.Size = new System.Drawing.Size(234, 22);
            this.IndustrialToolStripMenuItem1.Text = "Промышленных товаров";
            this.IndustrialToolStripMenuItem1.Click += new System.EventHandler(this.OutputIndustrialProductToolStripMenuItem1_Click);
            // 
            // BookToolStripMenuItem
            // 
            this.BookToolStripMenuItem.Name = "BookToolStripMenuItem";
            this.BookToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.BookToolStripMenuItem.Text = "Товаров для книжных";
            this.BookToolStripMenuItem.Click += new System.EventHandler(this.OutputBooksToolStripMenuItem_Click);
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.ClearToolStripMenuItem.Text = "Очистить";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.ClearMainFieldToolStripMenuItem_Click);
            // 
            // OutSystemToolStripMenuItem
            // 
            this.OutSystemToolStripMenuItem.Name = "OutSystemToolStripMenuItem";
            this.OutSystemToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.OutSystemToolStripMenuItem.Text = "Выход из системы";
            this.OutSystemToolStripMenuItem.Click += new System.EventHandler(this.OutSystemToolStripMenuItem_Click);
            // 
            // MainField
            // 
            this.MainField.FormattingEnabled = true;
            this.MainField.Location = new System.Drawing.Point(0, 23);
            this.MainField.Name = "MainField";
            this.MainField.Size = new System.Drawing.Size(935, 407);
            this.MainField.TabIndex = 1;
            this.MainField.Visible = false;
            // 
            // InSystem
            // 
            this.InSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InSystem.Location = new System.Drawing.Point(443, 245);
            this.InSystem.Name = "InSystem";
            this.InSystem.Size = new System.Drawing.Size(90, 34);
            this.InSystem.TabIndex = 2;
            this.InSystem.Text = "Вход";
            this.InSystem.UseVisualStyleBackColor = true;
            this.InSystem.Click += new System.EventHandler(this.InSystem_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(414, 171);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(160, 20);
            this.textBoxLogin.TabIndex = 3;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(414, 206);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '✱';
            this.textBoxPass.Size = new System.Drawing.Size(160, 20);
            this.textBoxPass.TabIndex = 4;
            this.textBoxPass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(351, 173);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(44, 18);
            this.labelLogin.TabIndex = 5;
            this.labelLogin.Text = "Login";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPass.Location = new System.Drawing.Point(333, 208);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(75, 18);
            this.labelPass.TabIndex = 6;
            this.labelPass.Text = "Password";
            // 
            // labelErorIn
            // 
            this.labelErorIn.AutoSize = true;
            this.labelErorIn.Location = new System.Drawing.Point(400, 134);
            this.labelErorIn.Name = "labelErorIn";
            this.labelErorIn.Size = new System.Drawing.Size(0, 13);
            this.labelErorIn.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 433);
            this.Controls.Add(this.labelErorIn);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.InSystem);
            this.Controls.Add(this.MainField);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Магазин";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ListBox MainField;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наЭкранToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DisplayToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem InFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AddProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SellProdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выводТовараToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CountOfFoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IndustrialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FoodToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem IndustrialToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem BookToolStripMenuItem;
        private System.Windows.Forms.Button InSystem;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelErorIn;
        private System.Windows.Forms.ToolStripMenuItem OutSystemToolStripMenuItem;
    }
}

