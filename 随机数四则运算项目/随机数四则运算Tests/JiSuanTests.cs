using Microsoft.VisualStudio.TestTools.UnitTesting;
using 随机数四则运算;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 随机数四则运算.Tests
{
    [TestClass()]
    public class JiSuanTests
    {
        [TestMethod()]
        public void JiSuanTest()
        {
            int fh_len = 2;
            List<int> fh = new List<int>() { 3, 4 };
            List<int> list = new List<int>() { 2, 50, 25 };
            JiSuan j = new JiSuan(fh_len, list, fh);
            Assert.AreEqual(int.Parse(j.r.ToString()), 4);//运算式为：2*50/25，结果为4
            //断言为4是正确的。
        }
    }
}