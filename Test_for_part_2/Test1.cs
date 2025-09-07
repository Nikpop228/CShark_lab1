namespace Test_for_part_2
{
    [TestClass]
    public sealed class TestRectangle
    {

        [DataTestMethod]
        [DataRow(12.5, 16.1)]
        [DataRow(22, 6.1)]
        [DataRow(11, 18.5)]
        public void TestArea(double x, double y)
        {
            Rectangle rectangle = new(x, y);
            double area = x * y;
            Assert.AreEqual(area, rectangle.Area);
        }

        [DataTestMethod]
        [DataRow(12.5, 16.1)]
        [DataRow(22, 6.1)]
        [DataRow(11, 18.5)]
        public void TestPerimetr(double x, double y)
        {
            Rectangle rectangle = new(x, y);
            double perimetr = 2 * (x + y);
            Assert.AreEqual(perimetr, rectangle.Perimetr);
        }
    }
}
