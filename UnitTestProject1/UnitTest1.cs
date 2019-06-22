using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task9;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MyList l1 = new MyList();
            int n = Program.rnd.Next(0, 15);
            l1.Create(n, 1);
            Assert.AreEqual(MyList.Count, n);
            l1.Count1();
            l1.Count2();
            l1.Show();
            MyList l2 = new MyList();
            l2.Count1();
            l2.Show();
        }
        [TestMethod]
        public void TestMethod2()
        {
            Node n1 = new Node();
            Assert.AreEqual(n1.data, 0);
            Assert.AreEqual(n1.last, null);
            Assert.AreEqual(n1.next, null);
        }
    }
}
