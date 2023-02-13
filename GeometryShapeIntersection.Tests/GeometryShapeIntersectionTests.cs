using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryShapeIntersection.Domain;
using GeometryShapeIntersection.Application;
using System;

namespace GeometryShapeIntersection.Tests
{
    [TestClass]
    public class GeometryShapeIntersectionTests
    {
        private IGeometryShapeCalculator _calculator;

        [TestInitialize]
        public void TestInitialize()
        {
            _calculator = new GeometryShapeCalculator();
        }
        [TestMethod]
        public void Intersects_WhenShapesDoIntersect_ReturnsTrue()
        {
            // Arrange
            var shape1 = new Cube(1, 0, 0, 0, 1);
            var shape2 = new Cube(2, 0.5, 0.5, 0.5 , 1);

            // Act
            bool result = _calculator.Intersects(shape1, shape2);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Intersects_WhenShapesDoNotIntersect_ReturnsFalse()
        {
            // Arrange
            var shape1 = new Cube(1, 0, 0, 0, 1);
            var shape2 = new Cube(2, 2, 2, 2, 1);

            // Act
            bool result = _calculator.Intersects(shape1, shape2);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CalculateIntersectedVolume_WhenShapesDoIntersect_ReturnsCorrectVolume()
        {
            // Arrange
            var shape1 = new Cube(1, 0, 0, 0, 2);
            var shape2 = new Cube(2, 0.5, 0.5, 0.5, 1);

            // Act
            double result = _calculator.CalculateIntersectedVolume(shape1, shape2);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void CalculateIntersectedVolume_WhenShapesDoNotIntersect_ReturnsZero()
        {
            // Arrange
            var shape1 = new Cube(1, 0, 0, 0, 1);
            var shape2 = new Cube(2, 2, 2, 2, 1);

            // Act
            double result = _calculator.CalculateIntersectedVolume(shape1, shape2);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestGetIntersectionResult_WithNonIntersectingShapes_ReturnsCorrectMessage()
        {
            var shape1 = new Cube(1, 0, 0, 0, 1);
            var shape2 = new Cube(2, 3, 3, 3, 1);

            var result = _calculator.GetIntersectionResult(shape1, shape2);

            Assert.AreEqual("The shapes do not intersect.", result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCalculateIntersectedVolume_WithNegativeSize_ThrowsException()
        {
            var shape1 = new Cube(1, 0, 0, 0, -1);
            var shape2 = new Cube(2, 0, 0, 0, 2);

            _calculator.CalculateIntersectedVolume(shape1, shape2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetIntersectionResult_WithNegativeSize_ThrowsException()
        {
            var shape1 = new Cube(1, 0, 0, 0, -1);
            var shape2 = new Cube(2, 0, 0, 0, 2);

            _calculator.GetIntersectionResult(shape1, shape2);
        }
    }
}