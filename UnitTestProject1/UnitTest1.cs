using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WpfApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MainWindow window = new MainWindow();
            Assert.IsTrue(window.Calculate("2", "5", "6"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            MainWindow window = new MainWindow();
            Assert.IsFalse(window.Calculate("", "", "6"));
            Assert.IsFalse(window.Calculate("6", "", ""));
            Assert.IsFalse(window.Calculate("", "6", ""));
        }
        [TestMethod]
        public void TestMethod3()
        {
            MainWindow window = new MainWindow();
            Assert.IsFalse(window.Calculate("18", "20", "6.5"));
            Assert.IsFalse(window.Calculate("18", "6.5", "2"));
            Assert.IsFalse(window.Calculate("6.5", "20", "5"));
        }
        [TestMethod]
        public void TestMethod4()
        {
            MainWindow window = new MainWindow();
            Assert.IsFalse(window.Calculate("erf", "24", "16"));
            Assert.IsFalse(window.Calculate("13", "2fh", "16"));
            Assert.IsFalse(window.Calculate("12", "24", "huhg"));
        }
        [TestMethod]
        public void TestMethod5()
        {
            MainWindow window = new MainWindow();
            Assert.IsFalse(window.Calculate("3", "-3", "6"));
            Assert.IsFalse(window.Calculate("3", "29", "-19"));
            Assert.IsFalse(window.Calculate("-12", "7", "5"));
        }
        [TestMethod]
        public void TestMethod6()
        {
            MainWindow window = new MainWindow();
            Assert.IsFalse(window.Calculate("&*^$", "6", "12"));
            Assert.IsFalse(window.Calculate("7", "6", "&*^*("));
            Assert.IsFalse(window.Calculate("16", "^%%$", "19"));
        }
        [TestMethod]
        public void TestMethod7()
        {
            MainWindow window = new MainWindow();
            Assert.IsFalse(window.Calculate(" ", " ", " "));
        }
        [TestMethod]
        public void TestMethod8()
        {
            MainWindow window = new MainWindow();
            Assert.IsFalse(window.Calculate("23", "4", "12"));
            Assert.IsFalse(window.Calculate("15", "49", "3"));
            Assert.IsFalse(window.Calculate("17", "6", "27"));
        }
    }
}
