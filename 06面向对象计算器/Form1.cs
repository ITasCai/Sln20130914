﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _06面向对象计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cal cal = new Cal();
            //采集数据
            cal.Number1 = Convert.ToInt32(txtNumber1.Text.Trim());
            cal.Number2 = int.Parse(txtNumber2.Text.Trim());
            if (cboCaozuoFu.SelectedIndex == 0)
            {
                MessageBox.Show("请选择一个操作符后再执行计算！");
            }
            else
            {

                lblResult.Text = cal.JiSuan(cboCaozuoFu.Text).ToString();
            }
        }
    }
}
