using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Cross;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked on a button!", "Yay!");
        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.BackColor = Color.FromArgb((byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255));
        }

        private void changeTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "New title.";
        }

        private void changeSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.Size = new Size((int)random.Next(100,400),(int)random.Next(100,400));
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Random random = new Random();
            button1.BackColor = Color.FromArgb((byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int choise = listBox1.SelectedIndex;
            switch (choise)
            {
                case 0:
                    this.Top -= 10;
                    break;
                case 1:
                    this.Top += 10;
                    break;
                case 2:
                    this.Left -= 10;
                    break;
                case 3:
                    this.Left += 10;
                    break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.U)
            {
                this.Top = 0;
                this.Left = 0;
            }
            if (e.Control && e.KeyCode == Keys.X)
            {
                this.Close();
            }
        }
    }
}
