using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07猜拳游戏
{
    public class CaiPan
    {
        /// <summary>
        /// 判断是否玩家赢了。
        /// </summary>
        /// <returns>返回结果-1表示用户输了，0表示平局， 1表示用户赢了</returns>
        public static int IsPlayerWin(int playerFist, int pcFist)
        {
            if (playerFist == pcFist)
            {
                return 0;
            }
            else if (playerFist - pcFist == -2 || playerFist - pcFist == 1)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
