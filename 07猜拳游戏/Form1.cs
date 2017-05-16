using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _07猜拳游戏
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //int 年龄 = 100;
            //Console.WriteLine(年龄);
        }

        //用户点击"石头"
        private void button1_Click(object sender, EventArgs e)
        {
            //怎么获取当前用户点击的是哪个按钮
            Button btn = (Button)sender;

            string userfist = btn.Text;
            StartGame(userfist);
        }

        private void StartGame(string userfist)
        {
            //实例化一个用户
            Player p1 = new Player();
            int playerfist = p1.ShowFist(userfist);
            this.lblYou.Text = p1.Fist;

            //实例化一个计算机
            PC pc = new PC();
            int pcFist = pc.ShowFist();

            lblPC.Text = pc.Fist;

            //比较出拳结果
            int r = CaiPan.IsPlayerWin(playerfist, pcFist);
            switch (r)
            {
                case 0:
                    lblResult.Text = "平局";
                    break;
                case 1:
                    lblResult.Text = "赢了";
                    break;
                case -1:
                    lblResult.Text = "输了";
                    break;
            }
        }


        //DRY :Don't Repeat Yourself

        ////剪刀
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    string userfist = "剪刀";
        //    StartGame(userfist);
        //}


        ////布
        //private void button3_Click(object sender, EventArgs e)
        //{
        //    string userfist = "布";
        //    StartGame(userfist);
        //}
    }
}
