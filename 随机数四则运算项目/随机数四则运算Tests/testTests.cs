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
    public class testTests
    {
        [TestMethod()]
        public void test_ceTest()
        {
            //Assert.Fail();
            test t = new test();
            List<int> fh = new List<int> { 1, 2, 4 };
            List<int> list = new List<int> { 12, 34, 45, 0 };//组装的算式为12+34-45/0
            Assert.AreEqual(t.test_ce(fh, list), false);//断言结果为false
        }
    }
}