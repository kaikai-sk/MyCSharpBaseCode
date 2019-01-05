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

namespace 文件保存对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Title = "我的文件保存对话框";
            saveDlg.InitialDirectory = @"C:\Users\单凯\Desktop\";
            saveDlg.Filter = "文本文件|*.txt|所有文件|*.*";
            saveDlg.ShowDialog();
            string path = saveDlg.FileName;
            if(""==path)
            {
                return;
            }
            using (FileStream fsWrite = new FileStream(path,
                FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] buffer = Encoding.Default.GetBytes(textBox1.Text);
                fsWrite.Write(buffer, 0, buffer.Length);
            }
            MessageBox.Show("文件保存成功！"); 
        }
    }
}
