namespace Physics
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.фToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.колірФонуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.білийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синійToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сірийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Електродинаміка = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.formRadioButton1 = new System.Windows.Forms.RadioButton();
            this.formRadioButton2 = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Електродинаміка.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фToolStripMenuItem,
            this.видToolStripMenuItem,
            this.проПрограмуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // фToolStripMenuItem
            // 
            this.фToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вихідToolStripMenuItem});
            this.фToolStripMenuItem.Name = "фToolStripMenuItem";
            this.фToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.фToolStripMenuItem.Text = "Файл";
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.колірФонуToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // колірФонуToolStripMenuItem
            // 
            this.колірФонуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.білийToolStripMenuItem,
            this.синійToolStripMenuItem,
            this.сірийToolStripMenuItem});
            this.колірФонуToolStripMenuItem.Name = "колірФонуToolStripMenuItem";
            this.колірФонуToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.колірФонуToolStripMenuItem.Text = "Колір фону";
            // 
            // білийToolStripMenuItem
            // 
            this.білийToolStripMenuItem.Name = "білийToolStripMenuItem";
            this.білийToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.білийToolStripMenuItem.Text = "білий";
            this.білийToolStripMenuItem.Click += new System.EventHandler(this.білийToolStripMenuItem_Click);
            // 
            // синійToolStripMenuItem
            // 
            this.синійToolStripMenuItem.Name = "синійToolStripMenuItem";
            this.синійToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.синійToolStripMenuItem.Text = "синій";
            this.синійToolStripMenuItem.Click += new System.EventHandler(this.синійToolStripMenuItem_Click);
            // 
            // сірийToolStripMenuItem
            // 
            this.сірийToolStripMenuItem.Name = "сірийToolStripMenuItem";
            this.сірийToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.сірийToolStripMenuItem.Text = "сірий";
            this.сірийToolStripMenuItem.Click += new System.EventHandler(this.сірийToolStripMenuItem_Click);
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(247, 287);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(239, 261);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Матеріали";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(233, 255);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Електродинаміка);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(239, 261);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Тести";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Електродинаміка
            // 
            this.Електродинаміка.Controls.Add(this.groupBox2);
            this.Електродинаміка.Location = new System.Drawing.Point(6, 6);
            this.Електродинаміка.Name = "Електродинаміка";
            this.Електродинаміка.Size = new System.Drawing.Size(200, 100);
            this.Електродинаміка.TabIndex = 6;
            this.Електродинаміка.TabStop = false;
            this.Електродинаміка.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(111, 35);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Перевірка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(295, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // formRadioButton1
            // 
            this.formRadioButton1.AutoSize = true;
            this.formRadioButton1.Location = new System.Drawing.Point(279, 65);
            this.formRadioButton1.Name = "formRadioButton1";
            this.formRadioButton1.Size = new System.Drawing.Size(99, 17);
            this.formRadioButton1.TabIndex = 3;
            this.formRadioButton1.TabStop = true;
            this.formRadioButton1.Text = "Змінний струм";
            this.formRadioButton1.UseVisualStyleBackColor = true;
            this.formRadioButton1.CheckedChanged += new System.EventHandler(this.formRadioButton1_CheckedChanged);
            // 
            // formRadioButton2
            // 
            this.formRadioButton2.AutoSize = true;
            this.formRadioButton2.Location = new System.Drawing.Point(279, 88);
            this.formRadioButton2.Name = "formRadioButton2";
            this.formRadioButton2.Size = new System.Drawing.Size(34, 17);
            this.formRadioButton2.TabIndex = 3;
            this.formRadioButton2.TabStop = true;
            this.formRadioButton2.Text = "...";
            this.formRadioButton2.UseVisualStyleBackColor = true;
            this.formRadioButton2.CheckedChanged += new System.EventHandler(this.formRadioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 338);
            this.Controls.Add(this.formRadioButton2);
            this.Controls.Add(this.formRadioButton1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Фізика";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.Електродинаміка.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem фToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem колірФонуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem білийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синійToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сірийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton formRadioButton1;
        private System.Windows.Forms.RadioButton formRadioButton2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox Електродинаміка;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

