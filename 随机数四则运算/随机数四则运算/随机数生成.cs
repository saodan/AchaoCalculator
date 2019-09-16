using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;

namespace 随机数四则运算
{
    class Sui
    {
        bool p = false;
        public Sui(int len)//len:题目的数量,list:随机数集合，fh:符号集合，[1:+],[2:-],[3:*],[4:/]
        {
            string path = @"F:/四则运算.txt";
            File.WriteAllText(path, "");//清空文本
            int seed = Guid.NewGuid().GetHashCode();//随机数种子
            Random random = new Random(seed);
            List<int> fh=new List<int>();
            List<int> list=new List<int>();
            for (int i = 0; i < len;)
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
                test t = new test();
                if (t.test_ce(fh, list))
                {
                    JiSuan Ji = new JiSuan(fh_len1, list, fh,path);
                    p = Ji.Tc();
                }
                fh.Clear();
                list.Clear();
                if (p)
                {
                    i++;
                }      
            }
        }
    }
}
