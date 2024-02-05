using DataStructures_Algorithms_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures_Algorithms_Project;

namespace _ExampleTest
{
    [TestFixture]
    public class BasicTests
    {
        [Test]
        public void AdditionTest()
        {
            int result = Calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void SubtractionTest()
        {
            int result = Calculator.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void MultiplicationTest()
        {
            int result = Calculator.Multiply(2, 4);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void DivisionTest()
        {
            double result = Calculator.Divide(10, 2);
            Assert.AreEqual(5.0, result);
        }
    }
}
