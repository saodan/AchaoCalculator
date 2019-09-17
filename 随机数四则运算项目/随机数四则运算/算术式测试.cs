using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitTestGenerator;

namespace 随机数四则运算
{
    public class test
    {
        public bool test_ce(List<int> fh, List<int> list)
        {
            int j = 0;
            Dictionary<int, string> hash = new Dictionary<int, string> { { 1, "+" }, { 2, "-" }, { 3, "*" }, { 4, "/" } };
            foreach (int i in fh)
            {
                if (hash[i] != "/")
                {
                    j++;
                    continue;
                }
                else
                {
                    if (list[j + 1] != 0)
                        return true;
                    else
                        return false;
                }
            }
            return true;
        }
           
    }
}
