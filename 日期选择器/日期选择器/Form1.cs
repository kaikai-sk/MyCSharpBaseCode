using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 日期选择器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //获得当前的年份
            int year = DateTime.Now.Year;
            for (int i = year; i >= 1949; i--)
            {
                cboYear.Items.Add(i + "年");
            }
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMonth.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cboMonth.Items.Add(i + "月");
            }
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDay.Items.Clear();
            int days = 0;//定义天数
            //获得月份的数字
            string strMonth = cboMonth.SelectedItem.ToString().Split(new char[] { '月' }, 
                StringSplitOptions.RemoveEmptyEntries)[0];
            string strYer = cboYear.SelectedItem.ToString().Split(new char[] { '年' },
            StringSplitOptions.RemoveEmptyEntries)[0];
            int year = Convert.ToInt32(strYer);
            int month = Convert.ToInt32(strMonth);
            switch (month)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    {
                        days = 31;
                        break;
                    }
                case 2:
                    {
                        if(isLeapYear(year))
                        {
                            days = 29;
                        }
                        else
                        {
                            days = 28;
                        }
                        break;
                    }
                case 4: case 6:case 9: case 11:
                    {
                        days = 30;
                        break;
                    }
                default:
                    break;
            }
            for (int i = 1; i <= days; i++)
            {
                cboDay.Items.Add(i + "天");
            }
        }

        public static bool isLeapYear(int year)
        {
            if((year%400==0) || (year%100!=0) && (year%4==0) )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
