using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheCoffeeCafe;

namespace UnitTestCoffeeShop
{

    [TestClass]
    public class _2_Test_Home
    {
        bool Add_False, Add_True, CheckOut_True, CheckOut_False, Del_True, Del_False;

        [TestInitialize]
        public void setUp()
        {
            Add_False = FunctionCheckHome.kiemTraBan(0);
            Add_True = FunctionCheckHome.kiemTraBan(1);
            CheckOut_False = FunctionCheckHome.kiemTraListView(0);
            CheckOut_True = FunctionCheckHome.kiemTraListView(1);
            Del_False = FunctionCheckHome.kiemTraDel(0);
            Del_True = FunctionCheckHome.kiemTraDel(1);
        }

        [TestMethod]
        public void testCase_Them_Duoc()
        {
            Assert.IsTrue(Add_True);
        }

        [TestMethod]
        public void testCase_Them_KhongDuoc()
        {
            Assert.IsFalse(Add_False);
        }

        [TestMethod]
        public void testCase_ThanhToan_Duoc()
        {
            Assert.IsTrue(CheckOut_True);
        }

        [TestMethod]
        public void testCase_ThanhToan_KhongDuoc()
        {
            Assert.IsFalse(CheckOut_False);
        }

        [TestMethod]
        public void testCase_Xoa_Duoc()
        {
            Assert.IsTrue(Del_True);
        }

        [TestMethod]
        public void testCase_Xoa_KhongDuoc()
        {
            Assert.IsFalse(Del_False);
        }
    }
}
