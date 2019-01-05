using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 跑马灯
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("你中病毒了~~~！！！，关不掉了吧！！！");
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
        }

        /// <summary>
        /// 用于显示当前的时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
            //15:42播放音乐
            if(DateTime.Now.Hour==15 && DateTime.Now.Minute==59 && DateTime.Now.Second==22)
            {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = @"D:\搜狗高速下载\苏打绿 - 无与伦比的美丽.wav";
                sp.Play();
            }
        }

        /// <summary>
        /// 当加载窗体的时候，把系统时间赋给label2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }
    }
}
