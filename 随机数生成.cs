using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace 随机数四则运算
{
    class Sui
    {
        public Sui(int len)//len:题目的数量,list:随机数集合，fh:符号集合，[1:+],[2:-],[3:*],[4:/]
        {
            int seed = Guid.NewGuid().GetHashCode();//随机数种子
            Random random = new Random(seed);
            List<int> fh=new List<int>();
            List<int> list=new List<int>();
            for (int i = 0; i < len; i++)
            {
                int fh_len1 = random.Next(2,4);//fh_len1:题目的符号数量
                for (int j = 0; j < fh_len1; j++)
                {
                    int h = random.Next(1, 5);
                    fh.Insert(j, h);//随机生成运算符
                }
                for (int j = 0; j < fh_len1 + 1; j++)
                {
                    int h = random.Next(0, 101);
                    list.Insert(j, h);//生成随机数
                }
                JiSuan Ji = new JiSuan(fh_len1,list, fh);
                fh.Clear();
                list.Clear();
            }

        }
    }
}
