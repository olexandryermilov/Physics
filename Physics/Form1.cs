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
            resetPictureBoxes();
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
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox5.Visible = true;
            }
            if(th1gb2rb2.Checked)
            {
                correct++;
                pictureBox2.Visible = true;
            }
            else
            {
                pictureBox6.Visible = true;
            }
            if(th1gb3rb1.Checked)
            {
                correct++;
                pictureBox3.Visible = true;
            }
            else
            {
                pictureBox7.Visible = true;
            }
            if(th1gb4rb4.Checked)
            {
                correct++;
                pictureBox4.Visible = true;
            }
            else
            {
                pictureBox8.Visible = true;
            }
            correctLabel.Text = "Correct: " + correct.ToString() + "/4";
        }

        public void checkSecondTheme()
        {
            int correct = 0;
            if (th2gr1rb1.Checked)
            {
                correct++;
                th2gr1pb1.Visible = true;
            }
            else
            {
                th2gr1pb2.Visible = true;
            }
            if (th2gr2rb3.Checked)
            {
                correct++;
                th2gr2pb1.Visible = true;
            }
            else
            {
                th2gr2pb2.Visible = true;
            }
            if (th2gr3rb3.Checked)
            {
                correct++;
                th2gr3pb1.Visible = true;
            }
            else
            {
                th2gr3pb2.Visible = true;
            }
            if (th2gr4rb2.Checked)
            {
                correct++;
                th2gr4pb1.Visible = true;
            }
            else
            {
                th2gr4pb2.Visible = true;
            }
            correctLabel.Text = "Correct: " + correct.ToString() + "/4";
        }

        public void resetPictureBoxes()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;

            th2gr1pb1.Visible = false;
            th2gr2pb1.Visible = false;
            th2gr3pb1.Visible = false;
            th2gr4pb1.Visible = false;
            th2gr1pb2.Visible = false;
            th2gr2pb2.Visible = false;
            th2gr3pb2.Visible = false;
            th2gr4pb2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetPictureBoxes();
            switch(radioButtonChecked)
            {
                case 0:
                    break;
                case 1:
                    checkFirstTheme();
                    break;
                case 2:
                    checkSecondTheme();
                    break;
            }
        }


        public void resetGroupBoxes()
        {
            Електродинаміка.Visible = false;
            ЗаконОма.Visible = false;
        }
        public void updateText()
        {
            correctLabel.Text = "Correct: 0/0";
            switch(radioButtonChecked)
            {
                case 0:
                    break;
                case 1:
                    webBrowser1.Navigate("http://disted.edu.vn.ua/courses/learn/6029");
                    resetGroupBoxes();
                    Електродинаміка.Visible = true;
                    break;
                case 2:
                    resetGroupBoxes();
                    ЗаконОма.Visible = true;
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
