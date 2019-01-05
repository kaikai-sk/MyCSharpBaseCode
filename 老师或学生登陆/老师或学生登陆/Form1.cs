using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 老师或学生登陆
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(!RadioStudent.Checked && !radioTeacher.Checked)
            {
                MessageBox.Show("请先选择登录身份，老师还是学生");
                return;
            }
            string name = txtName.Text.Trim();
            string pwd = txtPwd.Text.Trim();
            if(RadioStudent.Checked)
            {
                if(name=="student" && pwd=="student")
                {
                    MessageBox.Show("学生登陆成功！");
                }
                else
                {
                    MessageBox.Show("登录失败");
                    txtName.Clear();
                    txtPwd.Clear();
                    txtName.Focus();
                }
            }
            else
            {
                if(name=="teacher" && pwd=="teacher")
                {
                    MessageBox.Show("老师登陆成功");
                }
                else
                {
                    MessageBox.Show("登录失败");
                    txtName.Clear();
                    txtPwd.Clear();
                    txtName.Focus();
                }
            }
        }
    }
}
