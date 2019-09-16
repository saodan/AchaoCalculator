using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace 随机数四则运算
{
    class JiSuan
    {
        public JiSuan(int fh_len, List<int> list, List<int> fh)
        {
            Dictionary<int, string> hash = new Dictionary<int, string> { { 1, "+" }, { 2, "-" }, { 3, "*" }, { 4, "/" } };
            foreach (int i in list)
                Console.Write(i+" ");
            Console.WriteLine();
            foreach (int j in fh)
                Console.Write( hash[j]+ " ");
            Console.WriteLine();
            int len = fh.Count();
            string ji=null;
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
            Console.WriteLine(ji);
            var r = new DataTable().Compute(ji, null);
            Console.WriteLine(r);
        }
    }
}
