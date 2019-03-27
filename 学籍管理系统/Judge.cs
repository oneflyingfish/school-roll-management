using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 学籍管理系统
{
    static class Judge
    {
        /// <summary>
        /// 判断是否是数字串，是数字串返回true,含有字符返回false
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public  static bool JudgeChars(string text)
        {
            int num;
            for (int i = 0; i < text.Length; i++)
            {
                if (!(int.TryParse(text[i].ToString(), out num)))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
