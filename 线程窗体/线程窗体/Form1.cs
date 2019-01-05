using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 线程窗体
{
    public partial class Form1 : Form
    {
        Thread thread;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thread=new Thread(Test);
            //将线程设置为后台线程
            thread.IsBackground = true;
            thread.Start();
        }

        private void Test()
        {
            for (int i = 0; i < 10000; i++)
            {
                //Console.WriteLine(i);
                textBox1.Text = i.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //取消跨线程的访问
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(thread!=null)
            {
                //终止线程
                thread.Abort();
                MessageBox.Show("自己创建的线程也终止了");
            }
        }
    }
}
