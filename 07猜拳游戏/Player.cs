using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07猜拳游戏
{
    //ctrl + tab


    /// <summary>
    /// 玩家类
    /// </summary>
    public class Player
    {

        //用来保存用户出拳结果！
        public string Fist
        {
            get;
            set;
        }
        /// <summary>
        /// 假设    剪刀→1  石头→2  布→3  
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int ShowFist(string name)
        {
            this.Fist = name;
            switch (name)
            {
                case "剪刀":
                    return 1;
                case "石头":
                    return 2;
                case "布":
                    return 3;
                default:
                    throw new ArgumentException("参数异常");
            }
            
        }
    }

}
