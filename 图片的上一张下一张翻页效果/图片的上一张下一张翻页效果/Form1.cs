using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图片的上一张下一张翻页效果
{
    public partial class Form1 : Form
    {
        //获得指定文件夹中所有文件的全路径
        string[] paths = Directory.GetFiles(Path.GetDirectoryName(@"C:\Users\单凯\Desktop\girls\1.jpg"));
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\单凯\Desktop\girls\1.jpg");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(paths[i]);
            i++;
            if(i==paths.Length)
            {
                i = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(paths[i]);
            i--;
            if (i < 0)
            {
                i = paths.Length-1;
            }
        }
    }
}
