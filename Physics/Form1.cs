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

        public int radioButtonChecked = 0;

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

        public void checkFirstTheme()
        {
            int correct = 0;
            if (th1gb1rb1.Checked)
            {
                correct++;
            }
            if(th1gb2rb2.Checked)
            {
                correct++;
            }
            if(th1gb3rb1.Checked)
            {
                correct++;
            }
            if(th1gb4rb4.Checked)
            {
                correct++;
            }
            correctLabel.Text = "Correct: " + correct.ToString() + "/4";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(radioButtonChecked)
            {
                case 0:
                    break;
                case 1:
                    checkFirstTheme();
                    break; 
            }
        }


        public void resetGroupBoxes()
        {
            Електродинаміка.Visible = false;
        }
        public void updateText()
        {
            switch(radioButtonChecked)
            {
                case 0:
                    break;
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
            radioButtonChecked = 1;
            updateText();
        }

        private void formRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonChecked = 2;
            updateText();
            
        }
    }
}
