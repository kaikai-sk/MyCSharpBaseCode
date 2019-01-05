using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace 双击播放音乐
{
    public partial class Form1 : Form
    {
        string[] paths = Directory.GetFiles(@"C:\Users\单凯\Desktop\music");

        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < paths.Length; i++)
            {
                listBox1.Items.Add(Path.GetFileName(paths[i]));
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = paths[listBox1.SelectedIndex];
            sp.Play();
        }
    }
}
