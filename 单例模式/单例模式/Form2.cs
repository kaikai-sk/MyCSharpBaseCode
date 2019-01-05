﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 单例模式
{
    public partial class Form2 : Form
    {
        private static Form2 fmSingle=null;

        private Form2()
        {
            InitializeComponent();
        }

        public static Form2 GetInstance()
        {
            if(fmSingle==null)
            {
                fmSingle = new Form2();
            }
            return fmSingle;
        }
    }
}
