using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathUtilities;


namespace MathUtilities.Tests
{
    [TestClass]
    public class MathHelperTests
    {
        private static List<TestCase> _testCases;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            _testCases = new List<TestCase>
            {
                new TestCase(1, 2, 5, null, null),    
                new TestCase(1, 2, 1, -1, null),     
                new TestCase(1, -3, 2, 2, 1)         
            };
        }

        [TestMethod]
        public void TestFindRoots_DLessThanZero()
        {
            var testCase = _testCases[0]; 
            var (root1, root2) = MathHelper.FindRoots(testCase.A, testCase.B, testCase.C);

            Assert.AreEqual(testCase.ExpectedRoot1, root1, $"Ожидался корень1: {testCase.ExpectedRoot1}, получили: {root1}");
            Assert.AreEqual(testCase.ExpectedRoot2, root2, $"Ожидался корень2: {testCase.ExpectedRoot2}, получили: {root2}");
        }

        [TestMethod]
        public void TestFindRoots_DEqualZero()
        {
            var testCase = _testCases[1]; 
            var (root1, root2) = MathHelper.FindRoots(testCase.A, testCase.B, testCase.C);

            Assert.AreEqual(testCase.ExpectedRoot1, root1, $"Ожидался корень1: {testCase.ExpectedRoot1}, получили: {root1}");
            Assert.AreEqual(testCase.ExpectedRoot2, root2, $"Ожидался корень2: {testCase.ExpectedRoot2}, получили: {root2}");
        }

        [TestMethod]
        public void TestFindRoots_DGreaterThanZero()
        {
            var testCase = _testCases[2]; 
            var (root1, root2) = MathHelper.FindRoots(testCase.A, testCase.B, testCase.C);

            Assert.AreEqual(testCase.ExpectedRoot1, root1, $"Ожидался корень1: {testCase.ExpectedRoot1}, получили: {root1}");
            Assert.AreEqual(testCase.ExpectedRoot2, root2, $"Ожидался корень2: {testCase.ExpectedRoot2}, получили: {root2}");
        }

        [TestMethod]
        public void TestCalculatePercentage_WithDelta()
        {
            double delta = 0.01; 
            var testCases = new (double total, double percentage, double expected)[]
            {
                (100, 20, 20),        
                (200, 10, 20),       
                (500, 50, 250),       
                (300, 0, 0)           
            };

            foreach (var (total, percentage, expected) in testCases)
            {
                double result = MathHelper.CalculatePercentage(total, percentage);
                Assert.AreEqual(expected, result, delta, $"Для total: {total} и percentage: {percentage} ожидалось: {expected}, получили: {result}");
            }
        }
    }

    public class TestCase
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double? ExpectedRoot1 { get; set; }
        public double? ExpectedRoot2 { get; set; }

        public TestCase(double a, double b, double c, double? expectedRoot1, double? expectedRoot2)
        {
            A = a;
            B = b;
            C = c;
            ExpectedRoot1 = expectedRoot1;
            ExpectedRoot2 = expectedRoot2;
        }
    }
}

