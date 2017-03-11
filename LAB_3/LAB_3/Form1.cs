using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_3
{
    public partial class Form1 : Form
    {
        Graphics drawArea;
        public Form1()
        {
            InitializeComponent();
            drawArea = pictureBox1.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen blackPen = new Pen(Color.Black);
            drawArea.DrawLine(blackPen, 10, 20, 150, 20);

            Pen greenPen = new Pen(Color.Green, 5);
            drawArea.DrawLine(greenPen, 10, 40, 150, 40);

            Pen yellowPen = new Pen(Color.Yellow, 10);
            drawArea.DrawLine(yellowPen, 10, 60, 150, 60);

            Pen grayPen = new Pen(Color.Gray, 15);
            drawArea.DrawLine(grayPen, 10, 85, 150, 85);

            Pen redPen = new Pen(Color.Red, 20);
            drawArea.DrawLine(redPen, 10, 120, 150, 120);
        }
    }
}
