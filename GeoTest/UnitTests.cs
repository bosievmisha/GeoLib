using GeoLib.Figures;
using NUnit.Framework.Legacy;

namespace GeoTest
{
    [TestFixture]
    public class GeometryTests
    {
        [Test]
        public void TestCircleArea()
        {
            var circle = new Circle(5);
            ClassicAssert.AreEqual(Math.PI * 25, circle.calculateArea());
        }

        [Test]
        public void TestTriangleArea()
        {
            var triangle = new Triangle(3, 4, 5);
            ClassicAssert.AreEqual(6, triangle.calculateArea());
        }

        [Test]
        public void TestRightTriangleCheck()
        {
            var triangle = new Triangle(3, 4, 5);
            ClassicAssert.IsTrue(triangle.isRightTriangle());

            var nonRightTriangle = new Triangle(3, 4, 6);
            ClassicAssert.IsFalse(nonRightTriangle.isRightTriangle());
        }
    }
}
