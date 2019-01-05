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

namespace 文件打开对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();

            //设置对话框的标题
            openDlg.Title = "单凯的文件打开对话框";
            //设置可以多选
            openDlg.Multiselect = true;
            //设置对话框的初始目录
            openDlg.InitialDirectory = @"C:\Users\单凯\Desktop\";
            //设置可以打开的文件类型
            openDlg.Filter = "文本文件|*.txt|视频文件|*.wav|图片文件|*.wav|所有文件|*.*";

            openDlg.ShowDialog();

            //获得路径，打开文本文件
            string path = openDlg.FileName;
            if(path=="")
            {
                return;
            }
            using (FileStream fsRead = new FileStream(path,
                FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int len = fsRead.Read(buffer, 0, buffer.Length);
                textBox1.Text = Encoding.UTF8.GetString(buffer);
            }
        }
    }
}
