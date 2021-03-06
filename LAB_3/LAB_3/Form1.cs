﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace LAB_3
{
    public partial class Form1 : Form
    {
        Graphics drawArea, canvas;
        public List<Point> pointsForBezier = new List<Point>();

        public Form1()
        {
            InitializeComponent();
            drawArea = pictureBox1.CreateGraphics();
            canvas = pictureBox2.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            drawArea.Clear(Color.White);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawArea.Clear(Color.White);
            
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

        private void button2_Click(object sender, EventArgs e)
        {
            drawArea.Clear(Color.White);
            Pen blackPen = new Pen(Color.Black, 3);

            Point start = new Point(10, 10);
            Point control1 = new Point(20, 10);
            Point control2 = new Point(90, 50);
            Point end1 = new Point(50, 100);
            Point control3 = new Point(60, 150);
            Point control4 = new Point(60, 250);
            Point end2 = new Point(50, 300);
            Point[] bezierPoints =
             {
                 start, control1, control2, end1,
                 control3, control4, end2
             };
            drawArea.DrawBeziers(blackPen, bezierPoints);

            Pen redPen = new Pen(Color.Red, 3);

            start = new Point(50, 50);
            control1 = new Point(20, 10);
            control2 = new Point(120, 75);
            end1 = new Point(150, 200);
            control3 = new Point(160, 150);
            control4 = new Point(160, 250);
            end2 = new Point(150, 300);
            Point[] bezierPoints2 =
             {
                 start, control1, control2, end1,
                 control3, control4, end2
             };
            drawArea.DrawBeziers(redPen, bezierPoints2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            drawArea.Clear(Color.White);

            Pen redPen = new Pen(Color.Red, 3);
            drawArea.DrawEllipse(redPen, new Rectangle(10, 10, 100, 100));

            Pen yellowPen = new Pen(Color.Yellow, 5);
            drawArea.DrawRectangle(yellowPen, new Rectangle(150, 0, 150, 150));

            Pen grayPen = new Pen(Color.Gray, 1);
            Point p1 = new Point(0, 150);
            Point p2 = new Point(120, 180);
            Point p3 = new Point(125, 250);
            Point[] curvePoints =
            {
                p1, p2, p3
            };
            drawArea.DrawPolygon(grayPen, curvePoints);

            Pen greenPen = new Pen(Color.Green, 5);
            RectangleF rect = new RectangleF(100.0F, 100.0F, 200.0F, 200.0F);
            float startAngle = 0.0F;
            float sweepAngle = 45.0F;

            drawArea.DrawPie(greenPen, rect, startAngle, sweepAngle);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            drawArea.Clear(Color.White);

            Bitmap flag = new Bitmap(200, 100);
            Graphics flagGraphics = Graphics.FromImage(flag);
            int red = 0;
            int white = 11;
            while (white <= 100)
            {
                flagGraphics.FillRectangle(Brushes.Aquamarine, 0, red, 200, 10);
                flagGraphics.FillRectangle(Brushes.BlueViolet, 0, white, 200, 10);
                red += 20;
                white += 20;
            }
            pictureBox1.Image = flag;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                drawArea.Clear(Color.White);
            }
        }

        public int xInit = 0, yInit = 0;
        public int xFinal = 0, yFinal = 0;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                xInit = e.X;
                yInit = e.Y;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                xFinal = e.X;
                yFinal = e.Y;

                Pen greenPen = new Pen(Color.Green, 3);
                Pen grayPen = new Pen(Color.Gray, 3);

                Rectangle commonRect = new Rectangle(xInit, yInit, xFinal, yFinal);

                drawArea.DrawRectangle(grayPen, commonRect);
                drawArea.DrawEllipse(greenPen, commonRect);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            drawArea.Clear(Color.White);

            LinearGradientBrush linGrBrush = new LinearGradientBrush(
            new Point(0, 10),
            new Point(200, 10),
            Color.FromArgb(255, 56, 0, 14), 
            Color.FromArgb(255, 213, 54, 25));  

            Pen pen = new Pen(linGrBrush);

            drawArea.FillEllipse(linGrBrush, 0, 30, 200, 100);
            drawArea.FillRectangle(linGrBrush, 30, 150, 150, 30);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            //pointsForBezier.Add(new Point(e.X, e.Y));
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            pointsForBezier.Add(new Point(e.X, e.Y));
            
            Point[] points = pointsForBezier.ToArray();
            Pen redPen = new Pen(Color.Red, 1);

            canvas.DrawBeziers(redPen, points);

            if (pointsForBezier.Count >= 4)
            {
                pointsForBezier = new List<Point>();
            }
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            canvas.Clear(Color.White);
            pointsForBezier.Add(new Point(e.X, e.Y));
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.I)
            {
                drawArea.ScaleTransform(150, 100);
            }
        }
    }
}
