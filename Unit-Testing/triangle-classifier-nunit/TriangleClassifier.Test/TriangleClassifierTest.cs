using NUnit.Framework;
namespace TriangleClassifier.Test
{
    public class TriangleClassifierTest
    {
        private TriangleClassifier _triangleClassifier;
        [SetUp]
        public void Setup()
        {
            _triangleClassifier = new TriangleClassifier();
        }

        [Test]
        public void TestIsoscelesTriangle()
        {
            int side1 = 2;
            int side2 = 4;
            int side3 = 4;
            string expected = "Isosceles triangle.";
            string result = _triangleClassifier.ClassifyTriangle(side1, side2, side3);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void TestEquilateralTriangle()
        {
            int side1 = 4;
            int side2 = 4;
            int side3 = 4;
            string expected = "Equilateral triangle.";
            string result = _triangleClassifier.ClassifyTriangle(side1, side2, side3);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void TestNormalTriangle()
        {
            int side1 = 3;
            int side2 = 4;
            int side3 = 5;
            string expected = "Normal triangle.";
            string result = _triangleClassifier.ClassifyTriangle(side1, side2, side3);
            Assert.AreEqual(expected, result);
        }
    }
}