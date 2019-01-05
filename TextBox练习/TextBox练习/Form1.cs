using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 当文本框中的值发生改变的时候，将其赋给label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtWords_TextChanged(object sender, EventArgs e)
        {
            lblText.Text = txtWords.Text;
        }
    }
}
