namespace Test_for_part_3
{
    [TestClass]
    public sealed class TestFigure
    {
        Point p1 = new Point(5, 10);
        Point p2 = new Point(6, 11);
        Point p3 = new Point(0, 10);
        Point p4 = new Point(7, 1);
        Point p5 = new Point(4, 25);

        [TestMethod]
        public void TestNameFor3Points()
        {
            Figure figure = new(p1, p2, p3);
            Assert.AreEqual("Треугольник", figure.Name);
        }

        [TestMethod]
        public void TestNameFor4Points()
        {
            Figure figure = new(p1, p2, p3, p4);
            Assert.AreEqual("Прямоугольник", figure.Name);
        }

        [TestMethod]
        public void TestNameFor5Points()
        {
            Figure figure = new(p1, p2, p3, p4, p5);
            Assert.AreEqual("Пятиугольник", figure.Name);
        }

        [TestMethod]
        public void TestLengthSide()
        {
            Figure figure = new(p1, p2, p3);
            double a = p1.X - p2.X;
            double b = p1.Y - p2.Y;
            double length = Math.Sqrt(a*a + b*b);
            Assert.AreEqual(length, figure.LengthSide(p1,p2));
        }

        [TestMethod]
        public void TestPerimeterCalculator()
        {
            Figure figure = new(p1, p2, p3);
            double perimetr = figure.LengthSide(p1, p2) + figure.LengthSide(p2, p3) + figure.LengthSide(p1, p3);
            Assert.AreEqual(perimetr, figure.PerimeterCalculator());
        }
    }
}
