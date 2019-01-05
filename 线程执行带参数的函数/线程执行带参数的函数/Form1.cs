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

namespace 线程执行带参数的函数
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Test);
            thread.IsBackground = true;
            thread.Start(100);
        }

        private void Test(object n)
        {
            for (int i = 0; i < (int)n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
