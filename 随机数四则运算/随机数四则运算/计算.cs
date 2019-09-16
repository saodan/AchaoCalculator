using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

namespace 随机数四则运算
{
    class JiSuan
    {
        bool t = false;
        string str;
        public JiSuan(int fh_len, List<int> list, List<int> fh,string path)
        {
            Dictionary<int, string> hash = new Dictionary<int, string> { { 1, "+" }, { 2, "-" }, { 3, "*" }, { 4, "/" } };
            int len = fh.Count();
            string ji=null;
            /*组装运算式*/
            for(int i=0,j=0;i<len;)
            {
                if (j < fh.Count())
                {
                    ji += list[i] + hash[fh[j]];
                    j++;
                }
                else
                {
                    ji += list[i];
                    i++;
                }
                i++;
            }
            ji += list[len];
            /*利用datatable().Compute进行四则运算*/
            var r = new DataTable().Compute(ji, null);
            int num;
            if (int.TryParse(r.ToString(), out num))//判断计算结果是否为整数
            {
                str = ji + "=" + r.ToString()+"\n";
                Console.Write(str);
                t = true;//判断成功生成一个运算式
                File.AppendAllText(path, str);
            }
        }
        public bool Tc()
        {
            return t;
        }
    }
}
