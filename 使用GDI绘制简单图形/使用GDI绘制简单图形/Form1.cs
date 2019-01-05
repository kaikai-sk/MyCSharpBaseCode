using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 使用GDI绘制简单图形
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //创建GDI对象
            Graphics g = this.CreateGraphics();
            //创建画笔对象
            Pen pen = new Pen(Brushes.Red);
            //创建两个点
            Point p1 = new Point(30, 30);
            Point p2 = new Point(250, 80);
            //画直线
            g.DrawLine(pen, p1, p2);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //创建GDI对象
            Graphics g = this.CreateGraphics();
            //创建画笔对象
            Pen pen = new Pen(Brushes.Red);
            //创建两个点
            Point p1 = new Point(30, 30);
            Point p2 = new Point(250, 80);
            //画直线
            g.DrawLine(pen, p1, p2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Yellow);
            Rectangle rect = new Rectangle(50, 50, 80, 80);
            g.DrawRectangle(pen, rect);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Blue);
            Rectangle rect = new Rectangle(150, 150, 180, 180);
            float startAngle = 60;
            float sweepAngle = 60;
            g.DrawPie(pen, rect, startAngle, sweepAngle);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawString("我是最帅的",
                new Font("华文行楷", 20, FontStyle.Underline), 
                Brushes.Blue, 
                new PointF(100, 150));//
        }
    }
}
