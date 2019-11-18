using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheCoffeeCafe;

namespace UnitTestCoffeeShop
{
    [TestClass]
    public class _3_Test_KHTT
    {
       bool KH_HopLe, KH_KhongHopLe_1, KH_KhongHopLe_2, KH_KhongHopLe_3;

       [TestInitialize]
       public void setUp()
       {
           KH_HopLe = FunctionCheckKhachHang.kiemtra("DangQuangMinh");
           KH_KhongHopLe_1 = FunctionCheckKhachHang.kiemtra("ABCDEZ");
           KH_KhongHopLe_2 = FunctionCheckKhachHang.kiemtra("123456789");
           KH_KhongHopLe_3 = FunctionCheckKhachHang.kiemtra(".........");
       }

       [TestMethod]
       public void testCase_KHTT_HopLe()
       {
           Assert.IsTrue(KH_HopLe);
       }

       [TestMethod]
       public void testCase_KHTT_ABCD()
       {
           Assert.IsFalse(KH_KhongHopLe_1);
       }

       [TestMethod]
       public void testCase_KHTT_123456()
       {
           Assert.IsFalse(KH_KhongHopLe_2);
       }

       [TestMethod]
       public void testCase_KHTT_dau()
       {
           Assert.IsFalse(KH_KhongHopLe_3);
       }
    }
}
