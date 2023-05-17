using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static System.Net.Mime.MediaTypeNames;
using попытка_намбер_дохуя;

namespace testblyaa
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            string n = "10";
            string expected = "";
            string rez = Program.prov(n);
            Assert.AreEqual(expected, rez);


        }

        [TestMethod]
        public void TestMethod2()
        {
            string n = "p";
            string expected = "вы ввели неправильное значение";
            string rez = Program.prov(n);
            Assert.AreEqual(expected, rez);


        }

        [TestMethod]
        public void TestMethod3()
        {
            string n = "-7";
            string expected = "вы велли отрицательное число";
            string rez = Program.prov(n);
            Assert.AreEqual(expected, rez);


        }

        [TestMethod]
        public void TestMethod4()
        {
            string n = "0";
            string expected = "вы велли 0";
            string rez = Program.prov(n);
            Assert.AreEqual(expected, rez);


        }

        public void TestMethod5()
        {
            string m = "10";
            string expected = "";
            string rez = Program.prov(m);
            Assert.AreEqual(expected, rez);


        }

        [TestMethod]
        public void TestMethod6()
        {
            string m = "p";
            string expected = "вы ввели неправильное значение";
            string rez = Program.prov(m);
            Assert.AreEqual(expected, rez);


        }

        [TestMethod]
        public void TestMethod7()
        {
            string m = "-7";
            string expected = "вы велли отрицательное число";
            string rez = Program.prov(m);
            Assert.AreEqual(expected, rez);


        }

        [TestMethod]
        public void TestMethod8()
        {
            string m = "0";
            string expected = "вы велли 0";
            string rez = Program.prov(m);
            Assert.AreEqual(expected, rez);


        }
    }
}
