using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07猜拳游戏
{
    /// <summary>
    /// 计算机
    /// </summary>
    public class PC
    {

        /// <summary>
        /// 用来保存出拳结果
        /// </summary>
        public string Fist
        {
            get;
            set;
        }

        /// <summary>
        /// 计算机出拳
        ///   剪刀→1  石头→2  布→3  
        /// </summary>
        /// <returns></returns>
        public int ShowFist()
        {
            Random rdn = new Random();
            int n = rdn.Next(1, 4);
            switch (n)
            {
                case 1:
                    this.Fist = "剪刀";
                    break;
                case 2:
                    this.Fist = "石头";
                    break;
                case 3:
                    this.Fist = "布";
                    break;
            }

            return n;

        }
    }
}
