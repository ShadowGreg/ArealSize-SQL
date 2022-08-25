using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArealSize.Tests
{
    
    [TestClass()]
    public class ArealSizeTests
    {
        public class TestArealSize : ArealSize
        {
            public string input;
            public override string ConsoleInput()
            {
                return input;
            }
        }
        [TestMethod()]
        public void ArealSize_for_Circle_Test()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            TestArealSize testArealSize = new TestArealSize();
            testArealSize.input = 12.ToString();
            testArealSize.Area();
            Assert.IsNotNull(sw.ToString());
        }
        [TestMethod()]
        public void ArealSize_for_Triangle_Test()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            TestArealSize testArealSize = new TestArealSize();
            testArealSize.input = (string)"12;8;9";
            testArealSize.Area();
            Assert.IsNotNull(sw.ToString());
        }
        [TestMethod()]
        public void ArealSize_for_CalculationAlgorithm_Test()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            TestArealSize testArealSize = new TestArealSize();
            testArealSize.input = (string)"1;1;3;3;2;5;1;4;0;3";
            testArealSize.Area();
            Assert.IsNotNull(sw.ToString());
        }

        [TestMethod()]
        public void Circle_Test()
        {
            double radius = 4;
            double expectedArea = 50.26548245743669;
            Circle tesCircle = new Circle(radius);
            var actualArea = tesCircle.Area();

            Assert.AreEqual(expectedArea, actualArea, "Method is incorrect");
        }
        [TestMethod()]
        public void Triangle_Test()
        {
            double _climeA = 2, _climeB = 4, _climeC = 3;
            double expectedArea = 2.9047375096555625;
            Triangle tesTriangle = new Triangle(_climeA, _climeB, _climeC);
            var actualArea = tesTriangle.Area();

            Assert.AreEqual(expectedArea, actualArea, "Method is incorrect");
        }
        [TestMethod()]
        public void Triangle_Test_First_Error()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            Triangle testTriangle = new Triangle(1, 2, 5);
            testTriangle.Area();

            string expected = string.Format("The triangle does not exist{0}", Environment.NewLine);
            Assert.AreEqual<string>(expected, sw.ToString());
        }
        [TestMethod()]
        public void Triangle_Test_Second_Error()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            Triangle testTriangle = new Triangle(-11, 2, 5);
            testTriangle.Area();

            string expected = string.Format("The sides of a triangle cannot be less than zero{0}", Environment.NewLine);
            Assert.AreEqual<string>(expected, sw.ToString());
        }
        [TestMethod()]
        public void Triangle_Test_Right_Angled()
        {
            double _climeB = 3, _climeC = 4;
            double _climeA = Math.Sqrt(Math.Pow(_climeB, 2) + Math.Pow(_climeC, 2));
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            Triangle testTriangle = new Triangle(_climeA, _climeB, _climeC);
            testTriangle.Area();

            string expected = string.Format("Right angled triangle{0}", Environment.NewLine);
            Assert.AreEqual<string>(expected, sw.ToString());
        }
        [TestMethod()]
        public void Calculation_Algorithm_Test()
        {
            var listDouble = new List<double>(){1,1,3,3,2,5,1,4,0,3};
            double expectedArea = 1.5;
            CalculationAlgorithm tesCalculationAlgorithm = new CalculationAlgorithm(listDouble);
            var actualArea = tesCalculationAlgorithm.AreaCalculation();

            Assert.AreEqual(expectedArea, actualArea, "Method is incorrect");
        }
    }
}