

using TestMindBox;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //Тесты для круга
        [TestMethod]
        public void TestRadius3()
        {
            Circle circle = new Circle(3);
            Assert.AreEqual(28.274333882308138, circle.Area());
        }
        [TestMethod]
        public void TestRadiusEquals0()
        {
            Action a = () => new Circle(0);

            Assert.ThrowsException<Exception>(() => a());
        }
        [TestMethod]
        public void TestRadiusLessThan0()
        {
            Action a = () => new Circle(-2);
            Assert.ThrowsException<Exception>(() => a());
        }
        //Тесты для треугольника
        [TestMethod]
        public void TestZeroTriangle1()
        {
            Action a = () => new Triangle(0, 1, 1);
            Assert.ThrowsException<Exception>(() => a());
        } 
        [TestMethod]
        public void TestZeroTriangle2()
        {
            Action a = () => new Triangle(1, 0, 1);
            Assert.ThrowsException<Exception>(() => a());
        } [TestMethod]
        public void TestZeroTriangle3()
        {
            Action a = () => new Triangle(1, 1, 0);
            Assert.ThrowsException<Exception>(() => a());
        } 
        [TestMethod]
        public void TestNegativeTriangle()
        {
            Action a = () => new Triangle(-1, 1, 1);
            Assert.ThrowsException<Exception>(() => a());
        }
        [TestMethod]
        public void TestBadTriangle1()
        {
            Action a = () => new Triangle(3, 2, 5);
            Assert.ThrowsException<Exception>(() => a());
        }
        [TestMethod]
        public void TestBadTriangle2()
        {
            Action a = () => new Triangle(3, 5, 2);
            Assert.ThrowsException<Exception>(() => a());
        }
        [TestMethod]
        public void TestBadTriangle3()
        {
            Action a = () => new Triangle(5, 2, 3);
            Assert.ThrowsException<Exception>(() => a());
        }
        [TestMethod]
        public void TestRightTriangle ()
        {
            Triangle triangle =  new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.Area());
        }
        [TestMethod]
        public void TestGoodTriangle ()
        {
            Triangle triangle =  new Triangle(3, 5, 7);
            Assert.AreEqual(6.49519052838329, triangle.Area());
        }


    }
}