using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheCoffeeCafe;

namespace UnitTestCoffeeShop
{
    [TestClass]
    public class _1_Test_Login
    {
        int Login_1, Login_2, Login_3, Login_4, Login_5,
            Login_6, Login_7, Login_8, Login_9;

        [TestInitialize]
        public void setUp()
        {
            Login_1 = FunctionCheckLogin.kiemTra("","");
            Login_2 = FunctionCheckLogin.kiemTra("", "Invalid");
            Login_3 = FunctionCheckLogin.kiemTra("", "1");
            Login_4 = FunctionCheckLogin.kiemTra("Invalid", ""); 
            Login_5 = FunctionCheckLogin.kiemTra("Invalid", "Invalid");
            Login_6 = FunctionCheckLogin.kiemTra("Invalid", "1");
            Login_7 = FunctionCheckLogin.kiemTra("admin", "Invalid");
            Login_8 = FunctionCheckLogin.kiemTra("admin", "");
            Login_9 = FunctionCheckLogin.kiemTra("admin", "1");
        }

        [TestMethod]
        public void testCase_Login_1()
        {
            Assert.AreEqual(Login_1,1);
        }

        [TestMethod]
        public void testCase_Login_2()
        {
            Assert.AreEqual(Login_2, 1);
        }

        [TestMethod]
        public void testCase_Login_3()
        {
            Assert.AreEqual(Login_3, 1);
        }

        [TestMethod]
        public void testCase_Login_4()
        {
            Assert.AreEqual(Login_4, 1);
        }

        [TestMethod]
        public void testCase_Login_5()
        {
            Assert.AreEqual(Login_5, 1);
        }

        [TestMethod]
        public void testCase_Login_6()
        {
            Assert.AreEqual(Login_6, 1);
        }

        [TestMethod]
        public void testCase_Login_7()
        {
            Assert.AreEqual(Login_7, 1);
        }

        [TestMethod]
        public void testCase_Login_8()
        {
            Assert.AreEqual(Login_8, 1);
        }

        [TestMethod]
        public void testCase_Login_9()
        {
            Assert.AreEqual(Login_9, 0);
        }
    }
}
