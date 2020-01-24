using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        Calculator1 obj = new Calculator1();
        [TestMethod]
        
        public void checkadd()
        {
            int a = -4;
            int b = 4;                     
            int expected = a + b;
            int actual = obj.add(a, b);
            Assert.AreEqual(actual, expected, 0, "Result is wrong");
            int a1 = int.MaxValue;
            int b1 = int.MaxValue;
            Assert.ThrowsException<System.OverflowException>(() => obj.add(a1, b1));
            int a2 = int.MaxValue;
            int b2 = 23;
            Assert.ThrowsException<System.OverflowException>(() => obj.add(a2, b2));
            int a3 = int.MinValue;
            int b3 = -2;
            Assert.ThrowsException<System.OverflowException>(() => obj.add(a3, b3));
        }
        [TestMethod]
        public void checksub()
        {
            int a = -4;
            int b = 4;
            int expected = a - b;
            int actual = obj.sub(a, b);
            Assert.AreEqual(actual, expected, 0, "Result is wrong");
            int a1 = int.MaxValue;
            int b1 = int.MinValue;
            Assert.ThrowsException<System.OverflowException>(() => obj.sub(a1, b1));
            int a2 = int.MaxValue;
            int b2 = -23;
            Assert.ThrowsException<System.OverflowException>(() => obj.sub(a2, b2));
            int a3 = int.MinValue;
            int b3 = 2;
            Assert.ThrowsException<System.OverflowException>(() => obj.sub(a3, b3));
        }
        [TestMethod]
        public void checkmul()
        {
            int a = -4;
            int b = 4;
            int expected = a * b;
            int actual = obj.mul(a, b);
            Assert.AreEqual(actual, expected, 0, "Result is wrong");
            int a2 = int.MaxValue;
            int b2 = 23;
            Assert.ThrowsException<System.OverflowException>(() => obj.mul(a2, b2));
            int a3 = int.MinValue;
            int b3 = -2;
            Assert.ThrowsException<System.OverflowException>(() => obj.mul(a3, b3));
        }
        [TestMethod]
        public void ckeckdiv()
        {
            int a = 4;
            int b = 4;
            int expected = a / b;
            int actual = obj.div(a, b);
            Assert.AreEqual(actual, expected, 0, "Result is wrong");
            int a1 = 4;
            int b1 = 0;
            Assert.ThrowsException<System.DivideByZeroException>(() => obj.div(a1, b1));

        }
    }
}
