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
    public partial class Фізика : Form
    {
        public Фізика()
        {
            InitializeComponent();
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
    }
}
