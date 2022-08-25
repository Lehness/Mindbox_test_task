using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractFigure;


namespace FigureTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TriangleArea()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.Area());
        }
        [TestMethod]
        public void CircleArea()
        {
            Circle circle = new Circle(5);
            Assert.AreEqual(78,54, Math.Round(circle.Area(), 2));
        }

        [TestMethod]

        public void TriangleIsRight()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(true, triangle.IsRight());
        }

        [TestMethod]

        public void TriangleIsNotRight()
        {
            Triangle triangle = new Triangle(3, 4, 6);
            Assert.AreEqual(false, triangle.IsRight());
        }

        [TestMethod]

        public void CheckTriangleConstruct()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(3, triangle.Side1);
            Assert.AreEqual(4, triangle.Side2);
            Assert.AreEqual(5, triangle.Side3);
        }

        [TestMethod]

        public void CheckTriangleWrongConstruct()
        {
            Triangle triangle = new Triangle(-3, -4, -5);
            Assert.AreEqual(3, triangle.Side1);
            Assert.AreEqual(4, triangle.Side2);
            Assert.AreEqual(5, triangle.Side3);
        }

        [TestMethod]

        public void CheckCircleConstruct()
        {
            Circle circle = new Circle(5);
            Assert.AreEqual(5, circle.Radius);
        }

        [TestMethod]

        public void CheckCircleWrongConstruct()
        {
            Circle circle = new Circle(-5);
            Assert.AreEqual(5, circle.Radius);
        }

    }
}
