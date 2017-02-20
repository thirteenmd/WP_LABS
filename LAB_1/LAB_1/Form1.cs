using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(300, 350);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked on a Standart button!", "Boo!");
            textBox1.Text = "Boo";
            this.Text = "You just clicked on a Standart button!";
            this.BackColor = Color.AntiqueWhite;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked on a Standart button!", "Yaay!");
            textBox2.Text = "Yaay";
            this.Text = "You just clicked on a Standart button!";
            this.BackColor = Color.Azure;
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            if (this.Width < 560)
            {
                label2.Top = button1.Top + 30;
                label2.Left = button1.Left;

                textBox2.Top = label2.Top + 30;
                textBox2.Left = button1.Left;

                button2.Top = textBox2.Top + 30;
                button2.Left = button1.Left;
            }

            if (this.Width > 560)
            {
                label2.Top = label1.Top;
                label2.Left = 330;

                textBox2.Top = textBox1.Top;
                textBox2.Left = 330;

                button2.Top = button1.Top;
                button2.Left = 330;
            }
        }
    }
}
