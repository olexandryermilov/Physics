using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Physics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            resetGroupBoxes();
        }

        private void білийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void синійToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void сірийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Програма створена ", "Дані про програму", MessageBoxButtons.OK);
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви справді хочете закрити форму?", "Закриття форми", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        public void resetGroupBoxes()
        {
            Електродинаміка.Visible = false;
        }
        public void updateText(int k)
        {
            switch(k)
            {
                case 1:
                    webBrowser1.Navigate("http://disted.edu.vn.ua/courses/learn/4837");
                    resetGroupBoxes();
                    Електродинаміка.Visible = true;
                    break;
                case 2:
                    resetGroupBoxes();
                    break;
            }
        }

        private void formRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
               updateText(1);
        }

        private void formRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            updateText(2);
        }
    }
}
