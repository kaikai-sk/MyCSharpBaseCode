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

namespace 点击名称更换图片
{

    public partial class Form1 : Form
    {
        string[] paths = Directory.GetFiles(@"C:\Users\单凯\Desktop\girls");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < paths.Length; i++)
            {
                listBox1.Items.Add(Path.GetFileName(paths[i]));
            }
        }

        /// <summary>
        /// 双击列表控件的一项，显示对应的图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(paths[listBox1.SelectedIndex]);
        }
    }
}
