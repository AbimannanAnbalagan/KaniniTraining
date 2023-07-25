using Calculations;
using MathOperations;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestFixture(10, 20)]
    public class CalculationsTest
    {

        private Calculator? calculations;
        private int n1;
        private int n2;

        public CalculationsTest(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

                                   
        [SetUp]
        public void SetUp()
        {
            calculations = new Calculator( n1, n2);
            Console.WriteLine("Setup");
        }

        [TestCase(Author = "Abimannan" , Description = "Testing Add method")]
        [Order(2)]
        public void AddTest()
        {
            //Calculations calculations = new Calculations(76,67);
            int result = calculations.Add();
            Assert.AreEqual(n1+n2, result);
            Console.WriteLine("Add");

        }
        [Ignore("No need As of now" , Until = "2023-07-11 12:59:00")]
        [Test]
        [Order(1)]
        public void SubTest()
        {
            //Calculations calculations = new Calculations(7, 6);
            int result = calculations.Subtract();
            Assert.AreEqual(n1-n2, result);
            Console.WriteLine("Sub");

        }

        [TearDown]
        public void CloseTest()
        {
            calculations = null;
            Console.WriteLine("TearDown");
        }
    }
}
