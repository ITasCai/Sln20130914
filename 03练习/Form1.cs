using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _03练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            foreach (Control item in this.Controls)
            {
                //判断当前控件是否为文本框
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "传智播客";
                }
                //报错！！！！
                //((TextBox)item).Text = "传智播客";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
