using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox和Timer的练习
{
    public partial class Form1 : Form
    {
        string[] paths = Directory.GetFiles(Path.GetDirectoryName(@"C:\Users\单凯\Desktop\girls\1.jpg"));
        Random r = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            //初始化窗体的时候，加载一张图片
            pictureBox1.Image = Image.FromFile(@"C:\Users\单凯\Desktop\girls\1.jpg");
            pictureBox2.Image = Image.FromFile(@"C:\Users\单凯\Desktop\girls\1.jpg");
            pictureBox3.Image = Image.FromFile(@"C:\Users\单凯\Desktop\girls\1.jpg");
            pictureBox4.Image = Image.FromFile(@"C:\Users\单凯\Desktop\girls\1.jpg");
            pictureBox5.Image = Image.FromFile(@"C:\Users\单凯\Desktop\girls\1.jpg");
            pictureBox6.Image = Image.FromFile(@"C:\Users\单凯\Desktop\girls\1.jpg");

            //播放音乐
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @"C:\Users\单凯\Desktop\棋魂.wav";
            sp.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(paths[r.Next(0,paths.Length)]);
            pictureBox2.Image = Image.FromFile(paths[r.Next(0, paths.Length)]);
            pictureBox3.Image = Image.FromFile(paths[r.Next(0, paths.Length)]);
            pictureBox4.Image = Image.FromFile(paths[r.Next(0, paths.Length)]);
            pictureBox5.Image = Image.FromFile(paths[r.Next(0, paths.Length)]);
            pictureBox6.Image = Image.FromFile(paths[r.Next(0, paths.Length)]);
        }
    }
}
