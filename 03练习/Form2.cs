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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.cboCaozuoFu.SelectedIndex = 0;
        }



        //计算
        private void button1_Click(object sender, EventArgs e)
        {

            //采集数据
            int n1 = Convert.ToInt32(txtNumber1.Text.Trim());
            int n2 = int.Parse(txtNumber2.Text.Trim());
            if (cboCaozuoFu.SelectedIndex == 0)
            {
                MessageBox.Show("请选择一个操作符后再执行计算！");
            }
            else
            {
                int r = 0;
                //判断用户选择的操作符
                switch (cboCaozuoFu.Text)
                {
                    case "+":
                        r = n1 + n2;
                        break;
                    case "-":
                        r = n1 - n2;
                        break;
                    case "*":
                        r = n1 * n2;
                        break;
                    case "/":
                        r = n1 / n2;
                        break;
                    default:
                        MessageBox.Show("未知的运算符");
                        return;
                }
                lblResult.Text = r.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            MessageBox.Show(r.Next(1, 51).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
